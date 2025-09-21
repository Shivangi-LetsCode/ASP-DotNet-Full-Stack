/*Animal exception is Animal error occurs at runtime.
two types: 1) build in/ pre defined exceptions
           2) user defined eaxceptions

1) Raised by C# and Handled by C#.
2) Raised by C# and handled by Developer.
3) Raised by Developer and handled by c#.
4) Raised by Developer and handled by Developer.*/

//1) Raised by C# and Handled by C#.
/*class RCHC
{
    static void Main()
    {
        int a = 10, b = 0;
        Console.WriteLine(a / b); //DivideByZeroException
    }
}*/

/*
class RCHC
{
    static void Main()
    {
        int[] num = { 2, 5, 4, 7, 8 };
        Console.WriteLine(num[5]); //System.IndexOutOfRangeException
    }
}*/

class RCHC
{
    static void Main()
    {
        string name = null;
        Console.WriteLine(name.Length); //System.NullReferenceException
    }
}

