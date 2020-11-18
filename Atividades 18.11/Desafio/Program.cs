using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAnt = 0;
            int numPos = 1;
            int sequencia;

            Console.WriteLine("Deseja iniciar a sequência?");
            string resposta = Console.ReadLine();
            if( resposta == "sim"){
                for (var i = 0; i <= 13; i++)
                {
                    sequencia = numAnt + numPos; 
                    Console.WriteLine  (sequencia);
                    numAnt = numPos; 
                    numPos = sequencia;   
                }
            }else{
                Console.WriteLine("Ok, o programa será encerrado!");
            }
        }
    }
}
