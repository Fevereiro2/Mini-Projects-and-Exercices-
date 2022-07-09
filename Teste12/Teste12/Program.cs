using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double resultado, var1, var2; //declarar variaveis em tipo inteiro

            Console.WriteLine("Insira o comprimento da base do triangulo"); //pedir ao utilizador o 1 valor
            var1 = double.Parse(Console.ReadLine()); //armazenar o primeiro valor em var1
            Console.WriteLine("Insira a altura do triangulo"); //pedir ao utilizador o 2 valor
            var2 = double.Parse(Console.ReadLine()); //armazenar o segundo valor em var2
            resultado = (var2 * var1) / 2;//algoritmo calcular a area entre dois numeros
                                          // resultado /=  2; //algoritmo diferença entre dois numeros
            Console.WriteLine(" Se a base do triangulo é " + var1 + " e a altura é " + var2 + " então a area do triangulo é " + resultado); //apresnetar o resultado 
        }
    }
}
