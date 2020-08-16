using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;

            Console.WriteLine("ingrese la base: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Ingrese la altura: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("EL area es:");
            C = (A * B);
            D = (C / 2);
            Console.WriteLine("{0}", D);



        }
    }
}
