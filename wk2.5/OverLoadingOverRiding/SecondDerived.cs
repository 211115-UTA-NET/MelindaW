namespace OverrideOverload
{
    public class SecondDerived : Base
    {
        public string secondDerivedString;

        public SecondDerived()
        {
            this.secondDerivedString = "Derived";
        }


        // AccessModifier Modifier RetunType MethodName(Parameters)
        public override void newMethod()    //"override" is REQUIRED to extend or modify the virtual implementation of an 
                                                // inherited method, property, indexer, or event.
        {
            Console.WriteLine("Running newMethod() from SecondDerived.");
        }
    }

}