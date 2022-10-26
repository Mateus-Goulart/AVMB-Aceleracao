namespace Lógica_de_Programação___Atividade_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("[1] Original|[2] Personalizado|[3] Sair");
                Console.WriteLine("---------------------------------------");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    int e = 1000, d = 1;
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Situação Atual: " + e + "/" + d);
                    Console.WriteLine("---------------------------------------");

                    for (int i = 0; i <= 50; i++)
                    {
                        e = e - 3;
                        d = d + 1;
                        Console.WriteLine("Situação Atual: " + e + "/" + d);
                        Console.WriteLine("---------------------------------------");
                    }
                }
                else if (opcao == 2)
                {
                    int e = 0, d = 0;
                    Console.WriteLine("=======================================");
                    Console.WriteLine("Digite o Valor a ser reduzido");
                    e = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("O valor a ser aumentado");
                    d = int.Parse(Console.ReadLine());
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Situação Atual: " + e + "/" + d);
                    Console.WriteLine("---------------------------------------");

                    for (int i = 0; i <= 50; i++)
                    {
                        e = e - 3;
                        d = d + 1;
                        Console.WriteLine("Situação Atual: " + e + "/" + d);
                        Console.WriteLine("---------------------------------------");
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Obrigado pela visita, volte sempre");
                    Console.WriteLine("---------------------------------------");
                    break;
                }
                else
                    Console.WriteLine("---------------------------------------");
                Console.WriteLine("Desculpe, Opção Inválida");
                Console.WriteLine("---------------------------------------");
                continue;
            }
        }
    }
}