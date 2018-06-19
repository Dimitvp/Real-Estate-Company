namespace Real_Estate_Company
{
    public class Employee
    {
        private string name;
        private string occupation;
        private double workingЕxperience;

        public Employee(string name, string occupation, double workingExperience)
        {
            this.Name = name;
            this.Occupation = occupation;
            this.WorkingExperience = workingЕxperience;
        }

        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Occupation {
            get { return this.occupation; }
            set { this.occupation = value; }
        }

        public double WorkingExperience {
            get { return this.workingЕxperience; }
            set { this.workingЕxperience = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
