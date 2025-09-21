/*OOPS:
4 Pillars:
 1) Encapsulation => Wrapping data(variables/fields) and methods(functions) into a single unit.
      = Data hiding+data protection+controlled access
 2) Inheritance
 3) Abstraction
 4) Polymorphism*/

// ENCAPSULATION
// WITHOUT ENCAPSULATION
/*
class Student5
{
     public string Name;
     public int Age;
}
class WithoutEncapsulation {
     static void Main()
     {
          Student5 s = new Student5();
               s.Name = "John"; // anyone can set the values
               s.Age = -7;   // anyone can give wrong values
               Console.WriteLine($"{s.Name},Age: {s.Age}");
     }
 }*/

//WITH ENCAPSULATION
class Student5
{
     public string Name1;
     public int age;
     public string Name
     {
          get { return Name1; }
          set { Name1 = value; }
     }
     public int Age
     {
          get { return age; }
          set
          {
               if (value > 0)
                    age = value;
               else
                    Console.WriteLine("Age must e Positive.");
          }
     }
 }
class WithEncapsulation {
     static void Main()
     {
          Student5 s = new Student5();

          s.Name = "John";
          s.Age = -7;   
          Console.WriteLine($"{s.Name},Age: {s.Age}");
     }
 }