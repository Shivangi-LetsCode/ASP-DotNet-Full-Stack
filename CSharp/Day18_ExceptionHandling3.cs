class MyException : Exception
{
    public MyException(string msg)
    {
        Console.WriteLine(msg);
    }
}

class CustomException
{
    static void Main()
    {
        throw new MyException("Something Wrong!");
    }
}