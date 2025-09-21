class Operators2
{
    public static void Main()
    {
        // 7) BITWISE OPERATORS(&(and),|(or),^(XOR(Exclusive OR)),~(NOT),<<(Left shift),>>(right shift))
        int a = 5;
        int b = 6;
        Console.WriteLine(a & b);

        int c = 5;
        int d = 6;
        Console.WriteLine(c | d);

        int e = 5;
        int f = 6;
        Console.WriteLine(e ^ f);

        int g = 9;
        Console.WriteLine(~g);

        //<< left shift 
        Console.WriteLine(12 << 3);

        //<< right shift 
        Console.WriteLine(25 >> 2);

        // &=, |=, ^=, ~=, >>=, <<=

        //8) Ternary Operator
        int age = 12;
        string eligibility = (age >= 18) ? "You are eligible for rafting" : "You are not eligible for rafting";
        Console.WriteLine(eligibility);

        
    }
}

