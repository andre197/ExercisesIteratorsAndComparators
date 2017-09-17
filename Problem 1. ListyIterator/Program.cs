using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var initialInput = Console.ReadLine().Split();
        ListyIterator<string> list = new ListyIterator<string>(initialInput.Skip(1).ToArray());

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            try
            {
                if (input == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (input == "Print")
                {
                    Console.WriteLine(list.Print());
                }
                else if (input == "PrintAll")
                {
                    Console.WriteLine(list);
                }
                else if (input == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}

