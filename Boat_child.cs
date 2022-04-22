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

public class Boat_child : Boat
{
    static private string _Guns;
    static public string Boat_Guns
    {
        get => _Guns;
        set => _Guns = value;
    }

    public Boat_child(string Color, string Materials, string Guns, int Size)
    {
        Boat_hullcolor = Color;
        Boat_materials = Materials;
        Boat_size = Size;
        Boat_Guns = Guns;
    }

    //c2
    public Boat_child(string Boat_hullcolor, string Boat_materials, string Boat_Guns)
        : this(Boat_hullcolor, Boat_materials, Boat_Guns, 10) { }

    //c3
    public Boat_child()
        : this("Black", "Wooden", "50mm guns") { }

    public static void Boat_child_method()
    {
        Console.WriteLine($"The battleship sports {Boat_Guns} .");
    }
}


class Program
{

    public static void Main()
    {
        Boat.Boat_method();
        Boat_child.Boat_child_method();
    }
}