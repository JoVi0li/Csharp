using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade:");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto:");
            float preco = float.Parse(Console.ReadLine());

            float resultado = TotalAPagar(quantidade,  preco);

            float TotalAPagar(int quantidade, float preco){
                
                float total = quantidade * preco;
                float desconto;

                if (quantidade<=5){
                    desconto = 0.02f;
                }else if(quantidade <=10){
                    desconto = 0.03f;
                }else{
                    desconto = 0.05f;
                }//Fim do if
                
                float valorDoDesconto = total * desconto;
                float totalComDesconto = total - valorDoDesconto;

                Console.WriteLine($"O valor total é de: R${total}");
                Console.WriteLine($"O valor do desconto é de: R${valorDoDesconto}");
                Console.WriteLine($"O valor final com desconto é de: R${totalComDesconto}");

                return totalComDesconto;
                
            }//Fim TotalAPagar
        }//Fim do main
    }
}
