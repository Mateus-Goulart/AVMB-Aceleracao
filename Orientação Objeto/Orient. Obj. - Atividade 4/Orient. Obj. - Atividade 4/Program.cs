namespace Orient._Obj.___Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            while (true)
            {
                Console.WriteLine("Cadastrar ou Exibir pessoa cadastrada:");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1 - Cadastrar | 2 - Exibir Cadastro");
                Console.WriteLine("-----------------------------------------");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");
                if (op == 1)
                {
                    p1.cadastrarPessoa();
                }
                else if (op == 2)
                {
                    p1.exibirCadastro();
                }
                else
                {
                    Console.WriteLine("Opção Ínvalida.");
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
    }
}