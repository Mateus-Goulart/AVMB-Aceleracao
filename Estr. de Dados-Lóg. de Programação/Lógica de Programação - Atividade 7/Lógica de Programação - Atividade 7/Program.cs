namespace Lógica_de_Programação___Atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mf, mb, me;
            float renda = 0;

            Console.WriteLine("=====================================================================");
            Console.WriteLine("Diga o número de membros da fámilia.");
            Console.WriteLine("---------------------------------------------------------------------");
            mf = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Quantos membros da fámilia NÃO trabalham.");
            Console.WriteLine("---------------------------------------------------------------------");
            mb = int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================================================");

            me = mf - mb;

            for (int i = 1; i <= me; i++)
            {
                Console.WriteLine("Insira o valor ganho do membro " + i);
                Console.WriteLine("---------------------------------------------------------------------");
                renda += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("=====================================================================");
            Console.WriteLine("O valor toral: R$ " + renda);
            renda = renda / mf;
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Renda por cabeça: R$ " + renda + " por Individuo de um total de " + mf);
            Console.WriteLine("=====================================================================");
        }
    }
}