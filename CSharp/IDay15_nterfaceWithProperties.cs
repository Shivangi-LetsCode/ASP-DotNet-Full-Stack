/*Interface is combination of methods, events, properties or indexers,a class which implements
interface should provide definiton to all into it.
2) Interface doesn't contains any definition but contains only declaration.
3) We can not create object of Interface
*/

interface IAdmission2
{
    void RegistrationNumber();
    void Receipt();
    string CollegeName{ get; set; }
}
class John2 : IAdmission2
{
    public string CollegeName{ get; set; }
    public John2(string college)
    {
        CollegeName = college;
    }
    public void RegistrationNumber()
    {
        Console.WriteLine("Registration Number Provided!");
    }
    public void Receipt()
    {
        Console.WriteLine("Receipt Provided!");
    }
    
}
class Interface3
{
    static void Main()
    {
        // John d = new John();
        // d.RegistrationNumber();
        // d.Receipt();

        IAdmission2 d = new John2("ABC College");
        d.RegistrationNumber();
        d.Receipt();
    }
}