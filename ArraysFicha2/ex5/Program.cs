using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Altere a aplicação anterior de forma a permitir ao utilizador retirar letras em ciclo até não
            existir mais nenhuma letra para mostrar.
            Exemplo: Ana Maria (utilizador seleciona A) → n Mri (utilizador seleciona N) → Mri
            (utilizador seleciona R) → Mi (utilizador seleciona M) → i (utilizador seleciona i) →
            programa termina.
            Nota: quando o utilizador selecionar uma letra que não existe no nome ou que já tenha
            sido retirada, o programa deve continuar a executar de forma normal.*/

            string nome, alterar;
            Console.WriteLine("Escreva o seu nome completo");
            nome = Console.ReadLine();



            while (nome != "")
            {
                Console.WriteLine("Escreve a  letra que quer eliminar");
                alterar = Console.ReadLine();
                nome = nome.Replace(alterar, "");
                Console.WriteLine("O seu nome em com a letra retirada " + alterar + " fica: " + nome);
            }

        }
    }
}

