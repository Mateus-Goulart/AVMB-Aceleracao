namespace Matriz___Atividade_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] p_ma = new int[4, 4];
            int[,] s_ma = new int[4, 4];
            int i, p, media1 = 0, media2 = 0, ab_media = 0, ac_media = 0;


            for (i = 0; i < 4; i++)
            {
                for (p = 0; p < 4; p++)
                {
                    Console.WriteLine("Digite o valor presente na coordenada: Coluna - " + i + " | Linha - " + p);
                    p_ma[i, p] = int.Parse(Console.ReadLine());
                    media1 += p_ma[i, p];
                }
            }

            for (i = 0; i < 4; i++)
            {
                for (p = 0; p < 4; p++)
                {
                    Console.WriteLine("Digite o valor presente na coordenada: Coluna - " + i + " | Linha - " + p);
                    s_ma[i, p] = int.Parse(Console.ReadLine());
                    media1 += s_ma[i, p];
                }
            }

            media1 = media1 / 16;
            media2 = media2 / 16;

            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz A");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("{ " + p_ma[i, 0] + " ," + p_ma[i, 1] + " ," + p_ma[i, 2] + " ," + p_ma[i, 3] + " }");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" Matriz - Média = " + media1);
            Console.WriteLine("----------------------------------------------");

            for (i = 0; i < 4; i++)
            {
                for (p = 0; p < 4; p++)
                {
                    if (p_ma[i, p] > media1)
                    {
                        ac_media = ac_media + 1;
                    }
                    else if (p_ma[i, p] < media2)
                    {
                        ab_media = ab_media + 1;
                    }
                }
            }
            Console.WriteLine(" Matriz - Acima da Média = " + ac_media);
            Console.WriteLine(" Matriz - Abaixo da Média = " + ab_media);
            Console.WriteLine("----------------------------------------------");

            ac_media = 0;
            ab_media = 0;


            Console.WriteLine("==============================================");
            Console.WriteLine(" Matriz B");
            Console.WriteLine("----------------------------------------------");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("{ " + s_ma[i, 0] + " ," + s_ma[i, 1] + " ," + s_ma[i, 2] + " ," + s_ma[i, 3] + " }");
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" Matriz - Média = " + media1);
            Console.WriteLine("----------------------------------------------");

            for (i = 0; i < 4; i++)
            {
                for (p = 0; p < 4; p++)
                {
                    if (p_ma[i, p] > media1)
                    {
                        ac_media = ac_media + 1;
                    }
                    else if (p_ma[i, p] < media2)
                    {
                        ab_media = ab_media + 1;
                    }
                }
            }
            Console.WriteLine(" Matriz - Acima da Média = " + ac_media);
            Console.WriteLine(" Matriz - Abaixo da Média = " + ab_media);
            Console.WriteLine("----------------------------------------------");
        }
    }
}