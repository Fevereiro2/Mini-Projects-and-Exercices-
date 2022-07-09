using System;

namespace ex3
{
    class Program
    {
        private static int opcao;
        static void Main(string[] args)
        {
            //Faça um programa que receba 10 valores inteiros e os coloque em um vetor. Em seguida
            //exiba - os em ordem inversa à ordem de entrada.

            int[] numeros = new int[11];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Escolha um valor");
                numeros[i] = int.Parse(Console.ReadLine());

            }
            Console.Clear();
            for (int i = 10; i < numeros.Length; i--)
            {
                if (i > 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }




        }
    }
}
