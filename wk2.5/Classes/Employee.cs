namespace SampleNamespace
{
    public class Employee : Person
    {
        private int HoursWorked;
        private double PayRate;

        //Constructor
        public Employee()
        {
            this.HoursWorked = 20;
            this.PayRate = 18.50;
        }

        public Employee(int HoursWorked, double PayRate, string firstName, string lastName) : base(firstName, lastName)
        {
            this.HoursWorked = HoursWorked;
            this.PayRate = PayRate;
        }

        public void setHoursWorked(int HoursWorked)
        {
            this.HoursWorked = HoursWorked;
        }

        public void setPayRate(double PayRate)
        {
            this.PayRate = PayRate;
        }

        public int getHoursWorked()
        {
            return HoursWorked;
        }

        public double getPayRate()
        {
            return PayRate;
        }

        public void doWork()
        {
            Console.WriteLine($"I've worked {HoursWorked} hours.");
        }
    }
}