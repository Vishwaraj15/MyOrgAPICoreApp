using System;
using System.Collections.Generic;

namespace MyOrgAPICoreApp.Models
{
    public partial class Department
    {
        public int PKDeptId { get; set; }
        public string DeptName { get; set; }
        public bool IsActive { get; set; }
    }
}
