namespace Lógica_de_Programação___Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, horas, i;
            decimal valor = 0, valor_total = 0, valor2 = 0, valor_total2 = 0;

            Console.WriteLine("Digite a Quantidade de Professores de 1 a 2");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                if (n > 2)
                {
                    Console.WriteLine("=========================================");
                    Console.Write("O valor é invalido");
                    Console.WriteLine("=========================================");
                    System.Environment.Exit(1);
                }
                else
                {
                    if (i == 1)
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Professor 1");
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Digite o número de horas trabalhadas");
                        horas = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Digite a valor ganho por horas");
                        valor = decimal.Parse(Console.ReadLine());
                        valor_total = horas * valor;
                        valor = decimal.Round(valor, 2);
                        valor_total = decimal.Round(valor_total, 2);
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("O valor do Professor 1 é de R$" + valor_total2 + " e o valor de R$ " + valor2 + "por hora");
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Professor 2");
                        Console.WriteLine("=========================================");
                        Console.WriteLine("Digite o número de horas trabalhadas");
                        horas = int.Parse(Console.ReadLine());
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Digite a valor ganho por horas");
                        valor2 = decimal.Parse(Console.ReadLine());
                        valor_total2 = horas * valor2;
                        valor2 = decimal.Round(valor2, 2);
                        valor_total2 = decimal.Round(valor_total2, 2);
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("O valor do Professor 1 é de R$" + valor_total2 + " e o valor de R$ " + valor2 + "por hora");
                    }
                }
            }
            if (valor_total > valor_total2)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("O valor do Professor 1 é maior com o valor de R$" + valor_total + " e o valor por hora de R$ " + valor);
            }
            else if (valor_total < valor_total2)
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("O valor do Professor 2 é maior com o valor de R$" + valor_total2 + " e o valor por hora de R$ " + valor2);
            }
            else
            {
                Console.WriteLine("=========================================");
                Console.WriteLine("O valor de Sálario dos professores é igual");
            }

        }
    }
}