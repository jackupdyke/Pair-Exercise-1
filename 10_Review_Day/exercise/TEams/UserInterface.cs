using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class UserInterface
    {
        Department departments = 0;


        List<Department> departmentList = new List<Department>();
            


        public void Run()
        {
            // create some departments
               CreateDepartments();

            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!


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

            Console.WriteLine(departmentList);

        }

        /**
         * Create employees and add them to the collection of employees
         */
        private void CreateEmployees()
        {

        }

        /**
         * Print out each employee in the collection.
         */
        private void PrintEmployees()
        {
            Console.WriteLine("\n------------- EMPLOYEES ------------------------------");

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
