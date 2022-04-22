namespace MyFirstApplication;

public class Horse
{

    //auto props?
    public string Horse_haircolor { get; set;}
    public string Horse_gender { get; set;}
    public int Horse_age { get; set;}

    //constructor 1
    public Horse(string Hair, string Gender, int Age)
    {
        Horse_haircolor = Hair;
        Horse_gender = Gender;
        Horse_age = Age;
    }

    //constructor 2
    public Horse(string Horse_haircolor, string Horse_gender)
        : this(Horse_haircolor, Horse_gender, 10) { }

    //c3
    public Horse()
        : this("Black", "Male") { }

    //method
    public static void Horse_method()
    {
        Console.WriteLine("The horse gallops into the sunset");
    }
}

class Program
{

    public static void Main()
    {
        Horse.Horse_method();
    }
}