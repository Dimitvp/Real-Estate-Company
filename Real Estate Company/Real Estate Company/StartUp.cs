namespace Real_Estate_Company
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main(string[] args)
        {
            
            RealEstate apartment = new Apartment(100.5, 800.0, "Sofia", 5, true, true);
            RealEstate house = new House(500.5, 900.0, "Bailovo", 100.6, 300.0, 3, true);

            Employee employee1 = new Employee("Dimi", "Owner", 2.1);

            var allRealEstate = new List<RealEstate>();
            var allEmployees = new List<Employee>();

            allRealEstate.Add(apartment);
            allRealEstate.Add(house);

            allEmployees.Add(employee1);

            Company realEstateHeaven = new Company("Heaven","Dimi", "3145234134", allEmployees, allRealEstate);

            Console.WriteLine(realEstateHeaven);
        }
    }
}
