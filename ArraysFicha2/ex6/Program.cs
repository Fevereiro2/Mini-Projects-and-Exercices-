
using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie uma aplicação que peça ao utilizador o seu nome completo e de seguida elimine todo
            o conteúdo a partir da posição que o utilizador escolher.
            Exemplo: António Santos (seleciona que quer remover a partir do carater 5) → Antón*/

            string nome;
            int aux = 5, alterar;
            
            Console.WriteLine("Escreva o seu nome completo");
            nome = Console.ReadLine();

            

            while (nome != "")
            {
                Console.WriteLine("Escreve a  posição que quer eliminar");
                alterar = int.Parse(Console.ReadLine());
                aux += alterar;
                nome = nome.Remove(aux);
                Console.WriteLine("Posição " + aux + " Elimina: " + nome);

            }

        }
    }
}

