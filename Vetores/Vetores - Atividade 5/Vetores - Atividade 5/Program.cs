namespace Vetores___Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5] {1,2,3,4,0};
            int i, menor;

            Console.WriteLine("===================================");
            for (i=0; i<5; i++)
            {
                Console.WriteLine("Digite o valor do Índice: "+i);
                Console.WriteLine("-----------------------------------");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("===================================");
            }

            menor = numeros[0];

            for (i=0; i<5; i++)
            {
                if (menor >= numeros[i])
                {
                    menor = numeros[i];
                    Console.WriteLine("Número menor: " + menor + " índice: " + i);
                    Console.WriteLine("----------------------------------------");
                }
            }
            
        }
    }
}