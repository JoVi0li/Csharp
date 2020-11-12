using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar as variaveis
            float nota1 , nota2, nota3, media;
            string nomeCompleto;

            //Entrada de dados
            Console.WriteLine("Digite o nome do aluno:");
            nomeCompleto = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota:");
            nota2 =  float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3 = float.Parse(Console.ReadLine());

            //Processamento
            media = (nota1+nota2+nota3)/3;

            //Exibir o resultado
            if(media>5){
                Console.WriteLine("O aluno "+nomeCompleto+" está aprovado com a média de: "+media);
            }
            else{
                Console.WriteLine("O aluno "+nomeCompleto+" está reprovado com a média de: "+media);
            }
            
        }
    }
}
