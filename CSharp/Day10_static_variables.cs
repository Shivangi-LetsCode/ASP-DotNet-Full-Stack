/*
XYZ Bank
Savings -> Interest = 3%
Account number = different
Phone number = different
Interest = 3% -> static  -> occupy space once in the memory
                        -> not object specific
Current = 6%
Salary = 4%
*/

/* Static fields(variables)
   Static methods
   Static properties -> need getter setter explanation
   sttaic constructors
   static classes*/

/* static fields
  1) stored once per class, not per object.
  2) Used to share data across all objects.*/

class Counter
{
    public static int count = 0; // static variable
    public Counter()
    {
        count++; // every time new object is created it will increment
    }
}
class StaticField
{
    static void Main()
    {
        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Counter c3 = new Counter();
        Console.WriteLine("Total Number of Objects: " + Counter.count);
    }
}