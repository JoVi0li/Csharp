using System;

namespace Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];


            //Entrada de dados
            Console.Clear();
            Console.WriteLine("Bem vindo à Oli Passagens Aéreas!");
            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");

            Console.WriteLine("Login");
            Console.WriteLine("-------------------");

            Console.WriteLine("Digite seu nome de usúario:");
            string nomeUsuario = Console.ReadLine();
            Console.WriteLine("-------------------");

            bool senhaValida;
            do
            {
                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);


            //Menu
            int escolha;
            int contador = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("[1] - Cadastrar passagem");
                Console.WriteLine("");
                Console.WriteLine("[2] - Listar passagens aéreas cadastradas");
                Console.WriteLine("");
                Console.WriteLine("[0] - Sair do menu");
                escolha = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (escolha)
                {
                    case 1:
                        //Cadastrar passagens
                        string resposta;
                        do
                        {
                            if (contador < 5)
                            {
                            Console.WriteLine($"Digite o nome do {contador+1}º passageiro:");
                            nomes[contador] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Origem do vôo:");
                            origem[contador] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Destino do vôo:");
                            destino[contador] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("Data do vôo:");
                            data[contador] = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine("-------------------");
                            Console.WriteLine("-------------------");
                            Console.WriteLine("");
                            contador++;
                            }else
                            {
                                Console.WriteLine("Limite de passagens cadastradas excedido!");
                                break;
                            }

                            Console.WriteLine("Gostaria de cadastrar um novo passageiro? s/n");
                            resposta = Console.ReadLine();
                        }while(resposta == "s");
                        break;

                        case 2:
                        //Listar passagens cadastradas
                        for (var i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Passageiro: {nomes[i]}");
                        }
                        break;
                        case 0:
                        Console.WriteLine("Obrigado! Volte sempre!");
                        break;
                    default:
                    Console.WriteLine("Opção Inválida!");
                        break;
                }
                
            } while (escolha != 0);

            //Funções
            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    Console.WriteLine("Senha correta!");
                    return true;
                }else{
                    Console.WriteLine("Senha incorreta!");
                    return false;
                }
            }//Fim da função EFETUAR LOGIN

            // void CadastrarPassageiros(){

            // }

        }
    }
}
