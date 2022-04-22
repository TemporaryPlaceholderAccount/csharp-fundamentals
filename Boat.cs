namespace MyFirstApplication;

public class Boat
{
    private string _color;
    private string _materials;
    private int _size;

    //Expression Body Definition Properties
    public string Boat_hullcolor
    {
        get => _color;
        set => _color = value;
    }

    public string Boat_materials
    {
        get => _materials;
        set => _materials = value;
    }

    public int Boat_size
    {
        get => _size;
        set => _size = value;
    }

    //constructor 1
    public Boat(string Color, string materials, int size)
    {
        Boat_hullcolor = Color;
        Boat_materials = materials;
        Boat_size = size;
    }

    //constructor 2
    public Boat(string Boat_hullcolor, string Boat_materials)
        : this(Boat_hullcolor, Boat_materials, 10) { }

    //c3
    public Boat()
        : this("Black", "Wooden") { }

    //method
    public static void Boat_method()
    {
        Console.WriteLine("The Boat sails the seas");
    }
}

class Program
{

    public static void Main()
    {
        Boat.Boat_method();
    }
}