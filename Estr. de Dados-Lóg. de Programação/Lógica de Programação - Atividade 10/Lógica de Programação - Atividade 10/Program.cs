namespace Lógica_de_Programação___Atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero;
            Console.WriteLine("========================================");
            Console.WriteLine("Bem-Vindo ao Calculador de Tabuada");
            Console.WriteLine("========================================");
            Console.WriteLine("Digite um Número");
            Console.WriteLine("----------------------------------------");
            numero = float.Parse(Console.ReadLine());
            Console.WriteLine("****************************************");

            Console.WriteLine("O Resultado da Tabuada do " + numero);
            Console.WriteLine("****************************************");

            for (int i = 0; i <= 100; i++)
            {
                float operacao = numero * i;
                Console.WriteLine(numero + " X " + i + " = " + operacao);
                Console.WriteLine("----------------------------------------");
            }
            Console.WriteLine("Obrigado pela visita, volte sempre.");
            Console.WriteLine("----------------------------------------");
        }
    }
}