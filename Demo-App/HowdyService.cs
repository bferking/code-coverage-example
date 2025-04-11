namespace Demo_App;

public class HowdyService
{

    public string Howdy(string name)
    {
        return "Howdy " + name;
    }

    public string Hello(string name)
    {
        return "Hello " + name;
    }

    public string Hola(string name)
    {
        return "Hola " + name;
    }

    public string Goodbye(string name)
    {
        return "Goodbye " + name;
    }

    public string Greeting(bool isMorning, string name)
    {
        if (isMorning)
        {
            return "Good morning " + name;
        }
        else
        {
            return "Good evening " + name;
        }
    }
}