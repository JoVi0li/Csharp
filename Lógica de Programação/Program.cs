using System;

namespace Lógica_de_Programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm;
            int valorDois;

            //Entrada de dados
            Console.WriteLine("Soma de dois números");
            Console.WriteLine("---------------------");
            Console.WriteLine("Digite o primeiro valor");
            valorUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            valorDois = int.Parse(Console.ReadLine());

            //Procesamento
            int soma = valorUm + valorDois;

            //Exibir
            Console.WriteLine("A soma de "+valorUm+" + "+valorDois+" = "+soma);
        }
        
    }
}
