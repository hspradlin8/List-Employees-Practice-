using System;
using System.Collections.Generic;

namespace employeeList
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company CatCity = new Company("CatCity", 3 - 26 - 1999);

            // Create three employees
            Employee Garfield = new Employee()
            {
                FirstName = "Garfield",
                LastName = "Burger",
                Title = "Main Cat",
                // StartDate = DateTime.Now

            };

            Employee Felix = new Employee()
            {
                FirstName = "Felix",
                LastName = "Slick",
                Title = "CFO"
            };

            Employee Heathcliff = new Employee()
            {
                FirstName = "Heathcliff",
                LastName = "Segura",
                Title = "WaterChamp"
            };

            Employee Robert = new Employee()
            {
                FirstName = "Robert",
                LastName = "Champange",
                Title = "Video Master"
            };
            // Assign the employees to the company

            CatCity.NewEmployee.Add(Garfield);
            CatCity.NewEmployee.Add(Felix);
            CatCity.NewEmployee.Add(Heathcliff);
            CatCity.NewEmployee.Add(Robert);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            CatCity.ListEmployee();
        }
    }
}