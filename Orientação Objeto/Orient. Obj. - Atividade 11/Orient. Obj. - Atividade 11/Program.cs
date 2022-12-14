namespace Orient._Obj.___Atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int op = 0;

                Console.WriteLine("==============================================");
                Console.WriteLine("Qual tipo de pessoa deseja cadastrar:");
                Console.WriteLine("==============================================");
                Console.Write("1 - Pessoa Física. \n" +
                    "2 - Pessoa Juridica \n");
                Console.WriteLine("==============================================");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("==============================================");
                switch (op)
                {
                    case 1:
                        PessoaFisica p2 = new PessoaFisica();
                        p2.cadastrarPF();
                        break;
                    case 2:
                        PessoaJuridica p1 = new PessoaJuridica();
                        p1.cadastrarPJ();
                        break;
                    default:
                        Console.WriteLine("Opção Ínvalida");
                        break;
                }
            }
        }
    }
}