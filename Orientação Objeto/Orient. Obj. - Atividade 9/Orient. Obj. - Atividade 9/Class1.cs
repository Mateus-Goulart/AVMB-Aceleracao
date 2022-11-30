namespace Orient._Obj.___Atividade_9
{
    internal class Motor
    {
        private string nomeFabricante = "";
        private int potencia = 0;
        private string tipo = "";

        public void cadastrarMotor()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Insira o nome do fabricante:");
            Console.WriteLine("-----------------------------------------");
            this.nomeFabricante = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Insira a potencia do motor:");
            Console.WriteLine("-----------------------------------------");
            this.potencia = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Insira o tipo do motor:");
            Console.WriteLine("-----------------------------------------");
            this.tipo = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
        }

        public void exibirMotor()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nome do Fabricante: " + this.nomeFabricante);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Potencia: "+this.potencia);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Tipo: "+this.tipo);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
