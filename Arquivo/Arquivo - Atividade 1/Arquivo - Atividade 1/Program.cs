namespace Arquivo___Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            string nomelista, email;
            Lista_email a;


            while (true) 
            {
                Console.WriteLine("====================================================================");
                Console.WriteLine("Olá, Bem-Vindo.");
                Console.WriteLine("Escolha uma das opções a seguir:");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("1 - Cadastrar um E-mail");
                Console.WriteLine("2 - Listar e-mails Cadastrados");
                Console.WriteLine("3 - Sair do Programa");
                Console.WriteLine("====================================================================");

                op = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------");

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Diga o nome da lista que deseja Abrir/Criar para armazenar o E-mail:");
                        Console.WriteLine("--------------------------------------------------------------------");
                        nomelista = Console.ReadLine();
                        a = new Lista_email(nomelista);
                        a.CriarLista();
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("Digite o E-mail a ser Cadastrado:");
                        Console.WriteLine("--------------------------------------------------------------------");
                        email = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------------------------------");
                        a.CadastrarEmail(email);
                        a.fecharLista();
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome da lista a qual deseja abrir:");
                        Console.WriteLine("--------------------------------------------------------------------");
                        nomelista = Console.ReadLine();
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.WriteLine("Conteúdo da Lista:");
                        a = new Lista_email(nomelista);
                        a.ListarConteudo();

                        break;

                    case 3:
                        Console.WriteLine("Até Logo");
                        Console.WriteLine("====================================================================");
                        Environment.Exit(-1);
                        break;

                    default:
                        Console.WriteLine("Opção Ínvalida, Tente Novamente");
                        break;
                }

            }

        }
    }
}