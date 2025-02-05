using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ConsolaPruebas4
{
    class Program
    {
        private static IPAddress ipPLC;
        private static readonly List<Comando> comandos = new List<Comando>()
        {
            new Comando(1, "Rojo - CRUZ/FLECHA", 30002, "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e3c53656d61666f726f4372757a466c656368613e524f4a4f3c2f53656d61666f726f4372757a466c656368613e3c506963746f6772616d6143616a65726f3e4150414741444f3c2f506963746f6772616d6143616a65726f3e3c506963746f6772616d6142616e63617269613e4150414741444f3c2f506963746f6772616d6142616e63617269613e3c506963746f6772616d6154656c657065616a653e4150414741444f3c2f506963746f6772616d6154656c657065616a653e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373538373239333338383c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e00"),
            new Comando(2, "Verde - CRUZ/FLECHA", 30002, "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e3c53656d61666f726f4372757a466c656368613e56455244453c2f53656d61666f726f4372757a466c656368613e3c506963746f6772616d6143616a65726f3e454e43454e4449444f3c2f506963746f6772616d6143616a65726f3e3c506963746f6772616d6142616e63617269613e454e43454e4449444f3c2f506963746f6772616d6142616e63617269613e3c506963746f6772616d6154656c657065616a653e454e43454e4449444f3c2f506963746f6772616d6154656c657065616a653e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373538373239333536333c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e00"),
            new Comando(3, "Barrera Cerrada", 30002, "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e3c4261727265726141636365736f3e414249455254413c2f4261727265726141636365736f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373538373330363737373c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e00"),
            new Comando(4, "Barrera Abierta", 30002, "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e3c4261727265726141636365736f3e414249455254413c2f4261727265726141636365736f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373538373330363737373c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e00")
        };

        public const int timeoutMs = 2000;

        static async Task Main(string[] args)
        {
            Console.Title = "Control PLC Industrial v2.0";
            ConfigurarConexion();
            
             await Task.Delay(20);
            while (true)
            {
                MostrarMenu();
                ProcesarComando();
            }
        }

        static void ConfigurarConexion()
        {
            do
            {
                Console.Write("IP del PLC: ");
            } while (!IPAddress.TryParse(Console.ReadLine(), out ipPLC));

            Log("Configuración de red completada");
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("=== MENU DE CONTROL ===");
            foreach (var cmd in comandos)
            {
                Console.WriteLine($"[{cmd.Id}] {cmd.Descripcion.PadRight(25)} [Puerto: {cmd.PuertoDestino}]");
            }
            Console.Write("\nSelección: ");
        }

        static void ProcesarComando()
        {
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var cmd = comandos.FirstOrDefault(c => c.Id == id);
                cmd?.Enviar(ipPLC);
            }
        }

        public static void Log(string mensaje)
        {
            string entrada = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensaje}";
            Console.WriteLine(entrada);
            File.AppendAllText("comandos.log", entrada + Environment.NewLine);
        }
    }

    public class Comando
    {
        public int Id { get; }
        public string Descripcion { get; }
        public int PuertoDestino { get; }
        public string DatosHex { get; }

        public Comando(int id, string desc, int puerto, string hex)
        {
            Id = id;
            Descripcion = desc;
            PuertoDestino = puerto;
            DatosHex = ValidarHex(hex);
        }

        private string ValidarHex(string hex)
        {
            string hexLimpio = hex.Replace(" ", "");
            
            if (hexLimpio.Length % 2 != 0)
                throw new ArgumentException("Longitud hexadecimal inválida");
            
            if (!hexLimpio.All(c => "0123456789abcdefABCDEF".Contains(c)))
                throw new ArgumentException("Caracteres hexadecimales inválidos");

            return hexLimpio;
        }

        public void Enviar(IPAddress ip)
        {
            try
            {
                byte[] datos = HexToBytes(DatosHex);
                
                using (UdpClient cliente = new UdpClient())
                {
                    cliente.Client.SendTimeout = Program.timeoutMs; // Acceso permitido
                    IPEndPoint destino = new IPEndPoint(ip, PuertoDestino);
                    
                    cliente.Send(datos, datos.Length, destino);
                    Program.Log($"✅ {Descripcion} enviado a {ip}:{PuertoDestino}");
                }
            }
            catch (Exception ex)
            {
                Program.Log($"❌ Error en {Descripcion}: {ex.Message}");
            }
        }

        private byte[] HexToBytes(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }
    }
}
    