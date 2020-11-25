using System;

namespace Exercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];


            Console.WriteLine("Olá!");
            Console.WriteLine("");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i+1}º nome:");
                nomes[i] = Console.ReadLine();
             }
            Console.WriteLine("");

            Console.WriteLine("Digite o nome que deseja encontrar:");
            string nomeBuscado = Console.ReadLine();

            for (var i = 0; i < nomes.Length; i++)
            {
                if (nomeBuscado.Contains(nomes[i]))
                {
                    Console.WriteLine("Achei!");
                    Console.WriteLine($"O nome buscado é o {i+1}º nome armazenado!");
                    break;
                    
                
                }else{
                    Console.WriteLine("Não achei!");
                }
            }
        }
    }
}
