namespace Exercise6;


public class Exercise6
/*The question stated "showsize", while I'm pretty sure that was a 
          mistype I didn't want to take any chances*/
    {
    public int _showSize; //variable declaration for constructors

    public string _shoeType;//this is 6-2? i think? i am very confused

    public int shoeSize 
    {
        get {return _showSize;}
        set { _showSize = value; } //working gear of the constructor
    }

    public string shoeType
    {
        get { return _shoeType; } //gets and sets the value, hard to put in words
        set { _shoeType = value; }
    }

    public Exercise6(int showSize, string shoeType) //where I set the stuff equal to itself
    {
        _showSize = showSize;
        _shoeType = shoeType;
        Console.WriteLine($"{showSize} ,{shoeType}"); //and write it out unto the cammand prompt
    }

    static public void Main() //main, where the constructor gets called
    {
        Exercise6 myExercise6 = new Exercise6(10, "jordans"); //all of that, for a writeline?

        Exercise6.TryOn theShoe = myExercise6.TryOnShoe();
        theShoe($"I tried on a {myExercise6.shoeType} shoe that was my size, {myExercise6.shoeSize}");
    }

    public delegate void TryOn(string a1);

    public void TryOnShoe(string b2)
    {                           /*I'm sorry, I dont understand. I usually at least get the idea
                                 but this time the concepts are kinda going over my head*/
        Console.WriteLine();
    }
}