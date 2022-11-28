namespace Orient._Obj.___Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Livro l1= new Livro();
            while (true)
            {
                Console.WriteLine("==========================================");
                Console.WriteLine("Deseja adicionar ou visualizar um Livro:");
                Console.WriteLine("------------------------------------------");
                Console.Write("1) Para Cadastrar um Livro. \n2) Para visualizar o livro.\n");
                Console.WriteLine("------------------------------------------");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                if (op == 1)
                {
                    l1.cadastrarLivro();
                }
                else if (op == 2)
                {
                    l1.exibirLivro();
                }
                else
                {
                    Console.WriteLine("Opção Ínvalida");
                }
            }
        }
    }
}