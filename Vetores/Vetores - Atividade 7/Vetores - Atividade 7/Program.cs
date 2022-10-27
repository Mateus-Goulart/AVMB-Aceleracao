namespace Vetores___Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int i;

            Console.WriteLine("------------------------------------------");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o número para o índice: " + i);
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
            }


            Console.WriteLine("Vetor Final");
            Console.WriteLine("------------------------------------------");
            for (i=0; i < 10; i++)
            {
                if (numeros[i]%2 == 0)
                {
                    Console.Write(numeros[i] +"|");
                }
            }

            for (i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    Console.Write(numeros[i] + "|");
                }
            }

        }
    }
}