using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivo___Atividade_1
{
    internal class Lista_email
    {
        string nome, email;
        StreamWriter sw;
        StreamReader sr;

        public Lista_email(string nome)
        {
            this.nome = nome;
        }

        public void CriarLista() 
        {
            sw = new StreamWriter("C:\\Arquivos\\Atividade_1\\" + nome +".txt", true, Encoding.UTF8);
        }

        public void ListarConteudo()
        {
            sr = new StreamReader("C:\\Arquivos\\Atividade_1\\" + nome + ".txt");
            string linha;
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();
        }

        public void CadastrarEmail(string email)
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
