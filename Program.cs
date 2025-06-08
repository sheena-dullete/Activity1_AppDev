using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("WELCOME!");
        string name;
        GetInput(out name);
    }

    static void GetInput(out string name)
    {
        Console.WriteLine("Enter name:");
        name = Console.ReadLine();

        Console.WriteLine("Hello, " + name + "!");
    }
}
