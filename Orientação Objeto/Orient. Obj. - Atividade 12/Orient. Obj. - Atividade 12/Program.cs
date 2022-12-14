namespace Orient._Obj.___Atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonagemJogavel player = new PersonagemJogavel();
            NPC oponente = new NPC();
            oponente.criarRapido("Max");
            player.criarPersonagem();

            while (true)
            {
                

                Console.WriteLine("--------------------------------");
                Console.WriteLine("O que de seja fazer?");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1- Andar");
                Console.WriteLine("2- Atacar");
                Console.WriteLine("3- Checar Seus Status");
                Console.WriteLine("4- Checar status do oponente");
                Console.WriteLine("--------------------------------");
                int op = int.Parse(Console.ReadLine());
                oponente.andar();
                switch (op)
                {
                    case 1:
                        player.andarJ();
                        break;
                    case 2:
                        player.atacar(oponente);
                        break;
                    case 3:
                        player.checarStatus();
                        break;
                    case 4:
                        oponente.checarStatus();
                        break;
                }
            }
        }
    }
}