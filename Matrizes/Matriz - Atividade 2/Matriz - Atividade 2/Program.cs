namespace Matriz___Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[3, 3];
            int i, p, soma;

            Console.WriteLine("=============================================");

            for (i = 0; i < 3; i++)
            {
                for (p = 0; p < 3; p++)
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
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("{ " + numeros[i, 0] + " ," + numeros[i, 1] + " ," + numeros[i, 2] + " }");
            }
            Console.WriteLine("---------------------------------------------");

            for (i = 0; i < 3; i++)
            {
                soma = numeros[i, 0] + numeros[i, 1] + numeros[i, 2];
                Console.WriteLine("Soma elementos da linha: " + i);
                Console.WriteLine("Resultado: " + soma);
                Console.WriteLine("---------------------------------------------");
            }

            for (i = 0; i < 3; i++)
            {
                soma = numeros[0, i] + numeros[1, i] + numeros[2, i];
                Console.WriteLine("Soma elementos da Coluna: " + i);
                Console.WriteLine("Resultado: " + soma);
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}