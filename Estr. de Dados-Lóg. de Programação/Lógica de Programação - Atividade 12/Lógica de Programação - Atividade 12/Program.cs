namespace Lógica_de_Programação___Atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vi = 0, vf = 0;
            Console.WriteLine("================================");
            Console.WriteLine("Digite o Valor Inicial");
            Console.WriteLine("--------------------------------");
            vi = int.Parse(Console.ReadLine());
            Console.WriteLine("================================");
            Console.WriteLine("Digite o Valor Final");
            Console.WriteLine("--------------------------------");
            vf = int.Parse(Console.ReadLine());
            Console.WriteLine("================================");

            for (int i = vi; i <= vf; i++)
            {
                if (i % 2 == 0)
                {
                    float resto = i % 11;
                    Console.WriteLine("Valor Par é igual a: " + i);
                    Console.WriteLine("--------------------------------");
                }
            }
        }
    }
}