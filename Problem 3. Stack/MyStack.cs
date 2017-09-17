using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MyStack<T> : IEnumerable<T>
{
    private int initialSize = 10;
    private T[] data;

    public MyStack()
    {
        this.data = new T[this.initialSize];
    }

    public int Count { get; set; }

    public int Capacity => this.data.Length;

    public void Push(T item)
    {
        if ((this.Count() == this.Capacity))
        {
            this.Resize();
        }

        this.data[this.Count] = item;
        this.Count++;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("No elements");
        }
        T currElement = this.data[this.Count-1];
        this.Count--;
        return currElement;
    }
    

    private void Resize()
    {
        Array.Resize(ref this.data,this.Count*2);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.Count-1; i >= 0; i--)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

