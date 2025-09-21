/*Interface is combination of methods, events, properties or indexers,a class which implements
interface should provide definiton to all into it.
2) Interface doesn't contains any definition but contains only declaration.
3) We can not create object of Interface
*/

interface IAdmission4
{
   void RegistrationNumber();
    void Receipt();
}
interface IBusService1:IAdmission4
{
    void BusNumber();
}
class John4 : IBusService1
{
    public void RegistrationNumber()
    {
        Console.WriteLine("Registration Number Provided!");
    }
    public void Receipt()
    {
        Console.WriteLine("Receipt Provided!");
    }
     public void BusNumber()
    {
        Console.WriteLine("Bus Number Provided!");
    }
}
class Interface5
{
    static void Main()
    {   
        IBusService1 d = new John4();
        d.RegistrationNumber();
        d.Receipt();
        d.BusNumber();
    }
}