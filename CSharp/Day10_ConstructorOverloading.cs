class Car3{
    public string brand;
    public Car3(){
        brand = "NA";
        Console.WriteLine("default constructor");
    }


    public Car3(string carBrand){
        brand = carBrand;
    }
}


class ConstructorOverloading{
    public static void Main(){
        Car3 c1 = new Car3();
        Console.WriteLine("Car brand " + c1.brand);




      //  Car1 c2 = new Car1("Audi");
      //  Console.WriteLine("Car brand " + c2.brand);
    }
}
