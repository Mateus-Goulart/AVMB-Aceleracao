namespace Orient._Obj.___Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            int op;
            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.Write("1) Para Cadastar um Aluno e suas Materias. \n2) Para Visualizar o perfil do aluno.\n");
                Console.WriteLine("-----------------------------------------");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");
                if (op == 1)
                {
                    aluno.cadastrarAluno();
                }
                else if (op == 2)
                {
                    aluno.exibirAluno();
                }
                else
                {
                    Console.WriteLine("Opção Ínvalida");
                    Console.WriteLine("-----------------------------------------");
                }
            }
        }
    }
}