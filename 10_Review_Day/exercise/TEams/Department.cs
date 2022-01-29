using System;
using System.Collections.Generic;
using System.Text;

namespace TEams
{
    class Department
    {
        public Department (int departmentId, string name)
        {
            DepartmentId = departmentId;
            Name = name;
        }


        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
}
