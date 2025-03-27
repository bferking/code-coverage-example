namespace Demo_App;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Howdy, {args[0]}!{Environment.NewLine}");
            Helper.AnotherMethod(args[0]);
        }
        else
        {
            Console.WriteLine($"Hello there!{Environment.NewLine}");
        }

        Console.WriteLine("Complete");
    }
}