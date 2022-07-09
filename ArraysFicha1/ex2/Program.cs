using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que guarde num vetor os nomes de pelo menos 10 alunos da turma.
            //Deve permitir ao utilizador ao inserir o número do aluno(índice do vetor) indicar qual o
            //nome do mesmo. Caso o utilizador insira o número 99 deverá apresentar os nomes todos.

            string[] nomes = new string[]

            {
            "",
            "Pedro",
            "João",
            "Fabio",
            "Simão",
            "Mariana",
            "Guilherme",
            "Rita",
            "Gabriel",
            "Rafael",
            "Vasco"
            };
            int a1;
            Console.WriteLine("Qual o numero do aluno?");
            a1 = int.Parse(Console.ReadLine());
            if (a1 == 99)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(nomes[i] + " - " + i + "\n");
                }

            }
            else
            {
                Console.WriteLine("\n" + nomes[a1] + " - " + a1);
            }
        }
    }
}