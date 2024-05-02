// Entendendo a construir uma fila

using Fila_Aula;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Fila!");

        FilaPessoa filaPessoa = new ();

        /*
         * Pessoa p1 = new ("Odair");
         * filaPessoa.Push (p1);
         * filaPessoa.Push(new Pessoa("Odair"));
        */

        filaPessoa.Push(new("Odair"));
        filaPessoa.Push(new("Alexa"));
        filaPessoa.Push(new("Tio Paulo"));

        filaPessoa.Pop();
    }
}