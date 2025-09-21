/*Inheritance is  a process were a class can resuse properties and methods of another class.
child class cn add new features or override parent methods

parent/Base/Super
child/Derived/Sub*/

/*
Single
Multi-Level
Hierarchical
*/

class Animal
{
    public void Eat() => Console.WriteLine("Animal eats food");
}
class Cat : Animal
{
    public void Meow() => Console.WriteLine("Cat Meows..");
}
class SingleInheritance
{
    static void Main()
    {
        Cat c = new Cat();
        c.Eat();
        c.Meow();
    }
}
