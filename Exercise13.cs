namespace MyFirstApplication;

 interface IMovement
{
    public int Speed { get; init; }

}

public abstract class WaterBirds : IMovement//abtract class
{

    public abstract int Speed { get; init; }//implementation

    public abstract void Fly();
    public abstract void Swim();

    protected WaterBirds(int Speed)
    {
        this.Speed = Speed;
    }
}

public class WaterFowel : WaterBirds, IMovement //derived class
{
    public override int Speed { get; init; } = 35;//finally implemented speed

    //implementing abstracts methods
	public override void Fly()
	{
        Console.WriteLine($"Waterfowel can fly at speeds of up to {Speed} MPH!!");
    }

	public override void Swim()
	{
        Console.WriteLine("Waterfowel can swim to eat food and escape predators");
	}

	WaterFowel(int value)
    :base(value) { }

    static public void Main()
    {
        Fly();
        Swim();
    }
}