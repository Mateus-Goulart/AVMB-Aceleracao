namespace Lógica_de_Programação___Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor_compra = 0, percentual, total_lucro, valor_lucro;
            String opcao;

            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Digite o valor de compra");
                Console.WriteLine("----------------------------------------");
                opcao = Console.ReadLine();
                valor_compra = float.Parse(opcao);

                if (valor_compra < 10.00)
                {
                    percentual = 70.0 / 100.0;
                    Console.WriteLine(percentual);
                    valor_lucro = valor_compra * percentual;
                    total_lucro = valor_compra + (valor_compra * percentual);
                    Console.WriteLine("========================================");
                    Console.WriteLine("Nota Fiscal");
                    Console.WriteLine("========================================");
                    Console.WriteLine("Valor de Compra: R$" + valor_compra);
                    Console.WriteLine("Valor Total: R$" + total_lucro);
                    Console.WriteLine("Porcentagem: 70%");
                    Console.WriteLine("Valor de Lucro: R$" + valor_lucro);
                    Console.WriteLine("========================================");

                }
                else if (10.00 <= valor_compra && valor_compra < 30.00)
                {
                    percentual = 50.0 / 100.0;
                    valor_lucro = valor_compra * percentual;
                    total_lucro = valor_compra + (valor_compra * percentual);
                    Console.WriteLine("========================================");
                    Console.WriteLine("Nota Fiscal");
                    Console.WriteLine("========================================");
                    Console.WriteLine("Valor de Compra: R$" + valor_compra);
                    Console.WriteLine("Valor Total: R$" + total_lucro);
                    Console.WriteLine("Porcentagem: 50%");
                    Console.WriteLine("Valor de Lucro: R$" + valor_lucro);
                    Console.WriteLine("========================================");
                }
                else if (30.00 <= valor_compra && valor_compra < 50.00)
                {
                    percentual = 40.0 / 100.0;
                    valor_lucro = valor_compra * percentual;
                    total_lucro = valor_compra + (valor_compra * percentual);
                    Console.WriteLine("========================================");
                    Console.WriteLine("Nota Fiscal");
                    Console.WriteLine("========================================");
                    Console.WriteLine("Valor de Compra: R$" + valor_compra);
                    Console.WriteLine("Valor Total: R$" + total_lucro);
                    Console.WriteLine("Porcentagem: 40%");
                    Console.WriteLine("Valor de Lucro: R$" + valor_lucro);
                    Console.WriteLine("========================================");
                }
                else if (50.00 <= valor_compra)
                {
                    percentual = 30.0 / 100.0;
                    valor_lucro = valor_compra * percentual;
                    total_lucro = valor_compra + (valor_compra * percentual);
                    Console.WriteLine("========================================");
                    Console.WriteLine("Nota Fiscal");
                    Console.WriteLine("========================================");
                    Console.WriteLine("Valor de Compra: R$" + valor_compra);
                    Console.WriteLine("Valor Total: R$" + total_lucro);
                    Console.WriteLine("Porcentagem: 30%");
                    Console.WriteLine("Valor de Lucro: R$" + valor_lucro);
                    Console.WriteLine("========================================");
                }
                else
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("Nota Fiscal");
                    Console.WriteLine("========================================");
                    Console.WriteLine("Desculpe, valor inválido, tente novamente");
                    Console.WriteLine("========================================");
                    continue;
                }
            }
    }
}