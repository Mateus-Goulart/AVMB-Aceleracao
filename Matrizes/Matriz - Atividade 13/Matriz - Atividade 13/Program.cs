namespace Matriz___Atividade_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[5, 5];

            int i=0, p=0, soma = 0;


            for (i=0; i<5; i++)
            {
                for (p=0; p<5; p++)
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(" Digite o valor da Coordenada: ["+i+"]["+p+"]");
                    Console.WriteLine("-------------------------------------------------------");
                    numeros[p, i] = int.Parse(Console.ReadLine());

                }
            }



            for (i=0; i<5; i++)
            {
                for (p=0; p<5; p++)
                {
                    if (numeros[i, p] == numeros[0,0] || numeros[i,p] == numeros[1,1] || numeros[i, p] == numeros[2,2] || numeros[i, p] == numeros[3,3] || numeros[i, p] == numeros[4,4])
                    {
                        soma = numeros[i,p];
                        
                    }
                }
            }
            Console.WriteLine("=======================================================");
            Console.WriteLine("Valor da soma dos valores da Diagonal Principal: "+soma);
            Console.WriteLine("=======================================================");

            soma = 0;

            for (i=0; i<5; i++)
            {
                for (p=0; p<5; p++)
                {
                    if (numeros[i, p] == numeros[0, 4] || numeros[i, p] == numeros[1, 3] || numeros[i, p] == numeros[2, 2] || numeros[i, p] == numeros[3, 1] || numeros[i, p] == numeros[4, 0])
                    {
                        soma = numeros[i, p];
                        
                    }

                }
            }
            Console.WriteLine("=======================================================");
            Console.WriteLine("Valor da soma dos valores da Diagonal Secundária: "+soma);
            Console.WriteLine("=======================================================");
        }
    }
}