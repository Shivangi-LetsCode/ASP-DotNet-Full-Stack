/*
Accessible only inside the same class
Most restrictive
*/

public class Car5
{
    private string Model = "Tesla";
    public void ShowEngine()
    {
        Console.WriteLine(Model);
    }
}

class privateModifier
{
    static void Main()
    {
        Car5 c1 = new Car5();
        c1.ShowEngine();
       // Console.WriteLine(c1.Model);
    }
}