using Arquivo___Atividade_1;

namespace Arquivo___Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista_figuras a;
            string con, figura;
            int op;

            while (true)
            {
                Console.WriteLine("=================================================================");
                Console.WriteLine("Bem-Vindo ao gerenciado virtual de Figurinhas");
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("1 - Cadastrar Figurinhas Faltantes");
                Console.WriteLine("2 - Cadastrar Figurinhas Repetidas");
                Console.WriteLine("3 - Listar Figurinhas Faltantes");
                Console.WriteLine("4 - Listar Figurinhas Repetidas");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("=================================================================");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------------------------");

                switch (op)
                {
                    case 1:
                        con = "Figurinhas_Faltante";
                        a = new Lista_figuras(con);
                        Console.WriteLine("Digite o nome da figurinha que deseja Registrar na Lista de Faltantes");
                        Console.WriteLine("-----------------------------------------------------------------");
                        figura = Console.ReadLine();
                        a.AbrirArquivo();
                        a.CadastrarFigura(figura);
                        a.fecharLista();
                        break;

                    case 2:
                        con = "Figurinhas_Repetidas";
                        a = new Lista_figuras(con);
                        Console.WriteLine("Digite o nome da figurinha que deseja Registrar na Lista de Repetidas");
                        Console.WriteLine("-----------------------------------------------------------------");
                        figura = Console.ReadLine();
                        a.AbrirArquivo();
                        a.CadastrarFigura(figura);
                        a.fecharLista();
                        break;
                    case 3:
                        con = "Figurinhas_Faltante";
                        a = new Lista_figuras(con);
                        Console.WriteLine("Conteúdo da Lista de Figurinhas Faltantes:");
                        Console.WriteLine("-----------------------------------------------------------------");
                        a.ListarFiguras();
                        Console.WriteLine("-----------------------------------------------------------------");
                        break;
                    case 4:
                        con = "Figurinhas_Repetidas";
                        a = new Lista_figuras(con);
                        Console.WriteLine("Conteúdo da Lista de Figurinhas Repetidas:");
                        Console.WriteLine("-----------------------------------------------------------------");
                        a.ListarFiguras();
                        Console.WriteLine("-----------------------------------------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Até Logo.");
                        Console.WriteLine("=================================================================");
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("Opção Ínvalida, Tente Novamente.");
                        break;

                }

            }

        }
    }
}