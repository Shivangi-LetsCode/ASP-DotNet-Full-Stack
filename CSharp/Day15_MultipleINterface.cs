interface IAdmission1
{
    void RegistrationNumber();
    void Receipt();
}
interface IBusService
{
    void BusNumber();
}
class John1 : IAdmission1, IBusService
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
class Interface2
{
    static void Main()
    {
        // John d = new John();
        // d.RegistrationNumber();
        // d.Receipt();

        IAdmission1 d = new John1();
        d.RegistrationNumber();
        d.Receipt();
    }
}