using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que utilize uma estrutura de repetição para ler 50 números armazenando-os 
            //em um vetor e calcule e exiba a média aritmética deles. Em seguida o programa deve
            //apresentar todos os valores armazenados no vetor que sejam menores que a média.

            Random rnd = new Random();
            int[] nrs = new int[50];
            double aux = 0;
            for (int i = 0; i < 50; i++)
            {
                int n1 = rnd.Next(1, 50);
                nrs[i] = n1;
                aux = aux + nrs[i];
            }
            double aux2;
            aux2 = aux / 50;
            Console.WriteLine("Média: " + aux2 + "\n\n");
            Console.WriteLine("Números menores que a media:\n");
            for (int i2 = 0; i2 < 50; i2++)
            {
                if (nrs[i2] < aux2)
                {
                    Console.Write(nrs[i2] + " | ");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
