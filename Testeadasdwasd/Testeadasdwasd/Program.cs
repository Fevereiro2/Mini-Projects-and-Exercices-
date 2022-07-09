using System;

namespace Testeadasdwasd // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;/*
            while (f != 1)
            { 
                if (f == 0)
                {
                    f++;
                    Console.WriteLine("Teste"+i);
                }
                else if (f == 1)
                {
                    f++;
                    Console.WriteLine("Teste22" + i);
                }
            }*/

            f = 0;

            f++;
            for (int i = 0; i < f; i++)
            {

                if (f == 0)
                {
                    f++;
                    Console.WriteLine("Teste" + i);
                }
                else if (f == 1)
                {
                    f++;
                    Console.WriteLine("Teste22" + i);
                }
            }
        }
    }
}