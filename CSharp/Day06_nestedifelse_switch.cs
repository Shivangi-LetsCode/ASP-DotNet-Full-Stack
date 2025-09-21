class NestedIf_Switch
{
    public static void Main()
    {
        int age = 25;
        bool validID = false;
        if (age > 18)
        {
            if (validID)
            {
                Console.WriteLine("Access Granted");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }
        }
        else
        {
            Console.WriteLine("You are Underage");
        }


        //Switch
        int day = 8;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Please Enter Days between 1 to 7");
                break;
        }

        Console.WriteLine("Give a color: ");
        string color = Console.ReadLine();

        switch (color)
        {
            case "b":
            case "B":
                Console.WriteLine("blue");
                break;
            case "r":
            case "R":
                Console.WriteLine("Red");
                break;
            case "g":
            case "G":
                Console.WriteLine("green");
                break;
            case "y":
            case "Y":
                Console.WriteLine("yellow");
                break;
            case "o":
            case "O":
                Console.WriteLine("orange");
                break;
            case "p":
            case "P":
                Console.WriteLine("purple");
                break;
            default:
                Console.WriteLine("color not found");
                break;
        }

    }
}
