using System;

namespace Exercicios_23._11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.WriteLine("Qual o ano do seu nascimento?");
            int nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora, em que ano nós estamos?");
            int anoAtual = int.Parse(Console.ReadLine());

            //Processamento
            int idade = anoAtual - nascimento;

            //Exibição
            if (idade>=16)
            {
                Console.WriteLine("Você está pode votar!");
            }else{
                Console.WriteLine("Você não pode votar!");
            }
        }
    }
}
