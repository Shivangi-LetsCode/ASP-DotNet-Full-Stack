/*Abstraction means hiding implementation details and showing only essential features
It mentiones : What it does instead of How 
--> How to implement Abstraction: 
    1) Abstract classes
    2) Interface
--> Abstract class can not b initialized
--> A derived class must be implement all abstract methods*/

//1)Using Abstract classes
abstract class Shape1
{
    public abstract void Draw(); // abstract method 
    public void shapes() // non abstract method
    {
        Console.WriteLine("All sapes occupies space.");
    }
}

class Circle1 : Shape1
{
    public override void Draw()
    {
        Console.WriteLine("Let's Draw a circle.");
    }
}

class Rectangle1 : Shape1
{
    public override void Draw()
    {
        Console.WriteLine("Let's Draw a rectangle.");
    }
}

class AbstractClassMethod
{
    static void Main()
    {
        // Circle1 c = new Circle1();
        // Rectangle1 c = new Rectangle1();

        Shape1 s;
        s = new Circle1();
        s.Draw();
        s.shapes();

        s = new Circle1();
        s.Draw();
        s.shapes();


    }
}