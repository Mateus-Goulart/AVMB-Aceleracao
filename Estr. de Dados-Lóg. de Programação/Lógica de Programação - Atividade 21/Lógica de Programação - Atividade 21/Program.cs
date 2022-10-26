namespace Lógica_de_Programação___Atividade_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, divisor = 0;
            Console.WriteLine("===============================");
            Console.WriteLine("Digite o número");
            Console.WriteLine("-------------------------------");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===============================");

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    divisor++;
                }
            }
            if (divisor == 2)
            {
                Console.Write(numero + " é um número primo");
            }
            else
            {
                Console.WriteLine(numero + " não é um número primo");
            }
            Console.WriteLine("===============================");
        }
    }
}