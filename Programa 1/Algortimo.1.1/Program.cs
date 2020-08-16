using System;

namespace Algoritmo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            Console.Write("Vamos hayar la superficie de un triangulo, la formula es sencilla, vamos a coger la mitad de la altura del triangulo y multiplicarla por la base");
            Console.WriteLine("");
            Console.Write("Pero no voy a darte tanto trabajo, para esto te pido que la base sea menor que la altura ya que asi se desarrollara de manera correcta, gracias.");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.Write("ingrese la base: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("ingrese la ingrese la altura: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("");
            C = (B/2);
            Console.Write("la mitad de la altura para hayar la superficie es de: {0}", C);
            Console.WriteLine("");
            D = (A * C);
            Console.Write("la superficie del triangulo es: {0}", D);
            Console.WriteLine("");
        }
    }
}