using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_2
{
    internal class Televisão
    {
        public bool estado = false;
        public double canal = 10;

        public void ligarTelevisao()
        {
            if (estado == false)
            {
                Console.WriteLine("A televisão está desligada, a ligando");
                this.estado = true;
            }
            else
            {
                Console.WriteLine("A televisão já está ligada");
            }
        }

        public void desligarTelevisao()
        {
            if (estado == true)
            {
                Console.WriteLine("A televisão está ligada, a desligando");
                this.estado = false;
            }
            else
            {
                Console.WriteLine("A televisão já está desligada");
            }
        }

        public void mudarCanal(double mudanca)
        {
            if (estado == true)
            {
                Console.WriteLine("Mudando de Canal");
                Console.WriteLine("---------------------------------------");
                this.canal = mudanca;
                Console.WriteLine("Canal Atual: "+this.canal);
            }
            else
            {
                Console.WriteLine("A televisão está desligada, lige-a primeiro");
            }
        }
    }
}
