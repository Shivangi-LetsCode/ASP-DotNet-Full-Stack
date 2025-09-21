// Accessible inside the same class and derived class
class Animal2
{
    protected string Name = "Lion";
}

class Lion : Animal2
{
    public void ShowName()
    {
        Console.WriteLine("Animal: " + Name);
    }
}
class protected1{
    static void Main()
    {
        Lion l = new Lion();
        l.ShowName();
    }
}