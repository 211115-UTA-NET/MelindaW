namespace SampleNamespace
{
    abstract class AbstractPerson
    {
        protected string _firstName = "John";
        protected string _lastName = "Doe";
        protected int _age = 0;

        //Methods

        public abstract string FirstName { get; set; }
        public abstract string LastName {get; set; }

        public abstract int Age { get; set; }

        public abstract void Introduce();

        public abstract void Action();
    }
}