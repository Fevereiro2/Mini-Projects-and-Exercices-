using System;

namespace ArraysFicha3
{
    class Program
    {
        static int[] vetor = new int[5];
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 5)
            {
                Console.WriteLine("Insira o " + (a+1) + "º numero:");
                vetor[a] = int.Parse(Console.ReadLine());
                a++;
            }
            Console.Clear();
            a = 0; Console.Write("Números: ");
            while (a < 5)
            {
                Console.Write(vetor[a] +" | ");
                a++;
            }
            Console.WriteLine();
            Menu();
        }

        private static void Menu()
        {
            Console.Clear();
            int escolha;
            Console.WriteLine("\nO que pretendes fazer?\n1 - ordem crescente\n2 - ordem decrescente\n3 - imprimir os numeros\n4 - Adicionar elementos ao array na última posição\n5 - Adicionar elementos ao array numa posição à escolha arrastando todos os elementos para a frente\n6 - Alterar o valor de uma posição do array\n7 - Eliminar um elemento no vetor suprimindo a posição que ficaria vazia");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    crescente();
                        break;
                case 2:
                    decrescente();
                    break;
                case 3:
                    Imprimircontent();
                    break;
                case 4:
                    addelements();
                    break;
                case 5:
                    addelementsramdomposition();
                    break;
                case 6:
                    refresharray();
                    break;
                case 7:
                    deletearray();
                    break;
            }
        }

        private static void questao()
        {
            int resposta; Console.WriteLine("Pretende voltar ao menu principal?\n1 - Sim\n2 - Não");
            resposta = int.Parse(Console.ReadLine());
            if (resposta == 1)
            {
                Menu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Obrigado por usar o programa!\n\n");
            }
        }

        private static void crescente()
        {
            Console.Clear();
            Console.WriteLine("Ordem Crescente: ");
            Console.Write("\n/ ");
            Array.Sort(vetor);
            for (int i = 0; i < vetor.Length; i++) //ordem crescente array i++
            {
                Console.Write(vetor[i] + " / ");
            }
            Console.WriteLine("\n\n");
            questao();
        }
        

        private static void decrescente()
        {
            Console.Clear();
            Console.WriteLine("Ordem Decrescente: ");
            Console.Write("\n/ ");
            Array.Reverse(vetor);
            for (int i = 0; i < vetor.Length; i++) //ordem decrescente array i--
            {
                Console.Write(vetor[i] + " / ");
            }
            Console.WriteLine("\n\n");
            questao();

        }
        private static void Imprimircontent()
        {
            Console.Clear();
            Console.WriteLine("Números: ");
            Console.Write("\n/ ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " / ");
            }
            Console.WriteLine("\n\n");
            questao();

        }
        private static void addelements()
        {
            Console.Clear();
            Array.Resize(ref vetor, vetor.Length );
            Console.WriteLine("Numero a adicionar ao array na última posição:");
            vetor[5] = int.Parse(Console.ReadLine());
            Console.WriteLine("\nFoi adicionado ao vetor o numero: " + vetor[5]);
            Console.WriteLine("Números: ");
            Console.Write("\n/ ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " / ");
            }
            Console.WriteLine();
            questao();
        }
        private static void addelementsramdomposition()
        {
            Console.Clear();
            Console.WriteLine("Posição que pretende adicionar e arrastar as outras para a frente:");
            int posicao = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero que pretende adicionar:");
            int numero = int.Parse(Console.ReadLine());
            int[] temp = new int[vetor.Length + 1]; //criar uma posição a mais no vetor 

            for (int i = 0; i < posicao; i++)
            {
                temp[i] = vetor[i];
            }
            temp[posicao] = numero;
            for (int i = posicao; i < vetor.Length; i++)
            {
                temp[i + 1] = vetor[i];
            }

            vetor = temp;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " / ");
            }
            questao();

        }
        private static void refresharray()
        {
            int aux2, aux3;
            Console.Clear();
            Console.WriteLine("Escolhe a posição");
            aux2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o numero que pretende adicionar");
            aux3 = int.Parse(Console.ReadLine());

            vetor[aux2 - 1] = aux3;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(vetor[i] + " / ");
            }
            Console.WriteLine();
            questao();
        }
        private static void deletearray()
        {
            Console.Clear();
            Console.WriteLine("Posição que pretende adicionar e arrastar as outras para a frente:");
            int posicao = int.Parse(Console.ReadLine());

            int[] temp = new int[vetor.Length - 1]; //criar uma posição a mais no vetor 

            for (int i = 0; i < posicao; i++)
            {
                temp[i] = vetor[i];
            }
            for (int i = posicao; i < vetor.Length; i++)
            {
                temp[i - 1] = vetor[i];
            }

            vetor = temp;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i] + " / ");
            }
            questao();

        }
    }
}
