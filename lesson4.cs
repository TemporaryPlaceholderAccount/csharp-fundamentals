namespace MyFirstApplication;

public class ExerciseTemplate
{

   
    static public void Main()
    {
        Four1("art", "art");
        Console.WriteLine(Four2('E'));
        Four3();
    }

    static void Four1(string S1, string S2)
    {
        if (S1 == S2)//the strings i used were art and art
        {
            Console.WriteLine("These strings are equal");
        }

        else
        {
            Console.WriteLine("They are not equal");
        }

    }

    static string Four2(char C1)
    {

        switch (C1)//Works fine. 'E' :)
        {
            case 'E':
                return "Your grade is an E! Excellent work! :)";

            case 'V':
                return "Your grade is an V! Very good job! :]";

            case 'G':
                return "Your grade is an G! Good job! :|";

            case 'A':
                return "Your grade is an A! Lets try a little harder next time! :/";

            case 'F':
                return "Your grade is an F! :(";

            default:
                return "Not a valid grade";
        }
    }

    static void Four3()
    {
        for (int i = 0; i < 33; i++)
        {
            if ((i % 3) == 0)
                Console.WriteLine(i);
        }
    }
} // end class
