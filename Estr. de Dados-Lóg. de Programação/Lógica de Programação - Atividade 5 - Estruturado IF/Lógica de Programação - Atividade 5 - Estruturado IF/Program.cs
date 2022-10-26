namespace Lógica_de_Programação___Atividade_5___Estruturado_IF;
class Program
{
    static void Main(string[] args)
    {
        String letra;
        Console.WriteLine("==================================");
        Console.WriteLine("Digite uma letra");
        Console.WriteLine("----------------------------------");
        letra = Console.ReadLine();
        Console.WriteLine("==================================");

        if (letra == "a" || letra == "A" || letra == "e" || letra == "E" || letra == "i" || letra == "I" || letra == "o" || letra == "O" || letra == "u" || letra == "U")
        {
            Console.WriteLine("A letra " + letra + " é uma vogal.");
        }
        else
        {
            Console.WriteLine("A letra " + letra + " é uma consoante.");
        }
    }
}
