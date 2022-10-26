namespace Lógica_de_Programação___Atividade_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------------");
            for (double i = 1; i <= 20; i++)
            {
                double centimetro = i * 2.54;
                Console.WriteLine("Valor de Centímetro: " + i + " | Valor em Polegada " + centimetro);
                Console.WriteLine("------------------------------------------------------------");
            }   
        }
    }
}