using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Hello
{
    public class MyContainer<T>
    {
        public MyContainer(T item, string name)
        {
            Item = item;
            Name = name;
        }

        public T Item { get; private set; }
        public string Name { get; private set; }
    }

    public class Program
    {

        public static void printContainer(MyContainer<string> ct)
        {
            Console.WriteLine(ct.Item);
            Console.WriteLine(ct.Name);
        }

        static public void Main ()
        {
            var a = new MyContainer<int>(42, "the answer");
            MyContainer<int> b = new MyContainer<int>(2014, "this year");
            MyContainer<string> c = new MyContainer<string>("Programming C#", "Book Title");

            // we need two containers, one for int, one for strings
            // how can we combine these into one?
            // instead of type int and string, we can have say MyInt, MyString that all
            // inherit object, then we can pass them in to type Object
            var lint = new List<MyContainer<int>>{a,b};
            List<MyContainer<string>> ls = new List<MyContainer<string>>();

            List<MyContainer<object>> d = new List<MyContainer<object>>();
            //List<MyContainer<object>> d = new List<MyContainer<object>>{a,b,c}; // fails

            foreach(MyContainer<int> l in lint) {
                Console.WriteLine(l.Item);
                Console.WriteLine(l.Name);
            }

            printContainer(c);
        }
    }
}
