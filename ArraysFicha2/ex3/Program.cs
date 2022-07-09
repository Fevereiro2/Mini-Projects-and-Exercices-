using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma aplicação que peça ao utilizador o seu nome completo e de seguida o apresente
            //eliminando a letra A sempre que esta aparecer.
            //Exemplo: Carolina Silva → Crolin Silv


            string nome;
            Console.WriteLine("Escreva o seu nome completo");
            nome = Console.ReadLine();
            nome = nome.Replace("a", "");
            Console.WriteLine("O seu nome em maiusculo fica: " + nome);
        }
    }
}

