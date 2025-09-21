// multiple methods having same name 
/*They must differ in:
  number of parameters
  Types of parameters
  Order of parameters*/


class MethodOverloading
{
    static void sum(int a, int b)
    {
        Console.Write(a+b);
    }
    static void sum()
    {
        Console.Write("sum");
    }
    static void sum(int a, string str1)
    {
        Console.WriteLine(a+str1);
    }
    static void sum(string str1, int a)
    {
        Console.WriteLine(a+str1);
    }
    public static void Main()
    {
        sum();
        sum(4, 6);
        sum(2, "hello");
        sum("hello", 2);
    }
}
