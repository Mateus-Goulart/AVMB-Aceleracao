namespace Vetores___Atividade_9
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

            Array.Sort(numeros);

            for (i=0; i<10; i++)
            {
                Console.Write(numeros[i]+"|");
            }

        }
    }
}