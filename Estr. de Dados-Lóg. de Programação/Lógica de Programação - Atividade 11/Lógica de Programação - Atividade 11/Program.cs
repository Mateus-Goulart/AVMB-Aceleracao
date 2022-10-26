namespace Lógica_de_Programação___Atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i <= 1999; i++)
            {
                if (i % 11 == 5)
                {
                    float resto = i % 11;
                    Console.WriteLine("Valor igual: " + i + " com resto: " + resto);
                }
            }
        }
    }
}