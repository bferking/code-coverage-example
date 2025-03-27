namespace Demo_App
{
    internal class Helper
    {
        public static void AnotherMethod(string name)
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
}
