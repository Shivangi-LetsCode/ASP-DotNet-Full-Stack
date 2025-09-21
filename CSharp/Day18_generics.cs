// generics allows us create a class, methods, delegates and interfces with a placeholder
// type parameter for the data type

using System.Net.Mime;
using System.Runtime.CompilerServices;

class Shape4<G,H>
{
    private G content;
     private H content2;
    public void Add(G item)
    {
        content = item;
    }
    public G GetData()
    {
        return content;
    }
}

class Generics1
{
    static void Main()
    {
        Shape4<int,string> s1 = new Shape4<int,string>();
        s1.Add(98);
        Console.WriteLine(s1.GetData());

        Shape4<string,int> s2 = new Shape4<string,int>();
        s2.Add("John");
        Console.WriteLine(s2.GetData());

    }
}