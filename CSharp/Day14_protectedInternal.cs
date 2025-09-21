//Accessible in the same cs file and also in derived class(EventArgs if another cs file)
class University
{
    protected internal string Course = "Computer Science";
}
class Student1 : University
{
    public void ShowCourse()
    {
        Console.WriteLine("Course: "+Course);
    }
}
class protectedInternal
{
    static void Main()
    {
        Student1 s1 = new Student1();
        s1.ShowCourse();
    }
}