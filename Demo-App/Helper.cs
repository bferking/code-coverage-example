namespace Demo_App;

public class Helper
{
    public void AnotherMethod(string name)
    {
        if (name.ToLower().Equals("test"))
        {
            Console.WriteLine("Calling from another method");
        }
        else if (name.ToLower().Equals("New Branch"))
        {
            Console.WriteLine("This is a new uncovered area.");
        }
    }
}