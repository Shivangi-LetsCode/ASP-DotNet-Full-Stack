//2) Raised by C# and handled by Developer.
class RCHD
{
    /* static void Main()
     {
         try
         {
             int a = 10, b = 0;
             Console.WriteLine(a / b); //DivideByZeroException
         }
         catch (DivideByZeroException ex)
         {
             Console.WriteLine(ex.Message);
             Console.WriteLine("Don't divide by zero");
         }

     }*/
    static void Main()
    {
        try
        {
            int a = 10, b = 0;
            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Don't divide by zero");
        }
        finally
        {
            Console.WriteLine("Inside Finally");
        }

    }
}