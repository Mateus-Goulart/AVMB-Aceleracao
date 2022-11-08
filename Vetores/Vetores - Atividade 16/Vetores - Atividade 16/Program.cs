using System;
using System.Collections.Generic;

namespace Vetores___Atividade_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] X = new int[10] {1,2,3,4,5,6,7,8,9,10};
            int[] Y = new int[10] {1,2,3,4,5,6,7,8,9,20};
            List<int> vetor1 = new List<int>();
            List<int> vetor2 = new List<int>();
            List<int> vetor3 = new List<int>();

            int i;

            for(i=0; i<10; i++)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite o valor presente na posição: "+i+" do Array X");
                Console.WriteLine("====================================================");
                X[i] = int.Parse(Console.ReadLine());
            }

            for (i=0; i<10; i++)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite o valor presente na posição: "+i+" do Array Y");
                Console.WriteLine("====================================================");
                Y[i] = int.Parse(Console.ReadLine());
            }


            for (i=0; i<X.Length; i++)
            {
                vetor1.Add(X[i]);
            }
            for (i=0; i<Y.Length; i++)
            {
                vetor1.Add(Y[i]);
            }

            Console.WriteLine("====================================================");
            Console.WriteLine("União de X e Y:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Vetor 1 :" + string.Join(",", vetor1));

            for (i=0; i<10; i++)
            {
               if (X[i].Equals(Y[i]))
               {
                    vetor2.Add(X[i]);
               }
               else
               {
                    vetor3.Add(X[i]);
                    vetor3.Add(Y[i]);
               }
            }


            Console.WriteLine("====================================================");
            Console.WriteLine("A interceção de X e Y:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Vetor 2: "+String.Join(",",vetor2));
            Console.WriteLine("====================================================");
            Console.WriteLine("A diferença de X e Y:");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Vetor 3: "+String.Join(",", vetor3));
            Console.WriteLine("====================================================");


        }
    }
}