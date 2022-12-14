using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_11
{
    internal class PessoaJuridica : Pessoa
    {
        public string cnpj;

        public void cadastrarPJ()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Nome da Pessoa Juridica:");
            Console.WriteLine("=============================================");
            nome = Console.ReadLine();
            Console.WriteLine("=============================================");
            Console.WriteLine("Digite o CNPJ a ser cadastrado:");
            Console.WriteLine("=============================================");
            cnpj = Console.ReadLine() ;
        }
    }
}
