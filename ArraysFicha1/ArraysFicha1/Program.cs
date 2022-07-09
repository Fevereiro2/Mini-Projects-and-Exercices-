
using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

                int[] notas = new int[4]; double media;


            Console.WriteLine("1ª nota:");
            notas[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("2ª nota:");
            notas[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("3ª nota:");
            notas[2] = int.Parse(Console.ReadLine());
            media = (notas[0] + notas[1] + notas[2])/3;
            Console.WriteLine("\n\nMédia: " + media);

        }
    }
}