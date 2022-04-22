namespace MyFirstApplication;

public enum FavMov { Pirates, Cabin, Endgame };

public class enumerations//15, enums & tuples
{
        static public String Faves(FavMov movies)//enum  
        {
        string message = movies switch
        {
            FavMov.Pirates => $"My favorite movie is {FavMov.Pirates}",
            FavMov.Cabin => $"My favorite movie is {FavMov.Cabin}",
            FavMov.Endgame => $"My favorite movie is {FavMov.Endgame}",//the switch
            _ => "I've never heard of that one."
        };
            return message;
        }

   public Tuple TupleEx(int num, string movie)//i cant get the tuple return type to work the way you do
    {
        (int, string) example = (2, "Cabin");

        Console.WriteLine(example);

        int value = (int)Enum.Value;//why? the value is right there

        string movies = Enum.Value.ToString();//i give. uncle.

        Console.WriteLine(example);
    }

    static public void Main()
    {
        Faves(FavMov.Cabin);
    }

}