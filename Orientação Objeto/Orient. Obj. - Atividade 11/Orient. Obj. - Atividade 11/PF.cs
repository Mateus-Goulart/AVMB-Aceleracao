using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_11
{
    internal class PessoaFisica : Pessoa
    {
        public string cpf;

        public void cadastrarPF()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Nome da Pessoa Fisica:");
            Console.WriteLine("=============================================");
            nome = Console.ReadLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("Digite o CPF a ser cadastrado:");
            Console.WriteLine("=============================================");
            cpf = Console.ReadLine();
        }
    }
}
