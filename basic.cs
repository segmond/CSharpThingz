//#define DEBUG
using System;
using System.Numerics;
using System.Text;
namespace Hello
{
    public class HelloWorld
    {
        static void foo(string label)
        {
            Console.WriteLine(label + " inside foo");
#if DEBUG
            Console.WriteLine("debugging thingz");
#endif
        }

        /* ConditionalAttribute, takes the method below out if DEBUG is not defined
            else it includes it */
        [System.Diagnostics.Conditional("DEBUG")]
        static void bar(string label)
        {
            Console.WriteLine("bar debugging thingz");
        }

        static void check_op_test() 
        {
            int a, b, c;
            a = 2147483647;
            b = 3;
            c = a + b; // this won't throw an exception and silently overflow
            //c = checked(a + b); // this will throw an exception
            Console.WriteLine("c is " + c);
            //OverflowException;
        }

        static void big_int_test()
        {
            BigInteger i = 1;
            BigInteger j = 1;
            int count = 0;
            while (true) {
                if (count++ % 100000 == 0) {
                    Console.WriteLine(j);
                }
                BigInteger next = i+j;
                i = j;
                j = next;
            }
        }

        static void string_test(string foo)
        {
            foo = foo.ToUpper();
        }

        static void stringbuilder_test(StringBuilder foo)
        {
            foo = foo.Replace(foo.ToString(), foo.ToString().ToUpper());
        }

        static public void Main ()
        {
            string user = "Seggy";
            for (int i = 0; i < 5; i++ ) {
                Console.Write("Hello ");
                Console.WriteLine (user);
            }
            foo("FooLabel > ");
            bar("Barzz");
            check_op_test();
            //big_int_test();
            string_test(user);
            Console.WriteLine(user);

            StringBuilder s = new StringBuilder("Ygges");
            stringbuilder_test(s);
            Console.WriteLine(s);
        }
    }
}
