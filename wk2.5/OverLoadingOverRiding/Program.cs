using System;

namespace OverrideOverload
{
    class Program
    {
        public static void Main()
        {
            Base MyBase = new Base();
            Derived MyDerived = new Derived();

            Console.WriteLine(MyBase.baseString);
            Console.WriteLine(MyDerived.derivedString);
            Console.WriteLine();

            Console.WriteLine(MyDerived.baseString);
            Console.WriteLine();

            MyBase.speak();
            MyBase.speak("I'm Different!");
            Console.WriteLine();

            MyBase.speak();
            string value = MyBase.speak("I'm Different!");
            Console.WriteLine(value);
            Console.WriteLine();

            MyDerived.newMethod();
            Console.WriteLine();

            MyBase.newMethod();


            MyDerived.newMethod();

            SecondDerived MySecondDerived = new SecondDerived();
            MySecondDerived.newMethod();
            Console.WriteLine();
            
            Base thing;
            
            thing = new Base();
            thing.newMethod();

            thing = new Derived();
            thing.newMethod();

            thing = new SecondDerived();
            thing.newMethod();
        }
    }
}