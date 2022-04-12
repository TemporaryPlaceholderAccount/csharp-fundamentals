namespace MyFirstApplication;

struct Employee
{
    private int _id;//variables
    private string _name;


    public int id
    {
        get { return _id; }//id property
        set { _id = value; }
    }

    public string name
    {
        get { return _name; }//name property
        set { _name = value; }
    }

    public Employee(int id, string name)//constructer
    {
        _id = id;
        _name = name;
        Console.WriteLine($"{id} {name}");
    }

    static public void Main()
    {
        Employee myEmployee = new Employee(10, "jordans");
        Boat myBoat = new Boat(100, "blue");
    }
    


} //end of struct


public record Boat
{
    private int _size;
    private string _color;

    public int size
    {
        get { return _size; }//Not sure what you meant by boat method exactly, never coded one.
        set { _size = value; }
    }

    public string color
    {
        get { return _color; }//class discord said you were talking about the word doc and it didnt really have one
        set { _color = value; }
    }

    public Boat(int size, string name)//so this is my best guess
    {
        _size = size;
        _color = color;
        Console.WriteLine($"{size} {color}");
    }


}