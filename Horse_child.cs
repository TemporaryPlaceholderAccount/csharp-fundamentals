namespace MyFirstApplication;

public class Horse
{

    //auto props?
    public string Horse_haircolor { get; set; }
    public string Horse_gender { get; set; }
    public int Horse_age { get; set; }

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

public class Horse_child : Horse
{
   static public int Horse_speed { get; set; }

    public Horse_child(string Hair, string Gender, int Age, int speed)
    {
        Horse_haircolor = Hair;
        Horse_gender = Gender;
        Horse_age = Age;
        Horse_speed = speed;
    }

    //c2
    public Horse_child(string Horse_haircolor, string Horse_gender, int Horse_speed)
        : this(Horse_haircolor, Horse_gender, Horse_speed, 10) { }

    //c3
    public Horse_child()
        : this("Black", "Male", 50) { }

    public static void Horse_child_method()
        {
        Console.WriteLine($"The race horse can gallop at {Horse_speed} mph.");
        }
}
class Program
{

    public static void Main()
    {
        Horse.Horse_method();
        Horse_child.Horse_child_method();
    }
}


