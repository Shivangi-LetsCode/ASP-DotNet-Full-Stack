class Shape
{
    public void Draw() => Console.WriteLine("Drawing shape!!");
}
class Circle : Shape
{
    public void Area() => Console.WriteLine("Area of circle");
}
class Square : Shape
{
    public void Area() => Console.WriteLine("Area of Square");
}
class HierarchicalInheritance
{
    static void Main()
    {
        Circle c = new Circle();
        c.Draw();
        c.Area();

        Square s = new Square();
        s.Draw();
        s.Area();
    }
}