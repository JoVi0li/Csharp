using System;

namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            string nomeCompleto;
            double salario;
            double reajuste;
            double salarioTotal;
            

            //Entrada de Dados
            Console.WriteLine("Olá, como vai?");
            Console.WriteLine("Qual é o seu nome completo?");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Muito prazer em conhecê-lo "+nomeCompleto+"!");
            Console.WriteLine("Por favor, qual é o valor do seu salário?");
            salario = double.Parse(Console.ReadLine());

            //Processamento
            reajuste = (salario * 0.30);
            salarioTotal = (reajuste + salario);

            //Exibir resultado
            if(salario < 500){
                Console.WriteLine("Caramba, tudo isso? Que beleza, hein!");
                Console.WriteLine("Para a sua felicidade, o seu aumento salarial será de: "+reajuste+" reais");
                Console.WriteLine("Com isso, o valor do seu salário passa a ser de: " +salarioTotal+" reais, parabéns!");
            }else{
                Console.WriteLine("Poxa, infelizmente você não tem aumento salarial para receber, talvez na próxima!");
            }

        }
    }
}
