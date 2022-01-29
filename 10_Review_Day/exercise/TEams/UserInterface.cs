using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class UserInterface
    {
        Department departments;


        List<Department> departmentList = new List<Department>();
        List<Employee> employeeList = new List<Employee>();



        public void Run()
        {
            // create some departments
               CreateDepartments();

            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!
            employeeList[1].RaiseSalary(10);
            


            // print all employees
            PrintEmployees(); 

            // create the TEams project
            CreateTeamsProject();

            // create the Marketing Landing Page Project
            CreateLandingPageProject();

            // print each project name and the total number of employees on the project
            PrintProjectsReport();
        }

        /**
         * Create departments and add them to the collection of departments
         */

        



        
        private void CreateDepartments()
        {
            Department department1 = new Department(1, "Marketing");
            departmentList.Add(department1);
            Department department2 = new Department(2, "Sales");
            departmentList.Add(department2);
            Department department3 = new Department(3, "Engineering");
            departmentList.Add(department3);
        }

        /**
         * Print out each department in the collection.
         */
        private void PrintDepartments()
        {
            Console.WriteLine("------------- DEPARTMENTS ------------------------------");

            foreach (Department department in departmentList)
            {
                Console.WriteLine(department.Name);
            }


            
               

        }

        /**
         * Create employees and add them to the collection of employees
         */
        private void CreateEmployees()
        {
            Employee employee1 = new Employee();

            employee1.EmployeeId = 1;
            employee1.FirstName = "Dean";
            employee1.LastName = "Johnson";
            employee1.Email = "djohnson@teams.com";
            employee1.Salary = 60000;
            employee1.Department = departmentList[2];
            employee1.HireDate = "08/21/2020";
            employeeList.Add(employee1);


            Employee employee2 = new Employee(2, "Angie", "Smith", "asmith@teams.com", departmentList[2], "08/21/20" );

            employeeList.Add(employee2);
           
            Employee employee3 = new Employee(3, "Margaret", "Thompson", "mthompson@teams.com", departmentList[0], "08/21/20");

            employeeList.Add(employee3);






        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee.FullName + " " + employee.Salary + " " + employee.Department.Name);
            }
        }

        /**
         * Create the 'TEams' project.
         */
        private void CreateTeamsProject()
        {

        }

        /**
         * Create the 'Marketing Landing Page' project.
         */
        private void CreateLandingPageProject()
        {

        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");

        }
    }
}
