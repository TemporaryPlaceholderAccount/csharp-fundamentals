namespace MyFirstApplication;

public class Exercise8
{
    const int Foot = 12;//constant

    static void Ruler(int feet)
    {
        Console.WriteLine(Foot * feet);//multiplication
    }

    static void Area(int length, int width)//8-2
    {
        Console.WriteLine(width * length);
    }

   static public void Main()
    {
        Ruler();
        //tested with three
        Area();
        //tested with 5 & 6 for 30
    }

} 