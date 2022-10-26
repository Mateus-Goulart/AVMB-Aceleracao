namespace Lógica_de_Programação___Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            decimal media;

            Console.WriteLine("------------------------");
            Console.WriteLine("Digite o Primeiro número");
            Console.WriteLine("------------------------");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite o Segundo número");
            Console.WriteLine("------------------------");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite o Terceiro número");
            Console.WriteLine("------------------------");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite o Quarto número");
            Console.WriteLine("------------------------");
            n4 = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("Sua média é: ");
            Console.WriteLine("------------------------");
            media = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine(media);

            if (n1 > media)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("O valor " + n1 + " é maior que a média");
            }
            if (n2 > media)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("O valor " + n2 + " é maior que a média");
            }
            if (n3 > media)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("O valor " + n3 + " é maior que a média");
            }
            if (n4 > media)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("O valor " + n4 + " é maior que a média");
            }
        }
    }
}