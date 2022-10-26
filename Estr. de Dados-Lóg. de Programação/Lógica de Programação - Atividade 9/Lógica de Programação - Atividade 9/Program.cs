namespace Lógica_de_Programação___Atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float l1, l2, l3, soma;
            int lados_iguais = 0, lados_diferentes = 0;

            Console.WriteLine("============================");
            Console.WriteLine("Digite o primeiro lado");
            Console.WriteLine("----------------------------");
            l1 = float.Parse(Console.ReadLine());
            Console.WriteLine("============================");
            Console.WriteLine("Digite o segundo lado");
            Console.WriteLine("----------------------------");
            l2 = float.Parse(Console.ReadLine());
            Console.WriteLine("============================");
            Console.WriteLine("Digite o terceiro lado");
            Console.WriteLine("----------------------------");
            l3 = float.Parse(Console.ReadLine());
            Console.WriteLine("============================");

            soma = l1 + l2 + l3;

            if (soma > l1 && soma > l2 && soma > l3)
            {
                //*----------------------------------------------------------------------------------------        
                // Primeiro If
                //*----------------------------------------------------------------------------------------
                if (l1 == l2 || l1 == l3)
                {
                    lados_iguais = lados_iguais + 1;
                }
                if (l2 == l1 || l2 == l3)
                {
                    lados_iguais = lados_iguais + 1;
                }
                if (l3 == l1 || l3 == l2)
                {
                    lados_iguais = lados_iguais + 1;
                }
                if (l1 != l2 || l1 != l3)
                {
                    lados_diferentes = lados_diferentes + 1;
                }
                if (l2 != l1 || l2 != l3)
                {
                    lados_diferentes = lados_diferentes + 1;
                }
                if (l3 != l1 || l3 != l2)
                {
                    lados_diferentes = lados_diferentes + 1;
                }
                //*----------------------------------------------------------------------------------------        
                // Segundo If
                //*----------------------------------------------------------------------------------------
                if (lados_diferentes < lados_iguais && lados_diferentes != 0)
                {
                    Console.WriteLine("Triângulo Isoceles");
                    Console.WriteLine("----------------------------");
                }
                else if (lados_diferentes == 0)
                {
                    Console.WriteLine("Triângulo Équilatero");
                    Console.WriteLine("----------------------------");
                }
                else if (lados_iguais == 0)
                {
                    Console.WriteLine("Triângulo Escaleno");
                    Console.WriteLine("----------------------------");
                }
            }

            Console.WriteLine("Lados Diferentes" + lados_diferentes + " Lados Iguais" + lados_iguais);
        }
    }
}