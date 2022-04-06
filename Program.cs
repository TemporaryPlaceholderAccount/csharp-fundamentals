namespace MyFirstApplication;

/*

 */
public class ExerciseTemplate
{

	/*
    
     */
	static public void Main()
	{
		Q1("EXERCISE two lab");
		Q2();
		Q3();
		Console.WriteLine(Q4());
	}

	static void Q1(string arg)
	{
		Console.WriteLine(arg.Trim());  //format = name.method

		Console.WriteLine(arg.ToLower());

		Console.WriteLine(arg.Contains("tow"));

		Console.WriteLine(arg.Length);

		Console.WriteLine(arg.IndexOf('C'));
	}

	static void Q2()
	{
		char a = '\u00B6';  //unicode characters formatted w/ a \ and ''
		Console.WriteLine(a);
	}

	static void Q3()
	{
		string b = "Jack and Jill\nwent up the hill\nto fetch a pail of water.\nJack fell down and broke his crown\nand Jill came tumbling after.";
		Console.WriteLine(b);
	}

	static string Q4()
	{
		string c = "Emilio";
		string d = "Pirates of the carribean"; //variable goes in {}. $ to start for some reason.
		string e = "popcorn";
		string f = "milkshakes";

		return $"{c} loves to go to the movies. His favorite movie is {d}, and he loves to snack on some buttery {e} and chase it down with some creamy {f} while he watches it.";
	}

} // fin