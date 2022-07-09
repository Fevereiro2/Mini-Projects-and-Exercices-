using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma aplicação que peça ao utilizador o seu nome completo e de seguida o apresente
            //todo em minúsculas.
            string nome;
            Console.WriteLine("EScreva o seu nome completo");
            nome = Console.ReadLine();
            nome = nome.ToLower();
            Console.WriteLine("O seu nome em minusculo fica: " + nome);
        }

    }
}

