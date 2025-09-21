class forLoop
{
    public static void Main()
    {
        // Print John 5 Times
        for (int m = 1; m <= 5; m++)
        {
            Console.WriteLine("John");
        }

        // print counting 1 to 10
        for (int m = 1; m <= 10; m++)
        {
            Console.WriteLine(m);
        }

        Console.WriteLine("Reverse Order ");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Even Numbers ");
        for (int a = 0; a <= 20; a += 2)
        {
            Console.WriteLine(a);
        }

        Console.Write("provide a number ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        for (int b = 1; b <= 10; b++)
        {
            Console.WriteLine(number + " * " + b + " = " + number * b);
        }

        // nested for
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }


    }
}
