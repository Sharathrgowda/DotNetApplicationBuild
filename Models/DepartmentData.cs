using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCCoreDemo.Models
{
    public class DepartmentData
    {

        [Key]
        public int Department_Id { get; set; }
        public string Department_Name { get; set; }

        //public virtual List<EmployeeData> EmployeeData { get; set; }
    }
}
