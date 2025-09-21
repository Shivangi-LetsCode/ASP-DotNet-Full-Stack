
class Cat2: Animal2
{
    public void Show()
    {
    Console.WriteLine("Anima2: "+Name);
    }
}

class Pro
{
    static void Main()
    {
        Cat2 a2 = new Cat2();
        a2.Show();
    }
}