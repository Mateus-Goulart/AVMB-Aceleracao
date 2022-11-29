using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_6
{
    internal class Aluno
    {
        public int matricula=0, rg=0;
        public string nome="", cpf="", data_nascimento = "";
        public string[] materias = new string[10];
        
        public void cadastrarAluno()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Inserir Matricula:");
            Console.WriteLine("-----------------------------------------");
            this.matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Inserir Nome do Aluno:");
            Console.WriteLine("-----------------------------------------");
            this.nome = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Inserir CPF do Aluno:");
            Console.WriteLine("-----------------------------------------");
            this.cpf = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Inserir RG do Aluno:");
            Console.WriteLine("-----------------------------------------");
            this.rg = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Inserir Data de Nascimento:");
            Console.WriteLine("-----------------------------------------");
            this.data_nascimento = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Quantas Materias? (Máximo 10)");
            Console.WriteLine("-----------------------------------------");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------");
            cadastarMaterias(numero);
        }

        private void cadastarMaterias(int materiasAdd)
        {
            for (int i=0; i<materiasAdd; i++)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Qual mateia deseja adicionar ao Cadastro? ( "+(i+1)+" de "+materiasAdd+" )");
                Console.WriteLine("-----------------------------------------");
                this.materias[i] = Console.ReadLine();
                Console.WriteLine("-----------------------------------------");
            }

        }

        public void exibirAluno()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Matricula: "+this.matricula);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Nome: "+this.nome);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("CPF: " + this.cpf);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("RG: "+this.rg);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Data de Nacimento: "+this.data_nascimento);
            Console.WriteLine("-----------------------------------------");
            for (int i=0; i<materias.Length; i++)
            {
                Console.WriteLine("Materia " + (i + 1) + ": " + materias[i]);
            }
            Console.WriteLine("-----------------------------------------");
        }
    }

}
