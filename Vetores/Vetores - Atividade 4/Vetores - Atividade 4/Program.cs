namespace Vetores___Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros1 = new int[10] {5,7,9,12,30,40,25,3,10,35};
            int[] numeros2 = new int[10] { 5, 7, 9, 12, 30, 40, 25, 3, 10, 35 };
            int[] resultantes = new int[10];

            Console.WriteLine("Vetor 1: { " + numeros1[0]+ " ," + numeros1[1] + " ," + numeros1[2]+ " ," + numeros1[3]+ " ," + numeros1[4]+ " ," + numeros1[5]+ " ," + numeros1[6]+ " ," + numeros1[7] + " ," + numeros1[8]+" ,"+ numeros1[9] +"}" );
            Console.WriteLine("Vetor 2: { " + numeros2[0] + " ," + numeros2[1] + " ," + numeros2[2] + " ," + numeros2[3] + " ," + numeros2[4] + " ," + numeros2[5] + " ," + numeros2[6] + " ," + numeros2[7] + " ," + numeros2[8] + " ," + numeros2[9] + "}");


            Console.WriteLine("============================================================");
            Console.WriteLine("Vetor - Resultante");
            Console.WriteLine("------------------------------------------------------------");
            for (int i=0; i<10; i++)
            {
                resultantes[i] = numeros1[i] * numeros2[i];
                Console.WriteLine("índice: "+i+" Valor: " + resultantes[i]);
            }
        }
    }
}