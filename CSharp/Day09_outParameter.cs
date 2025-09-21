class Day9_outParameter
{
    static void Divide(int a, int b, out int quotient, out int remainder)
    {
        quotient = a / b;
        remainder = a % b;
    }
    public static void Main()
    {
        int q, r;
        Divide(10, 3, out q, out r);
        Console.WriteLine($"Quotient = {q}, Remainder={r}");
    }
}
