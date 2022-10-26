namespace Lógica_de_Programação___Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha, i = 0;
            while (i < 5)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("Bem Vindo ao Dicionario de Números.");
                Console.WriteLine("================================================");
                Console.WriteLine("1) Números de 0 até 9 em Português.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("2) Números de 0 até 9 em Espanhol.");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("3) Números de 0 até 9 em Inglês");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("4) Sair");
                Console.WriteLine("------------------------------------------------");
                escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("************************************************");

                if (escolha == 1)
                {
                    Console.WriteLine("Números em Português");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("0 - Zero");
                    Console.WriteLine("1 - Um");
                    Console.WriteLine("2 - Dois");
                    Console.WriteLine("3 - Três");
                    Console.WriteLine("4 - Quatro");
                    Console.WriteLine("5 - Cinco");
                    Console.WriteLine("6 - Seis");
                    Console.WriteLine("7 - Sete");
                    Console.WriteLine("8 - Oito");
                    Console.WriteLine("9 - Nove");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Obrigado pela visita e até a próxima");
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Números em Espanhol");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("0 - Cero");
                    Console.WriteLine("1 - Uno");
                    Console.WriteLine("2 - Dos");
                    Console.WriteLine("3 - Tres");
                    Console.WriteLine("4 - Cuatro");
                    Console.WriteLine("5 - Cinco");
                    Console.WriteLine("6 - Seis");
                    Console.WriteLine("7 - Siete");
                    Console.WriteLine("8 - Ocho");
                    Console.WriteLine("9 - Nueve");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Obrigado pela visita e até a próxima");
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Números em Inglês");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("0 - Zero");
                    Console.WriteLine("1 - One");
                    Console.WriteLine("2 - Two");
                    Console.WriteLine("3 - Three");
                    Console.WriteLine("4 - Four");
                    Console.WriteLine("5 - Five");
                    Console.WriteLine("6 - Six");
                    Console.WriteLine("7 - Seven");
                    Console.WriteLine("8 - Eight");
                    Console.WriteLine("9 - Nine");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Obrigado pela visita e até a próxima");
                }
                else if (escolha == 4)
                {
                    Console.WriteLine("Obrigado pela visita e até a próxima");
                    Console.WriteLine("------------------------------------------------");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção Invalida");
                }
                Console.WriteLine("================================================");
            }
        }
    }
}