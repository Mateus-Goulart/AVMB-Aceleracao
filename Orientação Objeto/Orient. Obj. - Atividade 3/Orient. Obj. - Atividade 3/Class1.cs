using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orient._Obj.___Atividade_3
{
    internal class Personagem
    {
        public string nome = "";
        public int posição = 0;
        public string[] itens = new string[20];

        public void mudarPosição()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Qual a posição desejada?");
            Console.WriteLine("----------------------------------");
            posição = int.Parse(Console.ReadLine());
            Console.WriteLine("==================================");
        }

        public void coletarItens(int ItensColetados)
        {
            Console.WriteLine("=================================");
            for (int i=0; i<ItensColetados; i++)
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
            for (int i=0; i<itens.Length; i++)
            {
                Console.WriteLine("Slot "+i+": " + itens[i]);
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("=================================");
        }

        public void andar()
        {
            while (true)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("Para onde deseja ir?");
                Console.WriteLine("----------------------------------");
                Console.Write("1) Para a Frete. \n 2) Para a Esquerda. \n 3) Para Direita. \n 4) Para Trás. \n 5) Deseja parar. \n");
                int op = int.Parse(Console.ReadLine());
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
