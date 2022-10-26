namespace Vetores___Atividade___2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, op, resultado;
            int[] numero = new int[20] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200 };
            int[] numero2 = new int[20] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };


            while (true)
            {
                Console.WriteLine("===========================================================================================");
                Console.WriteLine("Escolha uma Opção: ");
                Console.WriteLine("1 - Escolha os números | 2- Números Pré-Definidos ");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                if (op == 1)
                {
                    for (i = 0; i < 20; i++)
                    {
                        Console.WriteLine("Digite o valor do índice: " + i + " da primeira lista de números");
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        numero[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("===========================================================================================");
                    }
                    for (i = 0; i < 20; i++)
                    {
                        Console.WriteLine("Digite o valor do índice: " + i + " da segunda lista de números");
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        numero[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("===========================================================================================");
                    }
                }
                else if (op == 2)
                {
                    for (i = 0; i < 20; i++)
                    {
                        Console.WriteLine("Valores a serem somados do indices: " + i + " com os valores: " + numero[i] + " , " + numero2[i]);
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        resultado = numero[i] + numero2[i];
                        Console.WriteLine(numero[i] + " + " + numero2[i] + " = " + resultado);
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Opção Ínvalida");
                }

                for (i = 0; i < 20; i++)
                {
                    Console.WriteLine("Valores a serem somados do indices: " + i + " com os valores: " + numero[i] + " , " + numero2[i]);
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    resultado = numero[i] + numero2[i];
                    Console.WriteLine(numero[i] + " + " + numero2[i] + " = " + resultado);
                    Console.WriteLine("----------------------------------------------------------------------------------------");

                }
                break;
            }
        }
    }
}