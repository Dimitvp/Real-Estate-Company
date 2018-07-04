namespace Real_Estate_Company
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Company
    {
        private string name;
        private string ownerName;
        private string uic;
        private List<Employee> employees;
        private List<RealEstate> realEstates;

        public Company(string name, string ownerName, string uic, List<Employee> employees, List<RealEstate> realEstates)
        {
            this.Name = name;
            this.OwnerName = ownerName;
            this.UIC = uic;
            this.employees = employees;
            this.realEstates = realEstates;
        }

        public string Name {
            get { return this.name; }
            private set {this.name = value; }
        }

        public string OwnerName {
            get { return this.ownerName; }
            private set { this.ownerName = value; } }

        public string UIC {
            get { return this.uic; }
            private set { this.uic = value; } }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{this.Name}, {this.OwnerName}, {this.UIC}");
            sb.AppendLine(string.Join(Environment.NewLine, this.employees.Select(e => e)));
            sb.AppendLine(string.Join(Environment.NewLine, this.realEstates.Select(r => r)));

            return sb.ToString();
        }
    }
}
