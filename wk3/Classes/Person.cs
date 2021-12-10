//Namespace
namespace SampleNamespace
{
    //Another Class!
    // AccessModifier class ClassName
    public class Person
    {
        //Fields
        private string firstName;
        private string lastName;

        //Constructor(s)
        public Person()
        {
            this.firstName = "John";
            this.lastName = "Doe";
        }

        public Person( string first, string last )
        {
            firstName = first;
            lastName = last;
        }

        //Methods
        public void setFirstName(string name)
        {
            this.firstName = name;
        }

        public void setLastName(string name)
        {
            this.lastName = name;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName(){
            return lastName;
        }
 
        //accessModifier returnType methodName(Parameters)
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}");
        }
    }
}