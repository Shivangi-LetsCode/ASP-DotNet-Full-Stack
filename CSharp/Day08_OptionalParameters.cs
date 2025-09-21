class OptionalParameters
{
    public static void Message(string msg="NA")
    {
        Console.WriteLine(msg);
    }
    public static void Main()
    {
        Message("Hi");
        Message();
    }
}
