namespace Vetores___Atividade___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] numero = new int[10];

            Console.WriteLine("=====================================");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor do índice: " + i);
                Console.WriteLine("-------------------------------------");
                numero[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("=====================================");
            }
            for (i = 0; i < 10; i++)
            {
                if (numero[i] % 2 == 0)
                {
                    Console.WriteLine("O valor do índice: " + i + ", com o valor: " + numero[i] + " É um número Par");
                    Console.WriteLine("-------------------------------------");
                }
                else
                {
                    Console.WriteLine("O valor do índice: " + i + ", com o valor: " + numero[i] + " É um número Ímpar");
                    Console.WriteLine("-------------------------------------");
                }

            }
        }
    }
}