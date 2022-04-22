namespace MyFirstApplication;

public class Horse
{
   
   static public void StrinEx()
    {
        List<string> HorseObjects = new List<string>();//string
        HorseObjects.Add("Horse_haircolor");
        HorseObjects.Add("Horse_gender");
        HorseObjects.Add("Horse_haircolor");

        foreach (string items in HorseObjects)//loop that prints 
        { 
            Console.WriteLine(items);
        }
    }

    public string Horse_haircolor { get; set; }
    public string Horse_gender { get; set; }
    public int Horse_age { get; set; }

    //constructor 1
    public Horse(string Hair, string Gender, int Age)//largely unsure as to why they are here, but 
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


   static public void DicEx()
    { 
     Dictionary<int, string> HorseObjects = new Dictionary<int, string>();
        HorseObjects.Add(1, "Pirates of the Carribean");
        HorseObjects.Add(2, "Cabin in the woods");
        HorseObjects.Add(3, "Avernger's Endgame");

        string value;
        if (HorseObjects.TryGetValue(2, out value))
        { 
            Console.WriteLine($"For key 2 we have {value}");
        }
        foreach (KeyValuePair<int, string> item in HorseObjects)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }


static public void Main()
    {
        StrinEx();

        DicEx();
    }

}