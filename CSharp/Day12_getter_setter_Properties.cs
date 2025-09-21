// class Student
// {
//     private int age;
//     public int Age
//     {
//         set { age = value;
//          }
//         get{ return age; }
//     } 
// }

// class CallStudent
// {
//     static void Main()
//     {
//         Student s1 = new Student();
//         s1.Age = 10;
//         Console.WriteLine(s1.Age);
//     }

// }

class Student
{
    private int age;
    public int Age
    {
        set
        {
            if (value > 0)
                age = value;
            else
                Console.WriteLine("Age must be greater than 0");

        }
        get{ return age; }
    } 
}

class CallStudent
{
    static void Main()
    {
        Student s1 = new Student();
        s1.Age = 0;
        Console.WriteLine(s1.Age);
    }

}