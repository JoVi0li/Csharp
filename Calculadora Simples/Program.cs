using System;

namespace Calculadora_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qual é a operação que deseja fazer \nSoma, Subtração, Divisão ou Multiplicação");
            string operação = Console.ReadLine();
            Console.WriteLine("Digite o 1° número");
            float num1 = float.Parse (Console.ReadLine());
            Console.WriteLine("Digite o 2° número");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = 0;
            switch(operação){
                case "Soma":
                resultado = num1 + num2;
                break;
                case "Subtracao":
                resultado = num1 - num2;
                break;
                case "Multiplacacao":
                resultado = num1 * num2;
                break;
                case "Divisao":
                resultado = num1 / num2; break;
                default:
                Console.WriteLine("Operação Inválida");
                break;

            }
                Console.WriteLine($"Calculo:{num1} e {num2} = Resultado : {resultado} ");

        }
    }
}
