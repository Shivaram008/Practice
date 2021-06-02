using System;
using System.Collections.Generic;
using System.Collections;

public class GenericColl
{
    public static void Display<T>(List<T> l)
    {
        foreach(var i in l)
            Console.Write($"{i} ");
        Console.WriteLine();
    }
    public static void Display<T1, T2>(Dictionary<T1, T2> d)
    {
        foreach (var i in d)
        {
            Console.WriteLine($"{i.Key} : {i.Value}");
        }
        System.Console.WriteLine();
    }
    public static void Display<T>(Stack<T> st)
    {
        Console.WriteLine("Peek element is : "+st.Peek());
        foreach(var i in st)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
    public static void Main(String[] args)
    {
        List<int> l = new List<int>() { 1, 2, 3, 4, 5 };
        l.Add(6);
        l.Add(7);
        Display(l);
        
        var li = new List<String>() { "Siva", "Ram", "Prasad" };
        Display(li);
        
        Dictionary<int, string> d = new Dictionary<int, string>();
        d.Add(1, "one");
        d.Add(2, "Two");
        Display(d);

        Stack<int> st = new Stack<int>();
        st.Push(1);
        st.Push(2);
        st.Push(3);
        st.Push(4);
        
        Display(st);
        Console.WriteLine(st.Peek());
        Console.WriteLine(st.Pop());        //Poping of an element.

        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        Console.WriteLine("Queue peek element is : "+q.Peek());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine( q.Count);

        HashSet<int> h = new HashSet<int>();
        h.Add(1);
        h.Add(1);
        Console.WriteLine(h.Count);

        Hashtable h1 = new Hashtable();
        h1.Add(1, "one");
        h1.Add(2, 1);
        foreach(DictionaryEntry i in h1)
        {
            Console.WriteLine(i.Key +"  "+i.Value  );
        }
    }
}
