namespace Matriz___Atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros1 = new int[3, 3];
            int[,] numeros2 = new int[3, 3];
            int soma = 0, i,p;

            Console.WriteLine("================================================");
            Console.WriteLine("Criando a Matriz");
            Console.WriteLine("================================================");
            for (i=0; i<3; i++)
            {
                for (p=0; p<3; p++)
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Digite o valor posicionado na coordenada: ["+i+" ,"+p+"] da Matriz");
                    Console.WriteLine("------------------------------------------------");
                    numeros1[i, p] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("================================================");
            Console.WriteLine("Matriz Original");
            Console.WriteLine("================================================");
            for (i=0; i<3; i++)
            {
                Console.Write("{ ");
                for (p=0; p<3; p++)
                { 
                Console.Write(numeros1[i, p] + " ,");
                }
                Console.Write(" } \n");
            }

            Console.WriteLine("================================================");
            Console.WriteLine("Resultados da Divisão");
            Console.WriteLine("================================================");

            for (i=0; i<3; i++)
            {
                Console.Write("{ ");
                for (p=0; p<3; p++)
                {
                    if (p==0 && i==0)
                    {
                        Console.Write(numeros2[0, 0] + " ,");
                    }
                    else
                    {
                        soma = p + i;
                        numeros2[i, p] = numeros1[i, p]/soma;
                        Console.Write(numeros2[i, p] + " ,");
                    }
                }
                Console.Write(" } \n");
            }

        }
    }
}