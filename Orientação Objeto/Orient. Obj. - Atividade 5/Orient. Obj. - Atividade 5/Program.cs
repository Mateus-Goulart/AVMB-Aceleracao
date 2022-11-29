namespace Orient._Obj.___Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo = "", autor = "", data_lancamento = "", editora = "";
            int numero_paginas = 0, op;
            while (true)
            {
                Livro l1 = new Livro();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Deseja Cadastrar/Exibir um livro");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1 - Para Cadastrar um Livro | 2 - Para Cadastrar um Livro (Construtor) | 3 - Exibir Livro");
                Console.WriteLine("--------------------------");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");
                if (op == 1)
                {
                    l1.cadastrarLivro();
                }
                else if (op == 2)
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Digite o Título do Livro:");
                    Console.WriteLine("--------------------------");
                    titulo = Console.ReadLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Digite o Autor:");
                    Console.WriteLine("--------------------------");
                    autor = Console.ReadLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Digite a Data de Lançamento:");
                    Console.WriteLine("--------------------------");
                    data_lancamento = Console.ReadLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Digite a Editora:");
                    Console.WriteLine("--------------------------");
                    editora = Console.ReadLine();
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Digite o Número de Páginas do Livro");
                    Console.WriteLine("--------------------------");
                    numero_paginas = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------");
                    l1.ConstrCadastrarLivro(titulo, autor, data_lancamento, editora, numero_paginas);
                }
                else if (op == 3)
                {
                    l1.exibirLivro();
                }
                else
                {
                    Console.WriteLine("Opção Ínvalida");
                    Console.WriteLine("--------------------------");
                }
            }
        }
    }
}