namespace SampleNamespace
{
    class DerivedChild : AbstractPerson
    {
        private bool hasAJob = false;
        private bool goToSchool = true;
        private new int _age = 5;
        private int inGrade = 0;

        public override string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        public override string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                this._age = value;
            }
        }
        public bool HasAJob
        {
            get { return hasAJob; }
        }

        public bool GoToSchool
        {
            get { return goToSchool; }
        }

        public int InGrade
        {
            set { this.inGrade = value; }
            get { return inGrade; }
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hello, my name is {_firstName} {_lastName} and I am {_age} yesrs old.");
        }

        public override void Action()
        {
            Console.WriteLine("Play!");
        }
        public string SchoolOrHome()
        {
            Console.WriteLine("Am I at school?");
            Console.WriteLine("Yes or No?");
            Console.ReadLine();

            return "hi";
        }
    }
}