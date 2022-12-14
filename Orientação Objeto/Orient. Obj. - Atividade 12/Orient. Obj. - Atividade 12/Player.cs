using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_12
{
    internal class PersonagemJogavel : Personagem
    {
        public void criarPersonagem()
        {
            Console.WriteLine("Nomeie o seu personagem:");
            Console.WriteLine("------------------------");
            nome = Console.ReadLine();
            Console.WriteLine("------------------------");
        }

        public void andarJ()
        {
            Console.WriteLine("Digite a Coordenada X");
            Console.WriteLine("----------------------");
            posicaoX = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Coordenada Y");
            Console.WriteLine("----------------------");
            posicaoY = int.Parse(Console.ReadLine());
        }

        public void checarStatus()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("Coordenadas X e Y: " + posicaoX + " " + posicaoY);
            Console.WriteLine("------------------------");
        }

        
    }
}
