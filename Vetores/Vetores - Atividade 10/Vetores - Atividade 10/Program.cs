namespace Vetores___Atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int i;

            Console.WriteLine("------------------------------------------");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o número para o índice: " + i);
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("Vetor em Ordem Digitada");
            Console.WriteLine("-----------------------------------------------");
            for (i = 0; i < 5; i++)
            {
                Console.Write(numeros[i] + "|");
            }
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Vetor invertido");
            Console.WriteLine("-----------------------------------------------");

            Array.Reverse(numeros);



            for (i=0; i<5; i++)
            {
                Console.Write(numeros[i]+"|");
            }
        }
    }
}