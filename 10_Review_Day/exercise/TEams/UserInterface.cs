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
        Dictionary<string, Project> projects = new Dictionary<string, Project>();
        



        public void Run()
        {


            // create some departments
               CreateDepartments();

            // print each department by name
            PrintDepartments();

            // create employees
            CreateEmployees();

            // give Angie a 10% raise, she is doing a great job!
            Employee angie = employeeList[1];
            angie.RaiseSalary(10);

            

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
            Project project1 = new Project("TEams", "Project Management Software", "10/10/2020", "11/10/2020");

            List<Employee> engineers = new List<Employee>();

            engineers.Add(employeeList[0]);
            engineers.Add(employeeList[1]);

            //project1.TeamMembers.Add(employeeList[0]);
            //project1.TeamMembers.Add(employeeList[1]);

            project1.TeamMembers = engineers;

            projects.Add("TEams", project1);

        }

        /**
         * Create the 'Marketing Landing Page' project.
         */


        private void CreateLandingPageProject()
        {
            Project project2 = new Project("Marketing Landing Page", "Lead Capture Landing for Marketing", "10/10/2020", "10/17/2020");
            //project2.TeamMembers.Add(employeeList[2]);


            List<Employee> marketers = new List<Employee>();

            marketers.Add(employeeList[2]);

            project2.TeamMembers = marketers;




            projects.Add("Marketing Landing Page", project2);
        }

        /**
         * Print out each project in the collection.
         */
        private void PrintProjectsReport()
        {
            Console.WriteLine("\n------------- PROJECTS ------------------------------");
            foreach (KeyValuePair<string,Project> projectName in projects)
            {
                
            Console.WriteLine(projectName.Key + ":" + projectName.Value.TeamMembers.Count);
                
                
                
               
            }
        }
    }
}
