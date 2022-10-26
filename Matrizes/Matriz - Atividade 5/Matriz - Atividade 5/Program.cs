namespace Matriz___Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] p_ma = new double[2, 3];
            double[,] s_ma = new double[2, 3];

            int i, p;


            Console.WriteLine("==============================================");
            Console.WriteLine(" Digite Valores da 1º Matriz");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 2; i++)
            {
                for (p = 0; p < 3; p++)
                {
                    Console.WriteLine("Digite o valor da Coluna: " + i + " e linha: " + p);
                    p_ma[i, p] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("==============================================");
            Console.WriteLine(" Digite Valores da 2º Matriz");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 2; i++)
            {
                for (p = 0; p < 3; p++)
                {
                    Console.WriteLine("Digite o valor da Coluna: " + i + " e linha: " + p);
                    s_ma[i, p] = double.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz Inicial - 1º Matriz");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("{ " + p_ma[i, 0] + " ," + p_ma[i, 1] + " ," + p_ma[i, 2] + " }");
            }

            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz Inicial - 2º Matriz");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("{ " + s_ma[i, 0] + " ," + s_ma[i, 1] + " ," + s_ma[i, 2] + " }");
            }

            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz Final");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 2; i++)
            {
                s_ma[i, 0] = s_ma[i, 0] + p_ma[i, 0];
                s_ma[i, 1] = s_ma[i, 1] + p_ma[i, 1];
                s_ma[i, 2] = s_ma[i, 2] + p_ma[i, 2];
                Console.WriteLine("{ " + s_ma[i, 0] + " ," + s_ma[i, 1] + " ," + s_ma[i, 2] + " }");
            }
            Console.WriteLine("----------------------------------------------");

        }
    }
}