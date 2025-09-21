class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Sub(int a, int b)
    {
        return a - b;
    }
    public static int Mul(int a, int b)
    {
        return a * b;
    }
    public static double Div(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero!");
        return (double)a / b;
    }
}
class StaticMethod
{
    static void Main()
    {
        Console.WriteLine("Calculator: ");
        Console.WriteLine("10+5 = " + Calculator.Add(10, 5));
        Console.WriteLine("10-8 = " + Calculator.Sub(10, 8));
        Console.WriteLine("10*2 = " + Calculator.Mul(10, 2));
        Console.WriteLine("10/3 = "+Calculator.Div(10,3));
    }
}