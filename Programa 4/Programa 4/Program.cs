using System;

namespace Programa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            const double PI = 3.1416;
            double B;

            Console.WriteLine("Digite el Area del circulo: ");
            A = double.Parse(Console.ReadLine());

            B = Math.Sqrt(A / PI);
            Console.WriteLine("El radio es de: {0}", B);
        }
    }
}
