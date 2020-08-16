using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A;
            const double PI = 3.1416;

            Console.WriteLine("Ingresa el radio");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            A = PI * (R*R);

            Console.WriteLine("El area del Circulo es: {0}", A);
        }
    }
}
