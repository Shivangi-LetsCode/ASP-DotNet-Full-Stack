class Car
{
    public string brand;
    public string color;
    public void Drive()
    {
        Console.Write(brand + " is getting driven and have " + color + " color.");
    }
}

class MainClass
{
    static void Main()
    {
        // creating objects
        Car car1 = new Car();
        car1.brand = "BMW";
        car1.color = "Black";

        Car car2 = new Car();
        car2.brand = "Audi";
        car2.color = "Blue";

        car1.Drive();
        car2.Drive();
    }
}