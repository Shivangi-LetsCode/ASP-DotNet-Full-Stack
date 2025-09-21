/* static constructor is used to initialize static data of class.
 it is automatically called once before the class is used.
 it runs only one time for the entire class, no matter how many objects you are creating.
 */
class Bank
{
    public static double Interest;
    public int AccountNumber;

    static Bank()
    {
        Interest = 4.5;
        // AccountNumber = 78; // ERRO
    }
    public Bank(int num)
    {
        AccountNumber = num;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"{AccountNumber} has Interest Rate: {Interest}%");
    }
 }

class InterestBank
{
    static void Main()
    {
          Bank b1 = new Bank(10101);
        b1.ShowDetails();

    }
  

 }