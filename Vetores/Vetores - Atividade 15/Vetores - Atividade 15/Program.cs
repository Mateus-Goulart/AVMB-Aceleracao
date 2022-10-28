namespace Vetores___Atividade_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros1 = new int[20];
            int[] num2 = new int[20];

            int i;

            for (i=0; i<20; i++)
            {
                Console.WriteLine("Digite o valor do índice: "+i);
                numeros1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("{ ");
            for (i=0; i<20;i++) { 
            Console.WriteLine(numeros1+" ,");
            }
            Console.Write(" } \n");

            Array.Reverse(numeros1);

            for (i = 0; i < 20; i++)
            {
                num2[i] = numeros1[i];
            }

            Console.Write("{ ");
            for (i = 0; i < 20; i++)
            {
                Console.WriteLine(num2 + " ,");
            }
            Console.Write(" }");
        }
    }
}