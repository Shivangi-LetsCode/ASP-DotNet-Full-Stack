using System.Text;

class strings1
{
    public static void Main()
    {
        // Declaring and Initializing strings
        string str1 = "Hello";
        string str2 = "World";
        string str3 = str1 + " " + str2;
        Console.WriteLine(str3);

        // Length
        string name = "John";
        Console.WriteLine(name.Length);

        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());

        Console.WriteLine(name.Substring(0, 2));

        string name2 = "John Smith";
        Console.WriteLine(name2.Replace("Smith", "Bard"));
        Console.WriteLine(name2);
        name2 = name2.Replace("Smith", "Bard");
        Console.WriteLine(name2);
        Console.WriteLine(name2.Contains("ar"));

        Console.WriteLine(name2.StartsWith("J"));
        Console.WriteLine(name2.EndsWith("rd"));

        string data = "   hello    ";
        Console.WriteLine(data.Trim());

        // String Interpolation
        string name3 = "Rich";
        int age = 23;
        Console.WriteLine($"My name is {name3} and I am {age} years.");

        foreach (char c in name3)
        {
            Console.WriteLine(c);
        }

        // Mutable strings (StringBuilder)
        // Strings are immutable, but if you want to modify them many times, it creates objects
        StringBuilder sb = new StringBuilder("Hey ");
        sb.Append("Hi");
        Console.WriteLine(sb);
        sb.Append(" Hello");
         Console.WriteLine(sb);
// Write a program to input a string and display its length.

// Take a string as input and print it in uppercase and lowercase.

// Write a program to count the number of vowels and consonants in a string.

// Reverse a string without using the built-in Reverse() method.

// Check whether a given string is a palindrome.

// Write a program to find the first and last character of a string.

// Remove all white spaces from a string.

// Compare two strings without using == operator (use .Equals() method).
    }
}
