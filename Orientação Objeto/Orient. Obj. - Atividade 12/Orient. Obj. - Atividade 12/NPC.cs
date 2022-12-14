using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_12
{
    internal class NPC : Personagem
    {

        Random Gerador = new Random();

        public void criarNPC()
        {
            Console.WriteLine("Nomeie o seu NPC:");
            Console.WriteLine("------------------------");
            nome = Console.ReadLine();
            Console.WriteLine("------------------------");
        }

        public void andar()
        {
            posicaoX = Gerador.Next(1,10);
            posicaoY = Gerador.Next(1, 10);
        }

        public void checarStatus()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("HP: "+hp);
            Console.WriteLine("Coordenadas X e Y: "+posicaoX+" "+posicaoY);
            Console.WriteLine("------------------------");
        }

        public void criarRapido(string nome)
        {
            nome = nome;
        }
    }
}
