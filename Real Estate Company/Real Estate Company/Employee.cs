namespace Real_Estate_Company
{
    public class Employee
    {
        private string name;
        private string occupation;
        private double workingЕxperience;

        public Employee(string name, string occupation, double workingЕxperience)
        {
            this.Name = name;
            this.Occupation = occupation;
            this.WorkingExperience = workingЕxperience;
        }

        public string Name {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Occupation {
            get { return this.occupation; }
            private set { this.occupation = value; }
        }

        public double WorkingExperience {
            get { return this.workingЕxperience; }
            private set { this.workingЕxperience = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Occupation}, {this.WorkingExperience}";
        }
    }
}
