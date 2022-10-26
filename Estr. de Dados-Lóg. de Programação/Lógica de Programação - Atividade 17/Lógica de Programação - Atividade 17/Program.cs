namespace Lógica_de_Programação___Atividade_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vi, vf, opcao;

            while (true)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Escolha a Ordem:");
                Console.WriteLine("[1] Crescente |[2] Descrecente |[3] Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Escolha um valor Menor");
                vi = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");
                Console.WriteLine("Escolha um valor Maior");
                vf = int.Parse(Console.ReadLine());
                Console.WriteLine("===========================");

                if (opcao == 1)
                {
                    if (vi < vf)
                    {
                        for (int i = vi; i <= vf; i++)
                        {
                            Console.WriteLine("Valor = " + i);
                            Console.WriteLine("---------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desculpe, Valores Inválidos");
                        Console.WriteLine("---------------------------");
                        continue;
                    }
                }
                else if (opcao == 2)
                {
                    if (vi < vf)
                    {
                        for (int i = vf; i >= vi; i--)
                        {
                            Console.WriteLine("Valor = " + i);
                            Console.WriteLine("---------------------------");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Desculpe, Valores Inválidos");
                        Console.WriteLine("---------------------------");
                        continue;
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Obrigado pela visita, Volte Sempre");
                    Console.WriteLine("---------------------------");
                    break;
                }
                else
                {
                    Console.WriteLine("Desculpe, Opção Inválida");
                    Console.WriteLine("---------------------------");
                }
            }

        }
    }
}