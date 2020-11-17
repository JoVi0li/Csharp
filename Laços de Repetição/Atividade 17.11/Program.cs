using System;

namespace Atividade_17._11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite um número inteiro");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine("Ok!");
            Console.WriteLine("Essa é a tabuada");
            Console.WriteLine("------------------");
            int tabuada = 1;
            int resultado;
            

            while(tabuada < 11){
                resultado = valor * tabuada;
                Console.WriteLine (resultado);  
                tabuada = tabuada + 1;
            }
        }
    }
}
