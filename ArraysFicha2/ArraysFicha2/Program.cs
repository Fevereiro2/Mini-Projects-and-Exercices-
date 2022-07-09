using System;

namespace ArraysFicha2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma aplicação que peça ao utilizador o seu nome completo e de seguida o apresente
            //todo em maiúsculas.
            string nome ;
            Console.WriteLine("EScreva o seu nome completo");
            nome = Console.ReadLine();
            nome = nome.ToUpper();
            Console.WriteLine("O seu nome em maiusculo fica: "+nome);

        }
    }
}

