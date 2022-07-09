using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que ordene de forma crescente e decrescente um vetor. Sugere-se
             pesquisa na internet pelo tópico: “c# bubble sort”.*/
            Random rnd = new Random();
            int[] vetor = new int[20];
            Console.WriteLine("Ordem normal:");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = rnd.Next(1, 101);
                Console.WriteLine(vetor[1] + " | ");
            }
            Console.WriteLine("\nOrdem crescente");
            Array.Sort(vetor);
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " | ");
            }
            Console.WriteLine("Ordem decrescente");
            for (int i = 0; i < vetor.Length; i--)
            { 
                Console.WriteLine(vetor[i] + " | ");
            }
        }
    }
}