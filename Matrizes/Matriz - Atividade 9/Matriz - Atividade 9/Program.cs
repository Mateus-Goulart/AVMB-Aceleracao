namespace Matriz___Atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] p_ma = new double[3, 3];
            int i, p, c = 0;
            double numero;

            p_ma[0, 0] = 20; p_ma[0, 1] = 30; p_ma[0, 2] = 40;
            p_ma[1, 0] = 10; p_ma[1, 1] = 50; p_ma[1, 2] = 80;
            p_ma[2, 0] = 0; p_ma[2, 1] = 150; p_ma[2, 2] = 160;

            while (true)
            {
                Console.WriteLine("==============================================");
                Console.WriteLine(" Matriz Inicial - Matriz A");
                Console.WriteLine("----------------------------------------------");
                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine("{ " + p_ma[i, 0] + " ," + p_ma[i, 1] + " ," + p_ma[i, 2] + " }");
                }
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Digite um número para verificar na Matriz:");
                numero = double.Parse(Console.ReadLine());

                for (i = 0; i < 3; i++)
                {
                    for (p = 0; p < 3; p++)
                    {
                        if (numero == p_ma[p, i])
                        {
                            c += 1;
                        }
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("O número existe no vetor");
                    Console.WriteLine("----------------------------------------------");
                }
                else
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Número inexistente");
                    Console.WriteLine("----------------------------------------------");
                }

            }
        }
    }
}