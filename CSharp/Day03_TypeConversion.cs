// Type Conversion -> Converting one data type tp another
// Implicit Conversion -> Automatically by Compiler -> No loss of data 
// Explicit Conversion -> Manually by Programmer -> Loss of data

//Implicit Conversion
class TypeConversion{
    public static void Main()
    {

        int num = 100;  // 4 bytes -> 1 byte = 8 bits, 4 bytes = 8x4 => (32 bits)
        long num2 = num; // implicit type conversion , long-> 8 bytes -> 1 byte = 8 bits, 8 Bytes => 8x8 => (64 bits)
        Console.WriteLine(num.GetType());
        Console.WriteLine(num2.GetType());

        char l = 'A';
        int value = l;
        Console.WriteLine(value);

        double d = 9.2;
        // int i = d; // ERROR

        int i = (int)d; // Explicit type conversion
        Console.WriteLine(i);

        //Valid Implicit type conversion
        // byte-> short -> int-> long-> float-> double-> decimal
        // chat-> int,long,float, double

        // EXPLICIT TYPE CONVERSION
        // 1st method: Casting method
        // 2nd method: Conversion Methods
        // 3rd method: Parse() method
        // 4th method: TryPrse() -> safe coonversion

        // 1st method: Casting method
        float f = 12.45f;
        int ds = (int)f;

        int n1 = 200;
        byte b = (byte)n1;

        int n2 = 65;
        char l1 = (char)n2;
        Console.WriteLine(l1);

        // 2nd method: Conversion Methods
        string s1 = "100";
        int n3 = Convert.ToInt32(s1);
        Console.WriteLine(n3 + 20);

        string s2 = "34.78";
        double d4 = Convert.ToDouble(s2);
        Console.WriteLine(d4 + 12);

        int n5 = 500;
        string s3 = Convert.ToString(n5);
        Console.WriteLine(s3 + "is a string");

        int ascii = 65;
        char ch4 = Convert.ToChar(ascii);
        Console.WriteLine(ch4);

        // 3rd method: Parse() method
        // Parse() only works with String
        string s4 = "200";
        int n6 = int.Parse(s4);
        Console.WriteLine(n6);

        string s5 = "abc";
        int n7 = int.Parse(s5);
        Console.WriteLine(n7);

        // 4th method: TryParse() -> safe conversion
        string s6 = "1234";
        bool n9 = int.TryParse(s6, out int number);
        Console.WriteLine(n9);
        Console.WriteLine(number);

        string s7 = "abcd";
        bool n8 = int.TryParse(s7, out int number1);
        Console.WriteLine(n8);
        Console.WriteLine(number1);


    }
}
