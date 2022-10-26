namespace Lógica_de_Programação___Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int segundos, minutos, hora;
            Console.WriteLine("================================");
            Console.WriteLine("Digite a Hora");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite os minutos");
            minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Digite os segundos");
            segundos = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------");

            if (hora <= 24 && hora >= 1 && minutos <= 60 && minutos >= 1 && segundos <= 60 && segundos >= 1)
            {
                Console.WriteLine("Horário Válido:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine(hora + ":" + minutos + ":" + segundos);
                Console.WriteLine("================================");
            }
            else
            {
                Console.WriteLine("Horário Inválido");
                Console.WriteLine("================================");
            }

        }
    }
}