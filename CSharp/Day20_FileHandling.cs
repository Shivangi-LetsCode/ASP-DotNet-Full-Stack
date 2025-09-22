// Performing operations in text, binary .. files -> System.IO
/*Create a file
write to a file
Read from a file
Append file
Delete file*/

/* classes:
File-> static method for reading, writing, creating, deleting, copying, moving file
FileInfo -> Provides detailed info of file
StreamReader-> for reading text from a file
StreamWriter-> writing text to the file
*/

// CREATE AND WRITE TO A FILE
/*
class CW
{
    static void Main()
    {
        string file = "firstfile.txt";
        File.WriteAllText(file, "This is my first file");
        Console.WriteLine("File has been created successfully!");
    }
}*/
/*
// READ FROM FILE
class RF
{
    static void Main()
    {
        string file = "firstfile.txt";
        string data = File.ReadAllText(file);
        Console.WriteLine(data);
    }
}

// APPEND TO A FILE
class AD
{
    static void Main()
    {
        string file = "firstfile.txt";
        File.AppendAllText(file, " I a new text.");
        Console.WriteLine("Data Appended Successfully!");
    }
}*/

/*
// DELETE A FILE
class DF
{
    static void Main()
    {
        string file = "firstfile.txt";
        if (File.Exists(file))
        {
            File.Delete(file);
            Console.WriteLine("File has been deleted!");
        }
        else
        {
            Console.WriteLine("File doesn't exists!");
        }
    }
}
*/

class SWR
{
    static void Main()
    {
        string file = "secondfile.txt";
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("This is First Line.");
            writer.WriteLine("This is Another Line.");
        }

        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine())!=null)
            {
                Console.WriteLine(line);
            }
        }
        
    }
}