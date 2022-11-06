namespace Matriz___Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int[,] numero = new int[4, 4];
            int i, p;

            for (i=0; i<4; i++)
            {
                for (p=0; p<4; p++)
                {
                    numero[i,p]= gerador.Next();
                }
            }

            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("Gerador de Números Aleatórios");
            Console.WriteLine("-----------------------------------------------------------------");
            for (i=0; i<4; i++)
            {
                Console.WriteLine("{ "+numero[i,0]+" ,"+numero[i,1]+" ,"+ numero[i,2]+" ,"+numero[i,3]+" }");
            }

        }
    }
}