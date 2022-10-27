namespace Vetores___Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] { 7 , 40 , 3 , 9 , 21 , 0 , 63 , 31 , 7 , 22 };
            int i, p=9;

            Console.WriteLine("Vetor inicial");
            Console.WriteLine("--------------------------------------------");
            for (i=0; i<10; i++)
            {
                Console.Write(numeros[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------");

            Array.Reverse(numeros);
            
            Console.WriteLine("Vetor Final");
            Console.WriteLine("--------------------------------------------");
            for (i = 0; i < 10; i++)
            {
                Console.Write(numeros[i]);
            }
        }
    }
}