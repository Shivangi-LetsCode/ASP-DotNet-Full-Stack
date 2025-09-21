/*
static keyword
cannot create an object of static class
static class can have only:
   a) static fields
   b) static methods
   c) static properties
   d) static constructors 
static class can not be inherited(automatically sealed)
*/

using System.Globalization;

static class MathOperations
{
    // public double pi = 3.14159; // error
    public static double pi = 3.14159;
    public static double square(int num)
    {
        return num * num;
    }

}
class staticClass
{
    public static void Main()
    {
        Console.WriteLine(MathOperations.square(12));
    }
}