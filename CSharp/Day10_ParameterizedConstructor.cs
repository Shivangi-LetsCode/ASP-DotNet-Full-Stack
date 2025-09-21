/*A constructor is method which gets called automatically when object of a class created.
It is used to Initialize values.
Name of the constructor will be same as the class name.
Constructors doesn't have return type.*/

class Car2
{
    public string brand;
    public Car2(string carbrand)
    {
        brand = carbrand;
        Console.WriteLine("DEFAULT CONSTRUCTOR");
    }
}
class ParameterizedConstructors
{

    public static void Main()
    {
        Car2 c1 = new Car2("Audi");
        Car2 c2 = new Car2("BMW");
        Console.WriteLine("Brand: " + c1.brand);
        Console.WriteLine("Brand: "+c2.brand);
    }
}