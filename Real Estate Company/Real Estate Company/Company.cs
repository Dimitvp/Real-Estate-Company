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

        public Company()
        {
            
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
