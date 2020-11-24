using System;

namespace Atividade_do_dia_20._11
{
     class Program
    {
        static float CalcularMedia(float[] numeros){

            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            
            float calculo = soma / numeros.Length;

            return calculo;
        }

        static void Main(string[] args)
        {
            string[] nomes       = new string[3];
            float [] mediaAluno  = new float[3];
            float [] notas       = new float[4];
            int aprovado = 0;
            int reprovado = 0;

            for(int i = 0; i < 10; i++){

                Console.WriteLine("Digite o nome: ");
                nomes[i] = Console.ReadLine();

                for (var x = 0; x < 4; x++)
                {
                    Console.WriteLine($"Digite a {x+1}° nota: ");
                    notas[x] = float.Parse(Console.ReadLine());

                    
                }
                mediaAluno[i] = CalcularMedia(notas);
                if (mediaAluno[i] >= 7){
                    aprovado = aprovado + 1;
                }else{
                    reprovado = reprovado + 1;
                }
            }

            Console.WriteLine("Ok, selecione uma das opções abaixo:");
            Console.WriteLine("1- A média dos alunos  2- A média geral da sala  3- A quantidade de aprovados e reprovados");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                for (var i = 0; i < nomes.Length ; i++)
                {
                Console.WriteLine($"Nome: {nomes[i]} - Média: {mediaAluno[i]} ");
                }  
                    break;
                    case 2:
                    float mediaGeral = ( mediaAluno[0] + mediaAluno[1] +mediaAluno[2] + mediaAluno[3] + mediaAluno[4] +mediaAluno[5] + mediaAluno[6] +mediaAluno[7] + mediaAluno[8] +mediaAluno[9])/10;
                    Console.WriteLine($"A média geral dos alunos é: {mediaGeral} ");
                    break;
                    case 3:
                    Console.WriteLine($"A quantidade de aprovados é: {aprovado}");
                    Console.WriteLine($"A quantidade de reprovados é: {reprovado}");
                    break;
                default:
                    break;
            }
            
        }
    }
}
