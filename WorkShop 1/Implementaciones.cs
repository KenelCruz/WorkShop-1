using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop_1
{
    //Clase Padre o Base
    class Implementaciones
    {
        public void MenuPrincipal()
        {

            Console.Clear();


            Console.WriteLine("--------------------Bienvenido a este programa-------------------");
            Console.WriteLine("                                       ");
            Console.WriteLine("Ingrese un numero");
            Console.WriteLine("1- Autor    |   2- For");
            Console.WriteLine("3- Do While |   4-Foreach");
            Console.WriteLine("                                 ");

            //var
           var respuesta = Console.ReadLine();

            switch (respuesta)
            {
                case "1":
                    Primero();
                    break;
                case "2":
                    Segundo();
                    break;
                case "3":
                    Tercero();
                    break;
                case "4":
                    Cuarto();
                    break;

                default:
                    // code block
                    break;
            }
        }


        public void Primero()
        {
            Console.Clear();
            //Const
            const string Nombre = "Kenel_Cruz";
            Console.WriteLine("--------------------Autor-------------------");
            Console.WriteLine("                                       ");
            Console.WriteLine(Nombre);
            Console.WriteLine("                                       ");
            Console.WriteLine("Presione 0 para volver atras");

            //Var
            var res = Console.ReadLine();

            if(res == "0")
            {
                MenuPrincipal();
            }
        }

        public void Segundo()
        {
            Console.Clear();
            Console.WriteLine("--------------------For-------------------");
            Console.WriteLine("                                       ");

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("Presione 0 para volver atras");

            //Var
            var res = Console.ReadLine();

            if (res == "0")
            {
                MenuPrincipal();
            }

        }

        public void Tercero()
        {
            Console.Clear();
            Console.WriteLine("--------------------Do While-------------------");
            Console.WriteLine("                                       ");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);

            Console.WriteLine("Presione 0 para volver atras");

            //Var
            var res = Console.ReadLine();

            if (res == "0")
            {
                MenuPrincipal();
            }
        }

        public void Cuarto()
        {
            Console.Clear();
            Console.WriteLine("--------------------Do While-------------------");
            Console.WriteLine("                                       ");

            string[] Carros = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in Carros)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine("Presione 0 para volver atras");

            //Var
            var res = Console.ReadLine();

            if (res == "0")
            {
                MenuPrincipal();
            }

        }




    }
}
