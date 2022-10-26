using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivo___Atividade_1
{
    internal class Lista_figuras
    {
        string nome, email;
        StreamWriter sw;
        StreamReader sr;

        public Lista_figuras(string nome)
        {
            this.nome = nome;
        }

        public void AbrirArquivo()
        {
            sw = new StreamWriter("C:\\Arquivos\\Atividade_2\\"+nome+".txt", true, Encoding.UTF8);
        }

        public void ListarFiguras()
        {
            sr = new StreamReader("C:\\Arquivos\\Atividade_2\\" + nome + ".txt");
            string linha;
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        public void CadastrarFigura(string email)
        { 
            sw.WriteLine(" - " + email);
            sw.Flush();

        }

        public void fecharLista()
        {
            sw.Close();
        }


    }
}
