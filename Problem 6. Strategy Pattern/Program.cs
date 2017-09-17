using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Person> list = new List<Person>(new[] { new Person("Ivan", 24), new Person("Drag", 25), new Person("Petkan", 15) });

        SortedSet<Person> nameSort = new SortedSet<Person>(list, new NameLenghtComparer());
        SortedSet<Person> ageSort = new SortedSet<Person>(list, new AgeComparer());

        foreach (var item in nameSort)
        {
            Console.WriteLine(item.Name + " " + item.Age);
        }
        foreach (var item in ageSort)
        {
            Console.WriteLine(item.Name + " " + item.Age);
        }
    }
}

