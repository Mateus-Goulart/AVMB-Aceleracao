namespace Vetores___Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int i, p=1, contador = 0;

            for (i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("Digite o número da posição: "+i);
                Console.WriteLine("===================================================");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("---------------------------------------------------");
            }

            for (i=0; i<numeros.Length; i++)
            {
                for (p=1; p<numeros[i]; p++)
                {
                    if (numeros[i]%p == 0)
                        contador++;
                }

                if (contador == 2) 
                { 
                    Console.WriteLine(" O número "+ numeros[i]+" da posição "+i+" é um número primo");
                    Console.WriteLine("---------------------------------------------------");
                }
            }


        }
    }
}