using System;

namespace Atividade_13._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            
            int Meses = (idade * 12);
            int dias = (idade * 365);
            int horas = (dias * 24);
            int minutos = (horas * 60);

            System.Console.WriteLine("A sua idade em meses é "+Meses);
            System.Console.WriteLine("A sua idade em dias é "+dias);
            System.Console.WriteLine("A sua idade em horas é "+horas);
            System.Console.WriteLine("A sua idade em minutos é "+minutos);

        
           
        }
    }
}
