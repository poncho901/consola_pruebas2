using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Consola_Pruebas4.cs;
using System.Threading.Tasks;

namespace Consola_Pruebas4
{
    class Program
    {
        private static IPAddress ipPLC;

        static async Task Main(string[] args)
        {
            Console.Title = "Control PLC - Inicializacion de servicio v2.0";
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
            Console.WriteLine("[1] Enviar comando de cierre");
            Console.WriteLine("[2] Enviar comando de validación");
            Console.WriteLine("[3] Enviar comandos de inicialización");
            Console.Write("\nSelección: ");
        }

        static async void ProcesarComando()
        {
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                switch (id)
                {
                    case 1:
                        EnviarComando(AutoFrames.GetCierre());
                        break;
                    case 2:
                        EnviarComando(AutoFrames.GetValidacion());
                        break;
                    case 3:
                        var init = AutoFrames.GetInit();
                        foreach (var cmd in init)
                        {
                            EnviarComando(cmd);
                           await Task.Delay(20);
                        }
                        break;
                    default:
                        Log("Opción no válida");
                        break;
                }
            }
        }

        static void EnviarComando(string hexCommand)
        {
            try
            {
                // Convertir la cadena hexadecimal a bytes
                byte[] bytes = HexToBytes(hexCommand);

                // Mostrar los bytes en formato ASCII
                string asciiCommand = BytesToAscii(bytes);
                Console.WriteLine("Comando en ASCII:");
                Console.WriteLine(asciiCommand);

                // Enviar los bytes por UDP
                using (UdpClient cliente = new UdpClient())
                {
                    cliente.Client.SendTimeout = 2000; // Timeout de 2 segundos
                    IPEndPoint destino = new IPEndPoint(ipPLC, 30002); // Puerto 30002

                    cliente.Send(bytes, bytes.Length, destino);
                    Log($"✅ Comando enviado a {ipPLC}:30002");
                }
            }
            catch (Exception ex)
            {
                Log($"❌ Error al enviar comando: {ex.Message}");
            }
        }

        // Método para convertir una cadena hexadecimal a bytes
        static byte[] HexToBytes(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            }
            return bytes;
        }

        // Método para convertir bytes a una cadena ASCII
        static string BytesToAscii(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }

        // Método para registrar mensajes en la consola y en un archivo de log
        public static void Log(string mensaje)
        {
            string entrada = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {mensaje}";
            Console.WriteLine(entrada);
            File.AppendAllText("comandos.log", entrada + Environment.NewLine);
        }
    }

    //public class AutoFrames
    //{
    //    public static string GetCierre()
    //    {
    //        // Mensaje: <?xml version="1.0" encoding="utf-8"?><CARR_AUTO_SIMULACION><BarreraPaso>CERRADA</BarreraPaso><SemaforoPaso>ROJO</SemaforoPaso><Source>0</Source><Name>KRNL</Name><TimeStamp>3947837971348</TimeStamp><Target>AUTO</Target></CARR_AUTO_SIMULACION>
    //        return "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f53494d554c4143494f4e3e3c426172726572615061736f3e434552524144413c2f426172726572615061736f3e3c53656d61666f726f5061736f3e524f4a4f3c2f53656d61666f726f5061736f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373937313334383c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f53494d554c4143494f4e3e00";
    //    }

    //    public static string GetValidacion()
    //    {
    //        // Mensaje: <?xml version="1.0" encoding="utf-8"?><CARR_BRCT_VALIDA_TRANSACCION><Mensaje>ACEPTADA</Mensaje><recordatorio>false</recordatorio><Precio>00001000</Precio><Tarifa>1</Tarifa><ModoPago>ESPE</ModoPago><Placa/><Source>0</Source><Name>KRNL</Name><TimeStamp>3947837968840</TimeStamp><Target>AUTO</Target></CARR_BRCT_VALIDA_TRANSACCION>
    //        return "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f425243545f56414c4944415f5452414e53414343494f4e3e3c4d656e73616a653e41434550544144413c2f4d656e73616a653e3c7265636f726461746f72696f3e66616c73653c2f7265636f726461746f72696f3e3c50726563696f3e30303030313030303c2f50726563696f3e3c5461726966613e313c2f5461726966613e3c4d6f646f5061676f3e455350453c2f4d6f646f5061676f3e3c506c6163612f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373936383834303c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f425243545f56414c4944415f5452414e53414343494f4e3e00";
    //    }

    //    public static List<string> GetInit()
    //    {
    //        List<string> list = new List<string>();
    //        list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4445565f51554552593e3c4f7065726163696f6e3e4445565f51554552593c2f4f7065726163696f6e3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373438353632333c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f4445565f51554552593e00");
    //        list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4445565f4f50454e3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373438353632373c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f4445565f4f50454e3e00");
    //        // Agrega más comandos si es necesario...
    //        return list;
    //    }
    //}
}