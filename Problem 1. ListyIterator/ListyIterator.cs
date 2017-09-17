using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> listyIterator;
    private int currentIndex;

    public ListyIterator(params T[] listyIterator)
    {
        this.listyIterator = listyIterator.ToList();
    }

    public bool Move()
    {
        if (this.currentIndex+1<this.listyIterator.Count)
        {
            this.currentIndex++;
            return true;
        }
        return false;
    }

    public string Print()
    {
        try
        {

            return this.listyIterator[this.currentIndex].ToString();
        }
        catch
        {
            throw new Exception("Invalid Operation!");
        }
    }

    public bool HasNext()
    {
        if (this.currentIndex + 1 < this.listyIterator.Count)
        {
            return true;
        }
        return false;
    }


    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in this.listyIterator)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public override string ToString()
    {
        return string.Join(" ", this.listyIterator);
    }
}


