using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_8
{
    internal class Funcionario
    {
        private int rg=0;
        private string nome="", cpf="", data_nascimento = "", endereco = "";

        public void cadastarFuncionario(string nome, string cpf, int rg, string data_nascimento, string endereco)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.data_nascimento = data_nascimento;
            this.endereco = endereco;
        }

        public void exibirFicha()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Nome: "+this.nome);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("CPF: "+this.cpf);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("RG: " + this.rg);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Data de Nascimento: " + this.data_nascimento);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Endereço: " + this.endereco);
            Console.WriteLine("---------------------------------------------");
        }
    }
}
