using System.ComponentModel;

class whileLoop
{
    public static void Main()
    {
        int i = 1; // initalization
        while (i <= 5) // condition
        {
            Console.WriteLine("John"); // statement 
            i++; // increment
        }

        Console.WriteLine("odd numbers");
        int b = 1;
        while (b <= 20)
        {
            Console.WriteLine(b);
            b += 2;
        }

        // 1+2+3+4+5+6+7+8+9+10 = 55
        Console.WriteLine("sum of 55");
        int sum = 0;
        int c = 1;
        while (c <= 10)
        {
            sum += c;
            c++;
        }
        Console.WriteLine(sum);

        // Keep asking password until user provides correct password
        string password = "";
        while (password != "admin12345")
        {
            Console.WriteLine("Enter Password");
            password = Console.ReadLine();
        }
        Console.WriteLine("Access Granted");

        // 7563 -> 3 6 5 7
    Console.WriteLine("give a number: ");
        int numberByUser = Convert.ToInt32(Console.ReadLine());

        while (numberByUser != 0)
        {
            Console.WriteLine(numberByUser % 10);
            numberByUser = numberByUser / 10;
        }
        Console.WriteLine("done");

    }
}

