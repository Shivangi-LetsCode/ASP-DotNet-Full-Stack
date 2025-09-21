class GenericCollection
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
        numbers.Add(7);
        numbers.Remove(4);
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }

        // Dictionary
        Dictionary<int, string> employees = new Dictionary<int, string>();
        employees.Add(101, "JOhn");
        employees.Add(102, "Harry");
        Console.WriteLine(employees[102]);

        //Stack(LIFO)
        Stack<string> stack1 = new Stack<string>();
        stack1.Push("A");
        stack1.Push("B");
        Console.WriteLine(stack1.Pop());
        Console.WriteLine(stack1);

        //Queue(FIFO)
        Queue<string> q1 = new Queue<string>();
        q1.Enqueue("C");
        q1.Enqueue("D");
        q1.Enqueue("E");
        Console.WriteLine(q1.Dequeue());
    }
}