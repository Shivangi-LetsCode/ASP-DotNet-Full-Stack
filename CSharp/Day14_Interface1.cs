/*Interface is combination of methods, events, properties or indexers,a class which implements
interface should provide definiton to all into it.
2) Interface doesn't contains any definition but contains only declaration.
3) We can not create object of Interface
*/

interface IAdmission
{
    void RegistrationNumber();
    void Receipt();
}
class John: IAdmission
{
    public void RegistrationNumber()
    {
        Console.WriteLine("Registration Number Provided!");
    }
    public void Receipt()
    {
        Console.WriteLine("Receipt Provided!");
    }
}
class Interface1
{
    static void Main()
    {
        // John d = new John();
        // d.RegistrationNumber();
        // d.Receipt();

        IAdmission d = new John();
        d.RegistrationNumber();
        d.Receipt();
    }
}