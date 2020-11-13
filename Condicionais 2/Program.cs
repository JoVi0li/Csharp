using System;

namespace Condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.WriteLine("você gostaria de participar do time de CS GO? - Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com a Sara");
                }else{
                    Console.WriteLine("Blz, passar bem!");
                }
            }else{
                Console.WriteLine("Você gostaria de participar do time de lol? - Sim ou Não");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Compareça a secretaria - Falar com o Jucelino");
                }else{
                    Console.WriteLine("Vlw, brigadãoo!");
                }
            }
        }
    }
}
