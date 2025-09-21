class valueReference
{
    //pass by value
    public static void Increment(int num)
    {
        num++;
    }

    // pass by refernce
    public static void Increment1(ref int num)
    {
        num++;
    }
    public static void Main()
    {
        int num = 2;
        Increment(num);
        Console.WriteLine(num); // 2

        Console.WriteLine("Pass By Reference");
        Increment1(ref num);
        Console.WriteLine(num);
    }



}