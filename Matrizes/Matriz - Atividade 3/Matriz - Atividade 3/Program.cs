namespace Matriz___Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[4, 4];
            int i, p;

            Console.WriteLine("=============================================");

            for (i = 0; i < 4; i++)
            {
                for (p = 0; p < 4; p++)
                {
                    Console.WriteLine("Digite o indice " + p + " da linha " + i);
                    Console.WriteLine("---------------------------------------------");
                    numeros[i, p] = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------");
                }
            }


            Console.WriteLine("=============================================");
            Console.WriteLine("Matriz Final");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("{ " + numeros[0, 0] + " ,   ,   ,   }");
            Console.WriteLine("{  ," + numeros[1, 1] + " ,    ,   }");
            Console.WriteLine("{  ,   ," + numeros[2, 2] + " ,   }");
            Console.WriteLine("{  ,   ,   , " + numeros[3, 3] + "}");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("=============================================");
            Console.WriteLine("Matriz Final - Completa");
            Console.WriteLine("---------------------------------------------");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("{ " + numeros[i, 0] + " ," + numeros[i, 1] + " ," + numeros[i, 2] + " ," + numeros[i, 3] + " }");
            }
            Console.WriteLine("---------------------------------------------");
        }
    }
}