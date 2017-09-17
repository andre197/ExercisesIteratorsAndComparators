using System.Collections.Generic;

public class NameLenghtComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x.Name == null)
        {
            return -1;
        }
        if (y.Name == null)
        {
            return 1;
        }
        if (x.Name.Length - y.Name.Length == 0)
        {
            return x.Name[0].CompareTo(y.Name[0]);
        }
        return x.Name.Length - y.Name.Length;
    }
}

