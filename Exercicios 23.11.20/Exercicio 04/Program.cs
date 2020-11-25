using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valor = new int[10];
            int menor = 2147483647, maior = 0;
            for (var i = 0; i <10; i++)
            {
                Console.WriteLine($"Digite o {i+1}° valor:");
                valor[i] = int.Parse(Console.ReadLine());
                if( valor[i] < menor )
                {
                    menor = valor[i];
                }
                else if( valor[i] > maior )
                {
                    maior = valor[i];
                }
            }
                Console.WriteLine($"O maior valor digitado é: {maior}");
                Console.WriteLine($"O menor valor digitado é: {menor}");
        }
    }
}
