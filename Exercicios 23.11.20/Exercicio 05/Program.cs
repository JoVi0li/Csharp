using System;

namespace Exercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA");
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("");

            for (var i = 0; i <= 10; i++){
                for (var j = 0; j <= 10; j++){
                    Console.WriteLine($"{i} X {j} = {i*j}");
                }
                Console.WriteLine("");
                Console.WriteLine("--------------------");
                Console.WriteLine("");
            
            }

            Console.WriteLine("Fim da tabuada");
            
        }
    }
}
