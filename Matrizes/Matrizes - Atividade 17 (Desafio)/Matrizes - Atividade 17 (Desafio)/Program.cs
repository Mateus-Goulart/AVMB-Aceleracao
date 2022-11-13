namespace Matrizes___Atividade_17__Desafio_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int[,] numeros = new int[10, 10];
            int i, p, min = 0, max = 0;

            for (i=0; i<10; i++)
            {
                for (p=0; p<10; p++)
                {
                    numeros[i, p] = gerador.Next(100);
                }
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Matriz [10,10] Aleatória");
            Console.WriteLine("--------------------------------------");

            for (i=0; i<10; i++)
            {
                Console.Write("{ ");
                for (p=0; p<10; p++)
                {
                    Console.Write(numeros[i, p]+" ,");
                }
                Console.Write(" } \n");
            }

            for (i=0; i<10; i++)
            {
                for (p=0; p<10; p++)
                {
                    min = numeros[i, 0];
                    max = numeros[i, 0];

                    if (numeros[i,p] < min)
                    {
                        min = numeros[i, p];
                        
                    }
                    if (numeros[i,p] > max)
                    {
                        max = numeros[i, p];
                        
                    }
                }
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Número Mínimo da Linha ["+i+"] :"+min);
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Número Maior da Linha ["+i+"] :"+max);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}