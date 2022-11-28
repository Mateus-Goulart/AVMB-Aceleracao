namespace Orient._Obj.___Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televisão tv1 = new Televisão();
            int op;
            double canal;
            while (true)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1) Ligar a televisão. \n2) Desligar a televisão. \n3) Mudar de canal");
                Console.WriteLine("---------------------------------------");
                op = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------");
                if (op == 1)
                {
                    tv1.ligarTelevisao();
                }
                else if (op == 2)
                {
                    tv1.desligarTelevisao();

                }
                else if (op == 3)
                {
                    Console.WriteLine("Digite o canal que deseja assistir:");
                    canal = double.Parse(Console.ReadLine());
                    tv1.mudarCanal(canal);
                }
                else
                {
                    Console.WriteLine("Opção Ínvalida");
                }
            }
        }
    }
}