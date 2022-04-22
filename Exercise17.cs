namespace MyFirstApplication;


public class ExerciseTemplate
{

    static public void Catch(int one, int two)
    {
        try
        {
            Console.WriteLine(one / two);
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"{ex.Message} Can't do that.");
        }


    }


    static public void Farm(string Horse)
    {
        if (Horse == null)
        {
            throw new NullReferenceException("The horse is null");
        }
        else 
        { 
        Console.WriteLine("The horse isn't null");
        }
    }
    static public void Main()
    {
        Catch(1, 0);
        Farm("Horse");
    }

}