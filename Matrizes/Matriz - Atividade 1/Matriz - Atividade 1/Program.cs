namespace Matriz___Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 3];
            int i;

            Console.WriteLine("=============================================");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + " º número da Coluna 0");
                Console.WriteLine("---------------------------------------------");
                numeros[i, 0] = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");
            }

            for (i = 0; i < 5; i++)
            {
                numeros[i, 1] = numeros[i, 0] + 10;
            }

            for (i = 0; i < 5; i++)
            {
                numeros[i, 2] = numeros[i, 0] * 2;
            }

            Console.WriteLine("=============================================");
            Console.WriteLine("Matriz Final");
            Console.WriteLine("---------------------------------------------");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{ " + numeros[i, 0] + " ," + numeros[i, 1] + " ," + numeros[i, 2] + " }");
            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}