namespace Demo_App;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Howdy, {args[0]}!{Environment.NewLine}");
            AnotherMethod(args[0]);
        }
        else
        {
            Console.WriteLine($"Hello there!{Environment.NewLine}");
        }

        Console.WriteLine("Complete");
    }

    private static void AnotherMethod(string name)
    {
        if (name.ToLower().Equals("test"))
        {
            Console.WriteLine("Calling from another method");
        } else if (name.ToLower().Equals("New Branch"))
        {
            Console.WriteLine("This is a new uncovered area");
        }
    }
}