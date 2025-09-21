/*
Access modifiers in C# defines the scope(where you can access) of a class, method, variable, property.
They control who can use what in your code

types: public, private(default for class members), protected, Internal, Protected Internal, private protected
*/
// public -> access anywhere
public class Car4
{
    public string Model = "Tesla";
}

class publicModifier
{
    static void Main()
    {
        Car4 c1 = new Car4();
        Console.WriteLine(c1.Model);
    }
}