using System.Collections.Generic;

namespace Real_Estate_Company
{
    public class Company
    {
        private string name;
        private string ownerName;
        private string UIC;
        private List<Employee> employees;
        private List<RealEstate> realEstates;

        public Company(string name)
        {
            this.Name = name;
        }

        public string Name {
            get { return this.name; }
            set {this.name = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
