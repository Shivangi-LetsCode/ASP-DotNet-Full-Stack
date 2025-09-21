/*
if 
if else
if else if else
Nested If else
Switch
Ternary Operator
*/
class Decision
{
    public static void Main()
    {
        // if
        int age = 20;
        if (age > 18)
        {
            Console.WriteLine("Adult");
        }

        // if else
        int age1 = 13;
        if (age1 > 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Child");
        }

        //if else if else
        int marks = 73;
        if (marks >= 90)
            Console.WriteLine("Grade A");
        else if (marks >= 75)
            Console.WriteLine("Grade B");
        else if (marks >= 50)
            Console.WriteLine("Grade C");
        else
            Console.WriteLine("Fail");
    }

    
}
