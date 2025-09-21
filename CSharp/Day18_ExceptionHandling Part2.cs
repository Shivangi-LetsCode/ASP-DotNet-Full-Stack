//3) Raised by Developer and handled by c#.
class BankAccount
{
    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new Exception("Amount must be greater than zero.");
    }
}
class RDHC
{
    static void Main()
    {
        BankAccount acc = new BankAccount();
        acc.Withdraw(-17); // csharp handling
    }
}