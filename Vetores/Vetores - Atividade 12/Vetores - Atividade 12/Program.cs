namespace Vetores___Atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 30, 42, 23, 37, 49, 53, 12, 15, 27, 63 };
            int i, numero;

            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("Digite um número para verificar o vetor:");
                Console.WriteLine("----------------------------------------");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("========================================");

                for (i = 0; i < 10; i++)
                {
                    if (numeros[i] == numero)
                    {
                        Console.WriteLine("O número " + numero + " está presente no vetor no índice: " + i);
                        Console.WriteLine("------------------------------------------------");
                        System.Environment.Exit(1);
                    }

                }

                Console.WriteLine("Ops! Parece que o valor digitado não está presente no vetor.");
                Console.WriteLine("Nosso vetor é:");
                Console.Write("{ ");
                for(i = 0; i<10; i++)
                {
                    Console.Write(numeros[i]+" ,");
                }
                Console.Write(" } \n");
            } 


        }
    }
}