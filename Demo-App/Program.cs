namespace Demo_App;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            Console.WriteLine($"Hello, {args[0]}!\n");
        }
        else
        {
            Console.WriteLine("Hello there!\n");
        }
    }
}