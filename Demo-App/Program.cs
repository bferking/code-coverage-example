namespace Demo_App;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Howdy, {args[0]}!\n");
            AnotherMethod();
        }
        else
        {
            Console.WriteLine("Hello there!\n");
        }

        Console.WriteLine("Complete");
    }

    private static void AnotherMethod()
    {
        Console.WriteLine("Calling from another method");
    }
}