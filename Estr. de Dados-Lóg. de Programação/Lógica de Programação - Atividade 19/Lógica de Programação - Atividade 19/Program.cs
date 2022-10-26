namespace Lógica_de_Programação___Atividade_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            for (i = 0; i < 10; i++)

            {

                Console.WriteLine("Volta numero :" + i);
                if (i == 5 || i == 7)
                {
                    continue;
                }
            }
        }
    }
}