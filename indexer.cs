using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Hello
{
    public class MyIndexer
    {
        public static void foo(string label)
        {
            Console.WriteLine(label + " inside foo");
        }

        public string this[int index]
        {
            get {
                return index < 5 ? "Foo" : "Bar";
            }
        }
    }

    public class Program
    {

        static public void Main ()
        {
            MyIndexer mi = new MyIndexer();
            MyIndexer.foo("FooLabel > ");
            Console.WriteLine(mi[3]);
            Console.WriteLine(mi[5]);
        }
    }
}
