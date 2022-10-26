namespace Matriz___Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];
            int i, p;

            Console.WriteLine("=============================================");

            for (i = 0; i < 5; i++)
            {
                for (p = 0; p < 5; p++)
                {
                    Console.WriteLine("Digite o indice " + p + " da linha " + i);
                    Console.WriteLine("---------------------------------------------");
                    numeros[i, p] = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------------");
                }
            }


            Console.WriteLine("=============================================");
            Console.WriteLine("Matriz Final - Completa");
            Console.WriteLine("---------------------------------------------");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{ " + numeros[i, 0] + " ," + numeros[i, 1] + " ," + numeros[i, 2] + " ," + numeros[i, 3] + " ," + numeros[i, 4] + " }");
            }
            Console.WriteLine("---------------------------------------------");

            for (i = 0; i < 5; i++)
            {
                for (p = 0; p < 5; p++)
                {
                    if (numeros[i, p] % 2 == 0 && numeros[i, p] != 0)
                    {
                        Console.WriteLine("Valor Contido na Coluna " + i + "e na linha " + p + ":");
                        Console.WriteLine(numeros[i, p] + " é um valor Par");
                        if (numeros[i, p] < 0)
                        {
                            Console.WriteLine("O valor: " + i + " é um valor negativo");
                        }
                        else
                        {
                            Console.WriteLine("O valor: " + numeros[i, p] + " é um valor positivo");
                        }
                        Console.WriteLine("---------------------------------------------");
                    }
                    else if (numeros[i, p] == 0)
                    {
                        Console.WriteLine("Valor Contido na Coluna " + i + "e na linha " + p + ":");
                        Console.WriteLine(" Vale 0");
                        Console.WriteLine("---------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Valor Contido na Coluna " + i + "e na linha " + p + ":");
                        Console.WriteLine(numeros[i, p] + " é um valor Ímpar");
                        if (numeros[i, p] < 0)
                        {
                            Console.WriteLine("O valor: " + i + " é um valor negativo");
                        }
                        else
                        {
                            Console.WriteLine("O valor: " + numeros[i, p] + " é um valor positivo");
                        }
                        Console.WriteLine("---------------------------------------------");
                    }
                }
            }
        }
    }
}