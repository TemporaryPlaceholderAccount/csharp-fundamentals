namespace MyFirstApplication;

public class ExerciseTemplate
{

    static public void Main()
    {
        Func<int, int, int> learner = Lamda;
        Console.WriteLine(Lamda(4, 5));

        Console.WriteLine(Switched('E'));

        Poppedcorn(30);
    }

    public static int Lamda(int current, int resistance)//lambda expression vv
    {
        int Voltage = current * resistance;

        return Voltage;
    }

    public static string Switched(char marks)
    {

        string result = marks switch
        {
            'E' => "Your grade is an E!",
            'V' => "Your grade is a V!",
            'G' => "Your grade is a G!",
            'A' => "Your grade is an A!",
            'F' => "Your grade is an F!",
            _ => "Not a valid grade"
        };

        return result;
    }

    public static void Poppedcorn(int size)
        {

        string result = size switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie snack",
            <= 32 => "Movie cup",
            <= 64 => "Movie tub",
            _ => "We don't have that size"
        };
        Console.WriteLine(result);

        }

} 