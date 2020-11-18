using System;

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome de usuário:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua senha:");
            string senha = Console.ReadLine();

            while (senha == nome)
            {   Console.WriteLine("Senha inválida!");
                Console.WriteLine("A senha não pode ser igual ao seu nome de usuário!!!");
                Console.WriteLine("Digite uma senha novamente:");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Senha e usuários corretos!");
            Console.WriteLine("Obrigado!!!");
        }
    }
}
