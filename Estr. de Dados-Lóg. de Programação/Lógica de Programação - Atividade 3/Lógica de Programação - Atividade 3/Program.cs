namespace Lógica_de_Programação___Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { null, "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            Console.WriteLine("Digite um Número entre 1 e 12");
            int n_digitado = int.Parse(Console.ReadLine());

            Console.WriteLine("---------------------------------");

            if (n_digitado <= 12 && n_digitado >= 1)
            {
                Console.WriteLine("Mês escolhido:");
                Console.WriteLine(meses[n_digitado]);
            }
            else
            {
                Console.WriteLine("O mês digitado é invalido");
            }
        }
    }
}