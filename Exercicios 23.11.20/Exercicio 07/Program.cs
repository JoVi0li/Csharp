using System;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            Console.WriteLine("Olá");
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o {i+1}º numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            //Inverte a sequência dos valores armazenados
            Array.Reverse(numeros);

            Console.WriteLine("");
            Console.WriteLine("Esses são os números digitados na ordem inversa:");
            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine("-------------");
                Console.WriteLine(numeros[i]);
                Console.WriteLine("-------------");

            }
        }
    }
}
