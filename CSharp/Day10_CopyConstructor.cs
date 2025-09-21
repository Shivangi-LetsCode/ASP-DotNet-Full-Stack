class Person
{
    public string name;
    public int age;
    public Person(string n, int a)
    {
        name = n;
        age = a;
    }

    // copy constrc=uctor
    public Person(Person p)
    {
        name = p.name;
        age = p.age;
    }
}

class CopyConstructor
{
    static void Main()
    {
        Person p1 = new Person("John", 20);
        Person p2 = new Person(p1);  // copying p1 into p2

        Console.WriteLine(p2.name + " - "+p2.age);
    }
    
}
