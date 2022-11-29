using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_5
{
    internal class Livro
    {
        public string titulo = "", autor = "", resumo = "", data_lancamento = "", editora = "";
        public double numero_paginas = 0;

        public void cadastrarLivro()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Insira o título do livro: ");
            Console.WriteLine("--------------------------");
            this.titulo = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Insira o autor: ");
            Console.WriteLine("--------------------------");
            this.autor = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Insira o resumo do Livro: ");
            Console.WriteLine("--------------------------");
            this.resumo = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Insira a data de lançamento: ");
            Console.WriteLine("--------------------------");
            this.data_lancamento = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Insira a editora do livro: ");
            Console.WriteLine("--------------------------");
            this.editora = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Insira número de páginas do livro: ");
            Console.WriteLine("--------------------------");
            this.numero_paginas = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------");
        }

        public void ConstrCadastrarLivro(string titulo, string autor, string data_lancamento, string editora, int numero_paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            Console.WriteLine("Digite o Resumo do livro a ser cadastrado");
            Console.WriteLine("--------------------------");
            this.resumo = Console.ReadLine();
            Console.WriteLine("--------------------------");
            this.data_lancamento = data_lancamento;
            this.editora = editora;
            this.numero_paginas = numero_paginas;
        }

        public void exibirLivro()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Título: " + this.titulo);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Autor: " + this.autor);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Resumo: " + this.resumo);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Editora: " + this.editora);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Data de Lançamento: " + this.data_lancamento);
            Console.WriteLine("--------------------------");
            Console.WriteLine("Número de Páginas do Livro: " + this.numero_paginas);
            Console.WriteLine("--------------------------");
        }
    }
}
