class Employee5
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee5(int Id, string Name, string Department, double Salary)
    {
        this.Id = Id;
        this.Name = Name;
        this.Department = Department;
        this.Salary = Salary;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: {Salary}";
    }
}

class EmployeeData
{
    static void Main()
    {
        List<Employee5> emp = new List<Employee5>
        {
            new Employee5(101,"John","IT",39000),
            new Employee5(102,"Harry","Sales",87000),
            new Employee5(103,"Sam","Finance",43000)
        };


        Console.WriteLine("All Employees: ");
        foreach (var e in emp)
        {
            Console.WriteLine(e);
        }
        // add employee
        //saerch employee by id
        // update salary
        // remove employee

    }
}