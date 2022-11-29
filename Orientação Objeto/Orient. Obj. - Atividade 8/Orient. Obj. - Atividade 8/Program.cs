namespace Orient._Obj.___Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, cpf, data_nascimento, endereco;
            int rg, op;
            Funcionario f1 = new Funcionario();
            while (true)
            {
                Console.WriteLine("=============================================");
                Console.Write("1) Para Cadastrar o Funcionario. \n2) Para ver a ficha do funcionario. \n");
                Console.WriteLine("---------------------------------------------");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------");
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do Funcionario: ");
                        Console.WriteLine("---------------------------------------------");
                        nome = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Digite o CPF do Funcionario: ");
                        Console.WriteLine("---------------------------------------------");
                        cpf = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Digite o RG do Funcionario: ");
                        Console.WriteLine("---------------------------------------------");
                        rg = int.Parse(Console.ReadLine());
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Digite a Data de Nascimento do Funcionario:");
                        Console.WriteLine("---------------------------------------------");
                        data_nascimento = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Digite o Endereço do Funcionario: ");
                        Console.WriteLine("---------------------------------------------");
                        endereco = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
                        f1.cadastarFuncionario(nome,cpf,rg,data_nascimento,endereco);
                        break;
                    case 2:
                        f1.exibirFicha();
                        break;
                    default:
                        Console.WriteLine("Opção Ínvalida.");
                        Console.WriteLine("---------------------------------------------");
                        break;
                }
            }
        }
    }
}