namespace Jogo_da_Velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] matriz = new String[3, 3];
            int i, p;

            matriz[0, 0] = " "; matriz[0, 1] = " "; matriz[0, 2] = " ";
            matriz[1, 0] = " "; matriz[1, 1] = " "; matriz[1, 2] = " ";
            matriz[2, 0] = " "; matriz[2, 1] = " "; matriz[2, 2] = " ";


            Console.WriteLine("=================================");
            Console.WriteLine("Bem-Vindo ao Jogo da Velha");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Se divirta");
            Console.WriteLine("=================================");

            while (true)
            {

                Console.WriteLine(" 0 - " + matriz[0, 0] + " | " + matriz[0, 1] + " | " + matriz[0, 2]);
                Console.WriteLine("     __________");
                Console.WriteLine(" 1 - " + matriz[1, 0] + " | " + matriz[1, 1] + " | " + matriz[1, 2]);
                Console.WriteLine("     __________");
                Console.WriteLine(" 2 - " + matriz[2, 0] + " | " + matriz[2, 1] + " | " + matriz[2, 2]);
                Console.WriteLine("     0   1   2 ");


                Console.WriteLine("=================================");
                Console.WriteLine("Jogador do X");
                Console.WriteLine("=================================");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite a Linha Para Colocar o X");
                Console.WriteLine("---------------------------------");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite a Coluna Para Colocar o X");
                Console.WriteLine("---------------------------------");
                p = int.Parse(Console.ReadLine());
                matriz[i, p] = "X";


                if ((matriz[0, 0] == "X" && matriz[0, 1] == "X" && matriz[0, 2] == "X") ||
                   (matriz[1, 0] == "X" && matriz[1, 1] == "X" && matriz[1, 2] == "X") ||
                   (matriz[2, 0] == "X" && matriz[2, 1] == "X" && matriz[2, 2] == "X") ||
                   (matriz[0, 0] == "X" && matriz[1, 0] == "X" && matriz[2, 0] == "X") ||
                   (matriz[0, 1] == "X" && matriz[1, 1] == "X" && matriz[2, 1] == "X") ||
                   (matriz[0, 2] == "X" && matriz[1, 2] == "X" && matriz[2, 2] == "X") ||
                   (matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X") ||
                   (matriz[0, 2] == "X" && matriz[1, 1] == "X" && matriz[2, 0] == "X"))
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("X Ganhou!");
                    Console.WriteLine("---------------------------------");
                    break;

                }

                else if ((matriz[0, 0] == "O" && matriz[0, 1] == "O" && matriz[0, 2] == "O") ||
                   (matriz[1, 0] == "O" && matriz[1, 1] == "O" && matriz[1, 2] == "O") ||
                   (matriz[2, 0] == "O" && matriz[2, 1] == "O" && matriz[2, 2] == "O") ||
                   (matriz[0, 0] == "O" && matriz[1, 0] == "O" && matriz[2, 0] == "O") ||
                   (matriz[0, 1] == "O" && matriz[1, 1] == "O" && matriz[2, 1] == "O") ||
                   (matriz[0, 2] == "O" && matriz[1, 2] == "O" && matriz[2, 2] == "O") ||
                   (matriz[0, 0] == "O" && matriz[1, 1] == "O" && matriz[2, 2] == "O") ||
                   (matriz[0, 2] == "O" && matriz[1, 1] == "O" && matriz[2, 0] == "O"))
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("O Ganhou!");
                    Console.WriteLine("---------------------------------");
                    break;
                }
                else if ((matriz[0, 0] == " " && matriz[0, 1] == " " && matriz[0, 2] == " ") ||
                   (matriz[1, 0] == " " && matriz[1, 1] == " " && matriz[1, 2] == " ") ||
                   (matriz[2, 0] == " " && matriz[2, 1] == " " && matriz[2, 2] == " ") ||
                   (matriz[0, 0] == " " && matriz[1, 0] == " " && matriz[2, 0] == " ") ||
                   (matriz[0, 1] == " " && matriz[1, 1] == " " && matriz[2, 1] == " ") ||
                   (matriz[0, 2] == " " && matriz[1, 2] == " " && matriz[2, 2] == " ") ||
                   (matriz[0, 0] == " " && matriz[1, 1] == " " && matriz[2, 2] == " ") ||
                   (matriz[0, 2] == " " && matriz[1, 1] == " " && matriz[2, 0] == " "))
                {

                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Ninguém venceu deu velha");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

                Console.WriteLine(" 0 - " + matriz[0, 0] + " | " + matriz[0, 1] + " | " + matriz[0, 2]);
                Console.WriteLine("     __________");
                Console.WriteLine(" 1 - " + matriz[1, 0] + " | " + matriz[1, 1] + " | " + matriz[1, 2]);
                Console.WriteLine("     __________");
                Console.WriteLine(" 2 - " + matriz[2, 0] + " | " + matriz[2, 1] + " | " + matriz[2, 2]);
                Console.WriteLine("     0   1   2 ");

                Console.WriteLine("=================================");
                Console.WriteLine("Jogador do O");
                Console.WriteLine("=================================");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite a Linha Para Colocar o O");
                Console.WriteLine("---------------------------------");
                i = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite a Coluna Para Colocar o O");
                Console.WriteLine("---------------------------------");
                p = int.Parse(Console.ReadLine());
                matriz[i, p] = "O";


                if ((matriz[0, 0] == "X" && matriz[0, 1] == "X" && matriz[0, 2] == "X") ||
                   (matriz[1, 0] == "X" && matriz[1, 1] == "X" && matriz[1, 2] == "X") ||
                   (matriz[2, 0] == "X" && matriz[2, 1] == "X" && matriz[2, 2] == "X") ||
                   (matriz[0, 0] == "X" && matriz[1, 0] == "X" && matriz[2, 0] == "X") ||
                   (matriz[0, 1] == "X" && matriz[1, 1] == "X" && matriz[2, 1] == "X") ||
                   (matriz[0, 2] == "X" && matriz[1, 2] == "X" && matriz[2, 2] == "X") ||
                   (matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X") ||
                   (matriz[0, 2] == "X" && matriz[1, 1] == "X" && matriz[2, 0] == "X"))
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("X Ganhou!");
                    Console.WriteLine("---------------------------------");
                    break;

                }

                else if ((matriz[0, 0] == "O" && matriz[0, 1] == "O" && matriz[0, 2] == "O") ||
                   (matriz[1, 0] == "O" && matriz[1, 1] == "O" && matriz[1, 2] == "O") ||
                   (matriz[2, 0] == "O" && matriz[2, 1] == "O" && matriz[2, 2] == "O") ||
                   (matriz[0, 0] == "O" && matriz[1, 0] == "O" && matriz[2, 0] == "O") ||
                   (matriz[0, 1] == "O" && matriz[1, 1] == "O" && matriz[2, 1] == "O") ||
                   (matriz[0, 2] == "O" && matriz[1, 2] == "O" && matriz[2, 2] == "O") ||
                   (matriz[0, 0] == "O" && matriz[1, 1] == "O" && matriz[2, 2] == "O") ||
                   (matriz[0, 2] == "O" && matriz[1, 1] == "O" && matriz[2, 0] == "O"))
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("O Ganhou!");
                    Console.WriteLine("---------------------------------");
                    break;
                }
                else if ((matriz[0, 0] == " " && matriz[0, 1] == " " && matriz[0, 2] == " ") ||
                   (matriz[1, 0] == " " && matriz[1, 1] == " " && matriz[1, 2] == " ") ||
                   (matriz[2, 0] == " " && matriz[2, 1] == " " && matriz[2, 2] == " ") ||
                   (matriz[0, 0] == " " && matriz[1, 0] == " " && matriz[2, 0] == " ") ||
                   (matriz[0, 1] == " " && matriz[1, 1] == " " && matriz[2, 1] == " ") ||
                   (matriz[0, 2] == " " && matriz[1, 2] == " " && matriz[2, 2] == " ") ||
                   (matriz[0, 0] == " " && matriz[1, 1] == " " && matriz[2, 2] == " ") ||
                   (matriz[0, 2] == " " && matriz[1, 1] == " " && matriz[2, 0] == " "))
                {

                }
                else
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Ninguém venceu deu velha");
                    Console.WriteLine("---------------------------------");
                    continue;
                }

            }
        }
    }
}