using System;

namespace employeeList
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee()
        {
            StartDate = DateTime.Now;
        }
    }
}