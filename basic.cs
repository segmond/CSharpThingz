using System;
 
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

        static public void Main ()
        {
            string user = "Seggy";
            for (int i = 0; i < 5; i++ ) {
                Console.Write("Hello ");
                Console.WriteLine (user);
            }
            foo("FooLabel > ");
            bar("Barzz");
        }
    }
}
