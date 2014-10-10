using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace Hello
{
    interface IBase1
    {   
        void Base1Method();
    }

    interface IBase2
    {   
        void Base2Method();
    }
    interface IBoth : IBase1, IBase2
    {   
        void Method3();
    }

    public class Base //: IBase1
    {
        //public abstract void Base1Method();
    }

    public class Derived : Base
    {
        //public void Base1Method() { }
    }

    public class More : Derived
    {
    }

    // must implement base one method
    public class ImplOne : IBase1
    {
        public void Base1Method() { }
    }

    public class ImplBoth : IBoth
    {
        public void Base1Method() { }
        public void Base2Method() { }
        public void Method3() { }
    }


    public class Program
    {
        static public void Main ()
        {
            Console.WriteLine("Stuff");
        }
    }
}
