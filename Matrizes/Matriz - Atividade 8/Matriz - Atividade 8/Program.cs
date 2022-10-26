namespace Matriz___Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] p_ma = new int[4, 4];
            int i, p;


            for (i = 0; i < 4; i++)
            {
                for (p = 0; p < 4; p++)
                {
                    Console.WriteLine("Digite o valor presente na coordenada: Coluna - " + i + " | Linha - " + p);
                    p_ma[i, p] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("{ " + p_ma[i, 0] + " ," + p_ma[i, 1] + " ," + p_ma[i, 2] + " ," + p_ma[i, 3] + " }");
            }

            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz - Invertida");
            Console.WriteLine("----------------------------------------------");
            for (i = 3; i >= 0; i--)
            {
                Console.WriteLine("{ " + p_ma[i, 3] + " ," + p_ma[i, 2] + " ," + p_ma[i, 1] + " ," + p_ma[i, 0] + " }");
            }

        }
    }
}