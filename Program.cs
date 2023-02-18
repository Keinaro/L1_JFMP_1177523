using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola Mundo, soy George");

        Console.WriteLine("Hola Mundo");
        Console.WriteLine("soy George");

        Console.Write("Hola Mundo");
        Console.Write(" soy George\n");

        Console.WriteLine("\nIngrese su nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Hola Mundo ");
        Console.Write("soy " + nombre);
        Console.ReadKey();
    }
}
