namespace Lógica_de_Programação____Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra_digitada;

            Console.WriteLine("Digite uma letra.");
            letra_digitada = char.Parse(Console.ReadLine());

            switch (letra_digitada)
            {
                case 'a':
                    Console.WriteLine("A letra " + letra_digitada + " é uma vogal");
                    break;
                case 'e':
                    Console.WriteLine("A letra " + letra_digitada + " é uma vogal");
                    break;
                case 'i':
                    Console.WriteLine("A letra " + letra_digitada + " é uma vogal");
                    break;
                case 'o':
                    Console.WriteLine("A letra " + letra_digitada + " é uma vogal");
                    break;
                case 'u':
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("A letra " + letra_digitada + " é uma Consoante");
                    break;

            }
        }
}