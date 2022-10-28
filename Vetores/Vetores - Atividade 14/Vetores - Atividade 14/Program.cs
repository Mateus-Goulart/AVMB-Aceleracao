namespace Vetores___Atividade_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[50] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50};

            int i, op;

            while (true)
            {
                Console.Write("================================================================\n" +
                "Bem-vindo ao reorganizador de Vetores \n" +
                "----------------------------------------------------------------\n" +
                "1 - Para exibir o vetor. | 2 - Para inverter a ordem do vetor. \n" +
                "3 - Para substituir o vetor. | 0 - Para sair \n" +
                "================================================================\n");

                op = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------------------");

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Até logo");
                        Console.WriteLine("================================================================");
                        System.Environment.Exit(1);
                        break;
                    case 1:
                        Console.WriteLine("Ordem Lida");
                        Console.Write("\n { ");
                        for (i = 0; i < 50; i++)
                        {
                            Console.Write(numeros[i] + " ,");
                        }
                        Console.Write(" } \n");
                        break;
                    case 2:
                        Console.WriteLine("Ordem Invertida");
                        Array.Reverse(numeros);
                        Console.Write("\n { ");
                        for (i = 0; i < 50; i++)
                        {
                            Console.Write(numeros[i] + " ,");
                        }
                        Console.Write(" } \n");

                        break;
                    case 3:
                        for (i=0; i<50; i++)
                        {
                            Console.WriteLine("Digite o valor do índice: "+i);
                            numeros[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("----------------------------------------------------------------");
                        }
                        break;
                }
            }
        }
    }
}