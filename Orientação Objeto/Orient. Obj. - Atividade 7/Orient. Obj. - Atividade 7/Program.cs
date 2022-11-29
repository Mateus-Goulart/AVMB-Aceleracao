namespace Orient._Obj.___Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem();
            int posicao, op, direcao;
            Console.WriteLine("==================================");
            Console.WriteLine("Bem-Vindo, Por favor se apresente:");
            Console.WriteLine("----------------------------------");
            p1.nome = Console.ReadLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Seja Bem-Vindo, " + p1.nome);
            Console.WriteLine("----------------------------------");
            while (true)
            {
                Console.WriteLine("O que deseja fazer agora?");
                Console.WriteLine("----------------------------------");
                Console.Write("1) Andar para alguma direção. \n" +
                    "2) Coletar itens. (Diga Quantos itens você coletou, seu inventário só possui 20 Slots) \n" +
                    "3) Abrir Inventário \n" +
                    "4) Mudar de Posição (em caso de estar em grupo). \n" +
                    "5) Caso deseje sair. \n");
                Console.WriteLine("----------------------------------");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("=================================");
                        Console.WriteLine("Para onde deseja ir?");
                        Console.WriteLine("----------------------------------");
                        Console.Write("1) Para a Frete. \n 2) Para a Esquerda. \n 3) Para Direita. \n 4) Para Trás. \n 5) Deseja parar. \n");
                        direcao = int.Parse(Console.ReadLine());
                        p1.andar(direcao);
                        break;
                    case 2:
                        Console.WriteLine("Quantos itens você coletou?");
                        int number = int.Parse(Console.ReadLine());
                        p1.coletarItens(number);
                        break;
                    case 3:
                        p1.exibirInventario();
                        break;
                    case 4:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Qual a posição desejada?");
                        Console.WriteLine("----------------------------------");
                        posicao = int.Parse(Console.ReadLine());
                        Console.WriteLine("==================================");
                        p1.mudarPosição(posicao);
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção Ínvalida.");
                        break;
                }
            }
        }
    }
}
