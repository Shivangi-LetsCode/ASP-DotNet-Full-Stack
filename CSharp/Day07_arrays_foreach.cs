class array_forEach
{
    public static void Main()
    {
        // array: collection of elements of same type stored in contiguous memory
        // elements of an rray can e accessed by index
        // array size is fixed once declared

        // arrays methods to declare and initialize
        int[] num; // array declaration 
        int[] num1 = new int[5]; // declaration + size
        int[] num3 = new int[5] { 10, 20, 30, 40, 50 }; // declaration + initialization
        int[] num4 = { 10, 20, 30, 40, 50, 60, 70 }; // shorthand initialization

        Console.WriteLine("First Element: " + num4[0]); // 10
        Console.WriteLine(" Element: " + num4[5]); // 60

        for (int i = 0; i < num4.Length; i++)
        {
            Console.WriteLine(num4[i]);
        }
        foreach (int n in num4)
        {
            Console.WriteLine(num4);
        }

    }
}


// find maximum and minimum element in array
// find sum of all elements in array
// take fruits inside an array and print
// reverse an array
// Search given element in array
// count even and odd in array
// copy one array to another array
// sort array in ascending order
// remove duplicate elements
// merge 2 arrays
// find second largets element

