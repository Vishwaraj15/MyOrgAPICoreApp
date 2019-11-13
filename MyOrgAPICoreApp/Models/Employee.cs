using System;
using System.Collections.Generic;

namespace MyOrgAPICoreApp.Models
{
    public partial class Employee
    {
        public int PKEmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public int FKDeptId { get; set; }
    }
}
