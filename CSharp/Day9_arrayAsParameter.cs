using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class ArrayParameter
{
    /*static void sum(params int[] n) // use params when input numbers are unknown
    {
        int total = 0;
        foreach (var i in n)
        {
            total += i;
        }
        Console.Write("Sum of array: "+total);
    }
    public static void Main()
    {
        sum(1, 4, 7, 3, 2, 7, 9, 8, 3);
    }*/

    static int sum(int[] n)
    {
        int total = 0;
        foreach (var i in n)
        {
            total += i;
        }
        return total;
    }

    static void Main()
    {
        int[] arr = { 1, 5, 4, 2, 7, 5, 9 };
        int result = sum(arr);
        Console.Write("Sum of arrays: "+ result);
    }

}