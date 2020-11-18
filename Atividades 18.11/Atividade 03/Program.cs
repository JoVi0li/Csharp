using System;

namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do seu salário (R$):");
            decimal salario = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Informe o sue estado civil:");
            Console.WriteLine("s = solteiro(a) / c = casado(a) / d = divorciado(a) / v = viúvo");
            string estadoCivil = Console.ReadLine();
            switch(estadoCivil){
                case "s":
                Console.WriteLine("---------------");
                break;
                case "c":
                Console.WriteLine("---------------");
                break;
                case "d":
                Console.WriteLine("---------------");
                break;
                case "v":
                Console.WriteLine("---------------");
                break;
            }
            while(nome == "" || idade <0 || idade >150 || salario <=0){
                Console.WriteLine("Informações incorretas!");
                Console.WriteLine("informe os seus dados corretamente");
                Console.WriteLine("Digite novamente os seus dados");
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Digite sua idade:");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor do seu salário (R$):");
                salario = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Informe o sue estado civil:");
                Console.WriteLine("s = solteiro(a) / c = casado(a) / d = divorciado(a) / v = viúvo");
                estadoCivil = Console.ReadLine();
            }
            Console.WriteLine("Dados válidos!");
            Console.WriteLine("Obrigado!");
        }
    }
}
