using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            string nome;
            int idade;

            //Entrada de Dados
            Console.WriteLine("Olá!");
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Prazer em conhecê-lo "+nome+"!");
            Console.WriteLine("Por favor, me conte qual é a sua idade?");
            idade = int.Parse(Console.ReadLine());

            //Processamento e Resultados
            if( idade <5){
                Console.WriteLine (nome+", você não tem idade suficiente para estar em alguma categoria");
            }
            if (idade >=5 && idade <=7){
                Console.WriteLine( nome+", você está na categoria Infantil A ");
            }
            if (idade >= 8 && idade <=10){
                Console.WriteLine(nome+", você está na categoria Infantil B ");
            }
            if (idade >= 11 && idade <= 13){
                Console.WriteLine(nome+", você está na categoria Juvenil A ");
            }
            if (idade >= 14 && idade <= 17){
                Console.WriteLine(nome+", você está na categoria Juvenil B ");
            }
            if ( idade >18){
                Console.WriteLine(nome+", você está na categoria Sênior ");
            }

        }
    }
}
