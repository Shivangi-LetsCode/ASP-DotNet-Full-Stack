using System.Net;

class dowhile
{
    public static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("======WELCOME======");
            Console.WriteLine("1. Pizza - $20");
            Console.WriteLine("2. Burger - $10");
            Console.WriteLine("3. Pasta - &7");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your Choice(1-4): ");

            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You orderd Pizza!!");
                    break;
                case 2:
                    Console.WriteLine("You orderd Burger!!");
                    break;
                case 3:
                    Console.WriteLine("You orderd Pasta!!");
                    break;
                case 4:
                    Console.WriteLine("Thank you for visiting us!!");
                    break;
                default:
                    Console.WriteLine("Invalid Request!!");
                    break;

            }
        } while (choice != 4);
    }
}