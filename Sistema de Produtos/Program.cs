using System;

namespace Sistema_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            string[] produtos = new string[10];
            float[] preco = new float[10];
            string cadastrarMaisUm;
            string promocao;

            do{ 
            Console.WriteLine("");
            Console.WriteLine("Sistema de produtos!");
            Console.WriteLine("");
            Console.WriteLine("Selecione uma das opções abixo:");
            Console.WriteLine("[1] - Cadastrar produto  [2] - Listar produtos  [0] - Sair");
            resposta = int.Parse(Console.ReadLine());


            int contador = 0;
            switch (resposta)
            {
                case 1:
                bool estaEmPromo;
                do
                {
                    if (contador < 10)
                    {
                    Console.WriteLine($"Digite o nome do {contador+1}º produto:");
                    produtos[contador] = Console.ReadLine();
                    Console.WriteLine("");
                    Console.WriteLine($"Digite o preço do {contador+1}º produto:");
                    preco[contador] = float.Parse(Console.ReadLine());
                    Console.WriteLine($"O produto está em promoção? S/N");
                    promocao = Console.ReadLine();
                    estaEmPromo = Promo(promocao);
                    contador++;
                    }else
                    {
                        Console.WriteLine("Limite máximo de produtos cadastrados excedido!");
                    }
                    Console.WriteLine("Deseja cadastrar mais um produto? S/N");
                    cadastrarMaisUm = Console.ReadLine();
                } while (cadastrarMaisUm == "s");
                    break;
                    case 2:
                    for (var i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Produto nº {i+1} cadastrado: {produtos[i]}");
                        Console.WriteLine($"Valor do produto: {preco[i]}");
                    }
                    break;
                    case 0:
                    Console.WriteLine("Obrigado! Volte sempre!");
                    break;
                default:
                Console.WriteLine("Opção inválida!");
                    break;
                }

                bool Promo(string promocao){
                    if(promocao == "s"){
                        return true;
                    }else{
                        return false; 
                    }
                }
            }while(true && resposta != 0);
        }
    }
}
