namespace Matrizes___Atividade_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int[,] matriz1 = new int[3, 4];
            int[,] matriz2 = new int[4,3];
            int i, p;

            for (i=0; i<3; i++)
            {
                for (p=0; p<4; p++)
                {
                    matriz1[i, p] = gerador.Next(100);
                }
            }


            for (i=0; i<4; i++)
            {
                for(p=0; p<3; p++)
                {
                    matriz2[i, p] = matriz1[p, i];
                }
            }


            Console.WriteLine("==============================");
            Console.WriteLine("Matriz 3X4");
            Console.WriteLine("------------------------------");
            for (i=0; i<3; i++)
            {
                Console.Write("{ ");
                for (p=0; p<4; p++)
                {
                    Console.Write(matriz1[i, p]+" ,");
                }
                Console.Write(" } \n");
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Matriz 4X3");
            Console.WriteLine("------------------------------");
            for (i=0; i<4; i++)
            {
                Console.Write("{ ");
                for (p=0; p<3; p++)
                {
                    Console.Write(matriz2[i,p]+" ,");
                }
                Console.Write(" } \n");
            }
            Console.WriteLine("------------------------------");
        }
    }
}