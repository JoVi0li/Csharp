using System;

namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota entre 0 e 10:");
            float nota = float.Parse(Console.ReadLine());

            if (nota >10 || nota <0){
                Console.WriteLine("Nota Inválida!");
                Console.WriteLine("Digite a nota novamente:");
                nota = float.Parse(Console.ReadLine());

            }
                Console.WriteLine("Nota válida, obrigado!");
        }
    }
}
