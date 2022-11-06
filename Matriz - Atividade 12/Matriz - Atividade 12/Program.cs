namespace Matriz___Atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[4, 3];
            int i=0, p=0, soma =0;

            for (i=0; i<4; i++)
            {
                for (p=0; p<3; p++)
                {
                    Console.WriteLine("Digite o valor da coordenada: ["+i+" ,"+p+"] da Matriz");
                    numeros[i, p] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("==========================================");
            Console.WriteLine("Matriz Original");
            Console.WriteLine("==========================================");
            for (i=0; i<4; i++)
            {
                Console.Write(" { ");
                for (p=0; p<3; p++)
                {
                    Console.Write(numeros[i,p] + " ,");
                }
                Console.Write(" } \n");
            }

            Console.WriteLine("==========================================");
            Console.WriteLine(" Valores Cuja a soma dos Índices é Par");
            Console.WriteLine("==========================================");
            for (i=0; i<4; i++)
            {
                Console.Write(" { ");
                for (p=0; p<3; p++)
                {
                    
                    soma = i + p;
                    if (soma%2 == 0)
                    {
                        Console.Write(numeros[i, p] + " ,");
                    }
                    
                    else
                    {
                        Console.Write("- ,");
                    }
                    
                }
                Console.Write(" } \n");
            }

        }
    }
}