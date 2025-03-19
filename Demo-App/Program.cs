namespace Demo_App;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Howdy, {args[0]}!{Environment.NewLine}");
            AnotherMethod();
        }
        else
        {
            Console.WriteLine($"Hello there!{Environment.NewLine}");
        }

        Console.WriteLine("Complete");
    }

    private static void AnotherMethod()
    {
        Console.WriteLine("Calling from another method");
    }
}