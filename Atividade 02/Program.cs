using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir as Variáveis
            int nascimento;
            int anoAtual;
            string nomeCompleto;
            
            //Entrada de Dados e Processamento
            Console.WriteLine("Olá!");
            Console.WriteLine ("Qual é o seu nome?");
            nomeCompleto = Console.ReadLine ();
            Console.WriteLine("Muito prazer em conhecê-lo, "+nomeCompleto+"!");
            Console.WriteLine("Qual é o ano do seu nascimento?");
            nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("OK!");
            Console.WriteLine("Agora, em que ano estamos?");
            anoAtual = int.Parse(Console.ReadLine());
            Console.WriteLine("Obrigado!");
            int idade = (anoAtual - nascimento);
            Console.WriteLine("De acordo com os meus cálculos:");
            Console.WriteLine("Você tem " +idade+" anos");
            int idadeSemanas = (idade * 52);
            Console.WriteLine( "E já viveu "+idadeSemanas+" semanas");

        }
    }
}
