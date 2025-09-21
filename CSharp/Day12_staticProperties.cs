//static property: A propety that belongs to the class Itself, not to any object
//Declared with static keyword
//Accessed using class name not object name
// Useful for shared value

class Employee
{
    public static int EmployeeCount { get; set; } = 0;
    public Employee()
    {
        EmployeeCount++;
    }
}

class CountEmployee
{
    static void Main()
    {
        Employee e1 = new Employee();
        Employee e2 = new Employee();
        Employee e3 = new Employee();
        Employee e4 = new Employee();
        Console.WriteLine("Total Employees: "+Employee.EmployeeCount);
    }
}