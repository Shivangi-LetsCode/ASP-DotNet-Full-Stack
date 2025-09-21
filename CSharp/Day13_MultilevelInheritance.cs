class Vehicle
{
    public void Start() => Console.WriteLine("Vehicle started!");
}
class Car : Vehicle
{
   public void Drive() => Console.WriteLine("Car being Driven!");
}
class SportsCar : Car
{
    public void Turbo() => Console.WriteLine("Sports Car Turbo On!!");
}
class MultiLevelInheritance
{
    static void Main()
    {
        SportsCar s1 = new SportsCar();
        s1.Start();
        s1.Drive();
        s1.Turbo();
    }
}