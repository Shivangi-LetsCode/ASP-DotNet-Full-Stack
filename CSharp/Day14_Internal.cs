// Accessible only within the same cs file
class Employee2
{
    internal string Department = "IT";
}

class Engineer : Employee2
{
    public void Show()
    {
        Console.WriteLine(Department);
    }
}

class internal1
{
    static void Main()
    {
        Employee2 e = new Employee2();
        Console.WriteLine(e.Department);
    }
}