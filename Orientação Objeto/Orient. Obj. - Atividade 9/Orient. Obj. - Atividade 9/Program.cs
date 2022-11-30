namespace Orient._Obj.___Atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor m1 = new Motor();
            int op;


            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1) Para Cadastrar o motor | 2) Para Visualizar o motor");
                Console.WriteLine("-----------------------------------------");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------");
                switch (op)
                {
                    case 1:
                        m1.cadastrarMotor();
                        break;
                    case 2:
                        m1.exibirMotor();
                        break;
                    default:
                        Console.WriteLine("Opção Ínvalida");
                        Console.WriteLine("-----------------------------------------");
                        break;
                }
            }
        }
    }
}