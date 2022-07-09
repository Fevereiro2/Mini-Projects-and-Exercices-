using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie uma aplicação que peça ao utilizador o seu nome completo e de seguida o coloque
            num array de strings separando-o pelo carater espaço.
            Exemplo: Manuel António Pinto de Azevedo*/
            string nome;
            int aux = 5, alterar1, alterar2;

            Console.WriteLine("Escreva o seu nome completo");
            nome = Console.ReadLine();
            string[] nomes = nome.Split(' ');

            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write((i + 1) + "º Nome - " + nomes[i] );
            }
        }
    }
}


