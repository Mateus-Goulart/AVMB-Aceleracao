using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_4
{
    internal class Pessoa
    {
        public string nome = "", cpf = "", data_nascimento = "";
        public int rg=0;

        public void cadastrarPessoa()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite o nome da pessoa a ser cadastrada:");
            Console.WriteLine("-----------------------------------------");
            this.nome = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite o CPF da pessoa a ser cadastrada:");
            Console.WriteLine("-----------------------------------------");
            this.cpf = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite a data de nascimento da pessoa a ser cadastrada");
            Console.WriteLine("-----------------------------------------");
            this.data_nascimento = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Digite o RG da pessoa a ser cadastrada");
            Console.WriteLine("-----------------------------------------");
            this.rg = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
        }
        public void exibirCadastro()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nome: "+this.nome);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("CPF: "+this.cpf);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Data de Nascimento: "+this.data_nascimento);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("RG: "+this.rg);
            Console.WriteLine("-----------------------------------------");
        }
    }
}
