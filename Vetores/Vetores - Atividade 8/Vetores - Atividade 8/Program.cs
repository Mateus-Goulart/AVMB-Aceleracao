namespace Vetores___Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[30];
            int i;

            Console.WriteLine("------------------------------------------");

            for (i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite o número para o índice: " + i);
                numeros[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
            }


            for (i = 0; i < 30; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine("O índice: " + i + " possui um número negativo");
                    Console.WriteLine("------------------------------------------");
                }

            }
        }
    }
}