namespace MyFirstApplication;


public class ExerciseTemplate
{
    /*
 main, where all the methods are called. 
 */
    static public void Main()
    {
        int whale = three1(4);
        Console.WriteLine(whale);
        three2();
        three3(69, 420);
        three4(true, false);
    }

    static int three1(int argu)
        {
        int a_3 = 15;
        int b_3 = 456;
        int c_3 = 23;
        int d_3 = 89; 
        int e_3 = 245;

        Console.WriteLine(a_3 % argu);
        Console.WriteLine(b_3 % argu);
        Console.WriteLine(c_3 % argu);
        Console.WriteLine(d_3 % argu);

        int f_3 = e_3 % argu;//passed in arguments <--

        return f_3;
        }

    static void three2()
    {
        Console.WriteLine(10+32*12/3);
        Console.WriteLine((10 + 32) * 12 / 3);//that was a nice break
        Console.WriteLine((10 + 32 * 12) / 3);
    }

    static void three3(short T1, short T2)
    {
        T1 += T2;
        Console.WriteLine(T1);

        T1 /= T2;
        Console.WriteLine(T1); //shortcuts

        T1 *= T2;
        Console.WriteLine(T1);

        T1 %= T2;
        Console.WriteLine(T1);
    }

    static void three4(bool B1, bool B2)/*So there isn't really a direction to take this that I understood, or an indication of what operater to
       use and why, since the truth will always prevail, I will be using the operands that return the whole statement as true*/
    {
        Console.WriteLine("Argument 2 is false, Argument 1 is true");
        Console.WriteLine(B2|B1);
        //Or. True
        Console.WriteLine("Argument 2 is false, Argument 1 is also false");
        Console.WriteLine(B2 &! B1);
        //snf, fslr
        Console.WriteLine("Argument 2 is true, Argument 1 is true");
        Console.WriteLine(B2 & B1);
        //and, false but i dont understand why
        Console.WriteLine("Argument 2 is true, Argument 1 is false");
        Console.WriteLine(B2 || B1);
        //or, true

    }//I did not understand how to input different truth values, or if i even needed to. Any elaboration apprieciated.
} // end class
