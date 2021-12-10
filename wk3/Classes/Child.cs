namespace SampleNamespace
{
    class Child : Person
    {
        private bool hasAJob = false;
        private bool goToSchool = true;
        private int age = 5;
        private int inGrade = 0;

        public Child() { }

        public Child(int age, int inGrade, string firstName, string lastName) : base(firstName, lastName)
        {
            this.age = age;
            this.inGrade = inGrade;
        }

        public string SchoolOrHome()
        {
            Console.WriteLine("Am I at school?");
            Console.WriteLine("Yes or No?");

            return "hi";
        }

        public bool HasAJob
        {
            get { return hasAJob; }
        }

        public bool GoToSchool
        {
            get { return goToSchool; }
        }

        public int Age
        {
            set { this.age = value; }
            get { return age; }
        }

        public int InGrade
        {
            set { this.inGrade = value; }
            get { return inGrade; }
        }
    }
}