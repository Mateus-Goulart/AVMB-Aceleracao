using System;

namespace Vetores___Atividade_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];
            int i=0, contador2 = 0, contador4 = 0, contador8 = 0;
            char V4='4', V2='2', V8='8';
            Boolean resultado;

            for(i=0; i<numeros.Length; i++)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("Digite o valor da posição: "+i);
                Console.WriteLine("================================================");
                numeros[i] = int.Parse(Console.ReadLine());
            }


            for (i=0; i<numeros.Length; i++)
            {
                string result;
                if (numeros[i] > 0)
                {
                    result = string.Join("", numeros[i]);
                    if (resultado = result.Contains(V2))
                    {
                        contador2 += 1;
                    }

                    result = string.Join("", numeros[i]);
                    if (resultado = result.Contains(V4))
                    {
                        contador4 += 1;
                    }

                    result = string.Join("", numeros[i]);
                    if (resultado = result.Contains(V8))
                    {
                        contador8 += 1;
                    }
                }

                else if (numeros[i] < 0)
                {
                    Console.WriteLine("Até Logo");
                    Console.WriteLine("------------------------------------------------");
                    Environment.Exit(1);
                }

                
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Contador de 2: "+contador2);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Contador de 4: "+contador4);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Contador de 8: "+contador8);
            Console.WriteLine("------------------------------------------------");

        }
    }
}