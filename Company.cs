using System;
using System.Collections.Generic;

namespace employeeList
{
    class Company
    {
        public int DateFounded { get; set; }
        public string CompanyName { get; set; }

        public List<Employee> NewEmployee { get; set; }

        /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
        public Company(string companyName, int dateFounded)
        {
            CompanyName = companyName;
            DateFounded = dateFounded;
            NewEmployee = new List<Employee>();

        }

        public void ListEmployee()
        {
            foreach (Employee employee in NewEmployee)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {CompanyName} as {employee.Title} since {DateTime.Now}");
            }
        }
    }

}