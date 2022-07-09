using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Complemente o programa anterior escrevendo cada nome numa linha percorrendo os
            vários elementos do array de forma crescente.*/
            string nome;
            

            Console.WriteLine("Escreva o seu nome completo");
            nome = Console.ReadLine();
            string[] nomes = nome.Split(' ');

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write((i + 1) + "º Nome - " + nomes[i]);
            }

            int resposta;
            Console.WriteLine("\n\n\nPretende que o nome seja escrito de forma? 1 - Crescente 0 - Sair");
            resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
            {
                Console.Write("\n|| ");
                Array.Sort(nomes);
                for (int i = 0; i < nomes.Length; i++)
                {
                    Console.Write((i + 1) + "º Nome - " + nomes[i] + " || ");
                }
                Console.WriteLine("\n\n");
            }
            else
            {
                Console.Clear();
                
            }
        }
    }
}