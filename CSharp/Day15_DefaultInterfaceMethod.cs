/*Interface is combination of methods, events, properties or indexers,a class which implements
interface should provide definiton to all into it.
2) Interface doesn't contains any definition but contains only declaration.
3) We can not create object of Interface
*/

interface IAdmission3
{
    void RegistrationNumber();
    void Receipt();
    public void HardCopy() // Default method
    {
        Console.WriteLine("HardCopy Provided!");
    }
}
class John3 : IAdmission3
{
    public void RegistrationNumber()
    {
        Console.WriteLine("Registration Number Provided!");
    }
    public void Receipt()
    {
        Console.WriteLine("Receipt Provided!");
     }
    public void HardCopy() // Default method
    {
        Console.WriteLine("HardCopy Provided inside John3!");
    }
}
class Interface4
{
    static void Main()
    {
        IAdmission3 d = new John3();
        d.RegistrationNumber();
        d.Receipt();
        d.HardCopy();
    }
}