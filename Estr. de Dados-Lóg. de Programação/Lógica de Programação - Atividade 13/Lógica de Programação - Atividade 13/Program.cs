namespace Lógica_de_Programação___Atividade_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vi, vf, opcao;
            while (true)
            {
                Console.WriteLine("=============================================================================");
                Console.WriteLine("Digite o Valor Inicial");
                Console.WriteLine("-----------------------------------------------------------------------------");
                vi = int.Parse(Console.ReadLine());
                Console.WriteLine("======================================================================================");
                Console.WriteLine("Digite o Valor Final");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                vf = int.Parse(Console.ReadLine());
                Console.WriteLine("======================================================================================");
                Console.WriteLine("Deseja pular algum tipo de número");
                Console.WriteLine("--------------------------------------------------------------------------------------");
                Console.WriteLine("[1] Pular Números Pares|[2] Pular Números Ímpares|[3] Não Pular Nenhum Número|[4] Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("=======================================================================================");

                if (opcao == 1)
                {
                    for (int i = vi; i <= vf; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("Valor Igual a " + i);
                            Console.WriteLine("--------------------------------------------------------------------------------------");
                        }
                    }
                }
                else if (opcao == 2)
                {
                    for (int i = vi; i <= vf; i++)
                    {
                        if (i % 2 == 1)
                        {
                            Console.WriteLine("Valor Igual a " + i);
                            Console.WriteLine("--------------------------------------------------------------------------------------");
                        }
                    }
                }
                else if (opcao == 3)
                {
                    for (int i = vi; i <= vf; i++)
                    {
                        Console.WriteLine("Valor Igual a " + i);
                        Console.WriteLine("--------------------------------------------------------------------------------------");
                    }
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Obrigado pela Visita, Volte Sempre");
                    Console.WriteLine("=======================================================================================");
                    break;
                }
                else
                {
                    Console.WriteLine("Desculpe, Opção Inválida");
                    Console.WriteLine("--------------------------------------------------------------------------------------");
                }
            }
        }    
    }
}