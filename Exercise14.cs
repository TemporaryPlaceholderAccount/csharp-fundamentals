namespace MyFirstApplication;


public class Arrayss
{
    //d1 array
   static public void A1()
    { 
    string[] Icecream_Flavors = {"Vanilla", "Chocolote", "Strawberry", "neopolitan"};//array

        foreach (var flavors in Icecream_Flavors)//loop prints array
        { 
        Console.WriteLine(flavors);
        }
    }

    static public void A2()
    {
        int[,] KC = new int[2, 2]; //Away team is listed first
        KC[34, 20] = 0;
        KC[23, 20] = 0;
        KC[20, 34] = 0;
        KC[26, 10] = 0;
        KC[32, 40] = 0;
        KC[26, 17] = 0;
        KC[43, 16] = 0;
        KC[35, 9] = 0;
        KC[33, 31] = 0;
        KC[35, 31] = 0;
        KC[27, 24] = 0;
        KC[22, 16] = 0;
        KC[33, 27] = 0;
        KC[32, 29] = 0;

             foreach (var item in KC) //loop prints the array
             {
                 Console.WriteLine(item);
             }
    }


static public void Main()
    {
        A1();
        A2();
    }

} 