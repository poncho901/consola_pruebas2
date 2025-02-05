﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Pruebas4.cs
{
   public class AutoFrames
   {
      public static String GetCierre()
      {
         //Mensaje: <?xml version="1.0" encoding="utf-8"?><CARR_AUTO_SIMULACION><BarreraPaso>CERRADA</BarreraPaso><SemaforoPaso>ROJO</SemaforoPaso><Source>0</Source><Name>KRNL</Name><TimeStamp>3947837971348</TimeStamp><Target>AUTO</Target></CARR_AUTO_SIMULACION>
         return "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f53494d554c4143494f4e3e3c426172726572615061736f3e434552524144413c2f426172726572615061736f3e3c53656d61666f726f5061736f3e524f4a4f3c2f53656d61666f726f5061736f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373937313334383c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f53494d554c4143494f4e3e00";
      }

      public static String GetValidacion()
      {
         //Mensaje: <?xml version="1.0" encoding="utf-8"?><CARR_BRCT_VALIDA_TRANSACCION><Mensaje>ACEPTADA</Mensaje><recordatorio>false</recordatorio><Precio>00001000</Precio><Tarifa>1</Tarifa><ModoPago>ESPE</ModoPago><Placa/><Source>0</Source><Name>KRNL</Name><TimeStamp>3947837968840</TimeStamp><Target>AUTO</Target></CARR_BRCT_VALIDA_TRANSACCION>
         return "3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f425243545f56414c4944415f5452414e53414343494f4e3e3c4d656e73616a653e41434550544144413c2f4d656e73616a653e3c7265636f726461746f72696f3e66616c73653c2f7265636f726461746f72696f3e3c50726563696f3e30303030313030303c2f50726563696f3e3c5461726966613e313c2f5461726966613e3c4d6f646f5061676f3e455350453c2f4d6f646f5061676f3e3c506c6163612f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373936383834303c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f425243545f56414c4944415f5452414e53414343494f4e3e00";
      }

      public static List<String> GetInit()
      {
         List<String> list = new List<String>();
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4445565f51554552593e3c4f7065726163696f6e3e4445565f51554552593c2f4f7065726163696f6e3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373438353632333c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f4445565f51554552593e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4445565f4f50454e3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373438353632373c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f4445565f4f50454e3e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438353735323c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31383c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438353738363c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31383c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383131373c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31303c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383135303c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31303c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383431313c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31343c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383434353c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31343c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383638343c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31373c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383732333c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31373c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383935303c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31393c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438383938383c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e31393c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438393239373c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e343c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373438393333303c2f54696d655374616d703e3c4576656e743e34393739323c2f4576656e743e3c57506172616d3e343c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4445565f52554e3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373439303432323c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f4445565f52554e3e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373439313435313c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e313c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f425243545f46554552415f44455f534552564943494f3e3c4261727265726141636365736f3e434552524144413c2f4261727265726141636365736f3e3c426172726572615061736f3e434552524144413c2f426172726572615061736f3e3c53656d61666f726f4372757a3e524f4a4f3c2f53656d61666f726f4372757a3e3c53656d61666f726f5061736f3e524f4a4f3c2f53656d61666f726f5061736f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373439333330353c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f425243545f46554552415f44455f534552564943494f3e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373439333332383c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e32333c2f57506172616d3e3c4c506172616d3e303c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373439333735313c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e3130303c2f57506172616d3e3c4c506172616d3e303c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373439383333303c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e33323c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373530323035323c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e38323c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373531313437303c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e35323c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373531343335353c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e36323c2f57506172616d3e3c4c506172616d3e313c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c4e6f746966793e3c54696d655374616d703e333934373833373531363630383c2f54696d655374616d703e3c4576656e743e34393739333c2f4576656e743e3c57506172616d3e3132303c2f57506172616d3e3c4c506172616d3e303c2f4c506172616d3e3c536f757263653e333c2f536f757263653e3c4e616d653e4155544f3c2f4e616d653e3c5461726765743e4155544f3c2f5461726765743e3c2f4e6f746966793e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f4d4f444f3e3c4d6f646f3e4e6f726d616c3c2f4d6f646f3e3c45737461646f3e4578706c6f746163696f6e3c2f45737461646f3e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373534303832363c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f4d4f444f3e00");
         list.Add("3c3f786d6c2076657273696f6e3d22312e302220656e636f64696e673d227574662d38223f3e3c434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e3c526570657469646f72313e454e43454e4449444f3c2f526570657469646f72313e3c526570657469646f72323e4150414741444f3c2f526570657469646f72323e3c526570657469646f72333e4150414741444f3c2f526570657469646f72333e3c526570657469646f72343e4150414741444f3c2f526570657469646f72343e3c526570657469646f72353e4150414741444f3c2f526570657469646f72353e3c536f757263653e303c2f536f757263653e3c4e616d653e4b524e4c3c2f4e616d653e3c54696d655374616d703e333934373833373535343238383c2f54696d655374616d703e3c5461726765743e4155544f3c2f5461726765743e3c2f434152525f4155544f5f434f4e54524f4c5f4d414e55414c3e00");


         return list;
      }
   }
}
