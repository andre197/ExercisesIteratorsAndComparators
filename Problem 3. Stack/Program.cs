using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        MyStack<string> stack = new MyStack<string>();
        while (true)
        {
            var input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (input[0] == "END")
            {
                break;
            }
            
            if (input[0] == "Push")
            {
                foreach (var item in input.Skip(1).ToArray())
                {
                    stack.Push(item);
                }
            }
            else if (input[0] == "Pop")
            {
                try
                {
                    stack.Pop();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}

