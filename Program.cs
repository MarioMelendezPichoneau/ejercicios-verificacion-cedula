using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6 crear un programa que pida al usuario su cedula y su contraseña (ambos numero), y no le permita seguir 
            // hasta que introduzca como cedula "00113764530" y como contraseña "1823"


            var cedula = "00113764530";
            var contr = "1823";

            Console.WriteLine(" ingrese su cedula para verificar usuario");
            string  ced = (Console.ReadLine());

            Console.WriteLine(" ingrese la contraseña");
            string con = (Console.ReadLine());

            while (ced != cedula && con != contr)
            {
                Console.WriteLine($" usuario incorrecto \n");
                

                Console.WriteLine(" ingrese su cedula para verificar nuevamente ");
                ced = (Console.ReadLine());

                Console.WriteLine(" ingrese su cedula para verificar");
                con = (Console.ReadLine());

            }

            Console.WriteLine($" cedula y contraseña  correcta puede serguir adelante");

            Console.Read();
        }
    }
}
