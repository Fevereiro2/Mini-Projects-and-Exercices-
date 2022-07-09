using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*vAltere a aplicação anterior de forma a permitir ao utilizador eliminar o 2o nome indicando
            as posições onde este se encontra.
            Exemplo: Filipe Teixeira Silva (seleciona que quer remover a partir do carater 7, 9
            carateres) → Filipe Silva*/
            string nome;
            int aux = 5, alterar1 , alterar2;

            Console.WriteLine("Escreva o seu nome completo");
            nome = Console.ReadLine();



            while (nome != "")
            {
                Console.WriteLine("Escreve a  posição inicial que quer eliminar");
                alterar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreve a  posição final que quer eliminar");
                alterar2 = int.Parse(Console.ReadLine());

                nome = nome.Remove(alterar1, alterar2 -= alterar1);
                Console.WriteLine("Posição [" + alterar1 + "," + alterar2 + "] Elimina: " + nome);

            }
        }
    }
}


