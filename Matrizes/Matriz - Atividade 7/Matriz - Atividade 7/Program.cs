namespace Matriz___Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] p_ma = new double[3, 3];
            double[,] s_ma = new double[3, 3];
            double[,] matriz_c = new double[3, 3];

            int i, p;


            Console.WriteLine("==============================================");
            Console.WriteLine(" Digite Valores da Matriz A");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 3; i++)
            {
                for (p = 0; p < 3; p++)
                {
                    Console.WriteLine("Digite o valor da Coluna: " + i + " e linha: " + p);
                    p_ma[i, p] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("==============================================");
            Console.WriteLine(" Digite Valores da Matriz B");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 3; i++)
            {
                for (p = 0; p < 3; p++)
                {
                    Console.WriteLine("Digite o valor da Coluna: " + i + " e linha: " + p);
                    s_ma[i, p] = double.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz Inicial - Matriz A");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("{ " + p_ma[i, 0] + " ," + p_ma[i, 1] + " ," + p_ma[i, 2] + " }");
            }

            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz Inicial - Matriz B");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("{ " + s_ma[i, 0] + " ," + s_ma[i, 1] + " ," + s_ma[i, 2] + " }");
            }

            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz Final - Matriz C");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 3; i++)
            {
                matriz_c[i, 0] = s_ma[i, 0] - p_ma[i, 0];
                matriz_c[i, 1] = s_ma[i, 1] - p_ma[i, 1];
                matriz_c[i, 2] = s_ma[i, 2] - p_ma[i, 2];
                Console.WriteLine("{ " + matriz_c[i, 0] + " ," + matriz_c[i, 1] + " ," + matriz_c[i, 2] + " }");
            }
            Console.WriteLine("----------------------------------------------");

        }
    }
}