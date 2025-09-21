using System.Net.Http.Headers;


namespace Shopping
{
    public class Product
    {
        public string Name;
        public double Price;
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price}");
        }

    }

}


namespace Banking
{
    public class Account
    {
        public string AccountHolder;
        public double Balance;
        public Account(string accholder, double balance)
        {
            AccountHolder = accholder;
            Balance = balance;
        }
        public void ShowBalance()
        {
            Console.WriteLine($"{AccountHolder}'s Balance: {Balance}");
        }
    }
}

class CallClasses
{
    static void Main()
    {
        Shopping.Product p1 = new Shopping.Product("Laptop", 34000);
        p1.ShowDetails();

        Banking.Account a1 = new Banking.Account("John", 60000);
        a1.ShowBalance();
    }
}