namespace SampleNamespace
{
    class FullTimeEmployee : Employee
    {
        private int fullTimeHours = 32;
        private bool isFullTime = true;

        public FullTimeEmployee()
        {
            
        }
        public int FullTimeHours
        {
            get { return fullTimeHours; }
        }

        public bool IsFullTime
        {
            get { return isFullTime; }
        }
    }
}