using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // num3 a1 a2 a3
            int patente, a1, a2, a3, num1, num2, num3;
            char b1, b2, b3;
            Console.WriteLine("Ingrese numero a procesar");
            patente = int.Parse(Console.ReadLine());

            a3 = patente % 10;
            a2 = (patente / 10) % 10;
            a1 = (patente / 100) % 10;

            num3 = (patente / 1000) % 26;
            Console.WriteLine(num3);
            b3 = Convert.ToChar('A' + num3); //A,4  $\"A,{num3}\";
            num2 = ((patente / 1000) / 26) % 26;
            b2 = Convert.ToChar('A' + num2);
            num1 = (((patente / 1000) / 26) / 26) % 26;
            b1 = Convert.ToChar('A' + num1);


            Console.WriteLine($"Patente: {b1}{b2}{b3}{a1}{a2}{a3}");

        }
    }
}
