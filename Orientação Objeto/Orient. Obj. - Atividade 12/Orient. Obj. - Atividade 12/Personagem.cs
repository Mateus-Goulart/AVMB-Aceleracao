using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_12
{
    internal class Personagem
    {
        protected string nome = "";
        protected int posicaoX = 0;
        protected int posicaoY = 0;
        protected int hp = 100;

        public void atacar(NPC oponente)
        {
            Console.WriteLine("Você Ataca");
            this.hp = -1 ;
        }
    }
}
