using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Altere a aplicação anterior pedindo ao utilizador, para além do seu nome, a letra que
            //pretende retirar.

            string nome, alterar;
            Console.WriteLine("Escreva o seu nome completo");
            nome = Console.ReadLine();

            Console.WriteLine("Escreve a  letra que quer eliminar");
            alterar = Console.ReadLine();
            nome = nome.Replace(alterar, "");
            Console.WriteLine("O seu nome em maiusculo fica: " + nome);
        }
    }
}

