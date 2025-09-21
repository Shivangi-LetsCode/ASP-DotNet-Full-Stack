/*A constructor is method which gets called automatically when object of a class created.
It is used to Initialize values.
Name of the constructor will be same as the class name.
Constructors doesn't have return type.*/

class Car1
{
    public string brand;
    public Car1()
    {
        brand = "NA";
        Console.WriteLine("DEFAULT CONSTRUCTOR");
    }
}
class ParameterLessConstructors
{

    public static void Main()
    {
        Car1 c1 = new Car1();
        Console.WriteLine("Brand: "+c1.brand);
    }
}