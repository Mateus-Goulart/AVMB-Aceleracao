namespace Lógica_de_Programação___Atividade_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vi, vf;
            Console.WriteLine("===========================");
            Console.WriteLine("Escolha um valor inicial");
            vi = int.Parse(Console.ReadLine());
            Console.WriteLine("===========================");
            Console.WriteLine("Escolha um valor final");
            vf = int.Parse(Console.ReadLine());
            Console.WriteLine("===========================");

            for (int i = vi; i <= vf; i++)
            {
                Console.WriteLine("Valor = " + i);
                Console.WriteLine("---------------------------");
            }
        }
    }
}