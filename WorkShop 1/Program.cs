using System;

namespace WorkShop_1
{
    //Clase Hija
    class Program : Implementaciones
    {
        public static void Main()
        {
            new Program().MenuPrincipal();
        }
       
    }

    //Clase 
    public class NuevaClass
    {
        //Nuleable
        int? Dias_de_trabajo = default;

        public void Menu()
        {
            Console.WriteLine("Bienvenido al Menu");
        }

    }

    //Interface
    interface INuevaclass
    {
      void Menu();
    }

    //Type parameters
    public class Parametros<T>{
        //Objeto o intencia de la clase
        NuevaClass Nuevaclase = new NuevaClass();
        

        public T Propiedad  { get; set; }
    }


    //Enums
    public enum Dias
    {
        Lunes = 0,
        Martes = 1,
        Miercoles = 2,
        Jueves = 3,
        Viernes = 4,
        Sabado = 5,
        Domingo = 6
    }

   
}
