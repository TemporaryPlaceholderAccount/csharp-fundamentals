namespace Exercise1;

/*
 class conversion(?)
 */
public class Exercise1
{

	/*
    method = funtion. Method is static and void. Static = unchanging. Void = doesn't return anything
     */
	static void Main()//main function, where i call the others 
    {
        Q1();

        Q2(1, 2, 3);

        Q3(9, 8, 7);

        Q4();
    }


    static void Q1()//simple funtion, just prints
    {
        int dec = 35;
        int hex = 0x_23;
        int bin = 0b_00100011;

        Console.WriteLine(dec);
        Console.WriteLine(hex);
        Console.WriteLine(bin);
    }

    static void Q2(byte b, short s, int i)//lil harder, converts then prints
    {
        int ent = b;
        long lang = s;
        float flat = i;

        Console.WriteLine(ent);
        Console.WriteLine(lang);
        Console.WriteLine(flat);
    }

    static void Q3(double d, float f, long l)//second verse, reverse the first. converts explicitly instead of implicitly
    {
        long lung = (long) d;
        int ant = (int) f;
        short shot = (short) l;

        Console.WriteLine(lung);
        Console.WriteLine(ant);
        Console.WriteLine(shot);
    }

    static void Q4()/*assigned the variables i thought would work. System demands that i use double twice, 
                     * and the instructions didnt say i could convert so im kinda lost*/
    {
        short first = 3_500;
        double second = -19_733.148_95;
        int third = 123_456.987;
        double fourth = -9_516_248;
        decimal fifth = 988_562_486;
        

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine(fourth);
        Console.WriteLine(fifth);
    }

}


// end
