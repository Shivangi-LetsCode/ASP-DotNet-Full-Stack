 // Two types: Predefined and User defined
        // Predefined methods are methods which are already develop, to use them just need to call
        // User defined: we will develop

        // method definition and method calling
        /*  User defined methods 4 types:
          1) Passing Nothing Returns Nothing
          2) Passing Something Returns Nothing
          3) Passing Nothing Returns Something
          4) Passing Something Returns Something */



class Methods1
{
    
    //1) Passing Nothing Returns Nothing
    public static void Greet() // method definition
    {
        Console.WriteLine("Hi John!");
    }

    //2) Passing Something Returns Nothing
    public static void Greet2(string name)
    {
        Console.WriteLine(name);
    }

    // 3) Passing Nothing Returns Something
    public static string Greet3()
    {
        return "Sam";
    }

    // 4) Passing Something Returns Something
    public static string Greet4(string name)
    {
        return name;
    }

    public static void Main()
    {
        Greet(); // method calling
        Greet2("Harry");
        //Method 1
        string result = Greet3();
        Console.WriteLine(result);

        //Method 2
        Console.WriteLine(Greet3());
        Console.WriteLine(Greet4("Rich"));

        // take 2 integer values from user and perform add, sub, mul, div using all 4 user defined methods
/*
        Write a method IsEven that accepts an integer and returns true if it’s even, otherwise false.

        Write a method CalculateSquare that takes a number and returns its square.

        Write a method PrintTable that prints the multiplication table of a number(using for loop).


         Write a method FindMax that takes three integers as parameters and returns the largest.

        Write a method Factorial that returns the factorial of a given number.

        Write a method ReverseString that takes a string and returns its reverse.

        Write a method IsPrime that checks whether a number is prime.

        Write a method CountVowels that takes a string and returns the number of vowels in it.*/
        

            }
}