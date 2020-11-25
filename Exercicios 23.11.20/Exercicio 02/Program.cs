using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione um tipo de combustível:");
            Console.WriteLine("A - Àlcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de combustível:");
            float quantidadeDeCombustivel = float.Parse(Console.ReadLine());

            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;
            float percAlcool1 = 0.05f;
            float percAlcool2 = 0.03f;
            float percGasolina1 = 0.06f;
            float percGasolina2 = 0.04f;


            switch (combustivel.ToUpper())
            {
                case "A":
                    ExibirValorPago(AplicarDesconto(quantidadeDeCombustivel, precoAlcool, percAlcool1, percAlcool2));
                    break;
                case "G":
                    ExibirValorPago(AplicarDesconto(quantidadeDeCombustivel, precoGasolina, percGasolina1, percGasolina2));

                    break;
                default:
                Console.WriteLine("Opção Inválida!");
                    break;
            }
            float AplicarDesconto(float litros, float preco, float perc1, float perc2){
                if(litros>20){
                    float valorTotal = litros * preco;
                    float desconto = (litros * preco) * perc1;
                    return valorTotal - desconto;
                }else{
                    float valorTotal = litros * preco;
                    float desconto = (litros * preco) * perc2;
                    return valorTotal - desconto;
                }
            }
            void ExibirValorPago(float valor){
                Console.WriteLine($"O valor total a ser pago é de: R$ {valor}");
            }
        }
    }
}
