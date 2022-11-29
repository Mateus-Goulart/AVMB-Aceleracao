using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_7
{
    internal class Personagem
    {
        public string nome = "";
        public int posicao = 0;
        public string[] itens = new string[20];

        public void mudarPosição(int posicao)
        {
            this.posicao = posicao;
        }

        public void coletarItens(int ItensColetados)
        {
            Console.WriteLine("=================================");
            for (int i = 0; i < ItensColetados; i++)
            {
                Console.WriteLine("Qual Iten foi coletado?");
                Console.WriteLine("----------------------------------");
                itens[i] = Console.ReadLine();
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("=================================");

        }

        public void exibirInventario()
        {
            Console.WriteLine("=================================");
            for (int i = 0; i < itens.Length; i++)
            {
                Console.WriteLine("Slot " + i + ": " + itens[i]);
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("=================================");
        }

        public void andar(int direcao)
        {
            while (true)
            {
                int op = direcao;
                switch (op)
                {
                    case 1:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Você andou para Frente.");
                        continue;
                    case 2:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Você andou para Esquerda.");
                        break;
                    case 3:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Você andou para Direita.");
                        continue;
                    case 4:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Você andou para Para Trás.");
                        continue;
                    case 5:
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Você Parou.");
                        break;
                    default:
                        continue;
                }
            }
        }
    }
}
