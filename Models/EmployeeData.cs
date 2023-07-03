

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCoreDemo.Models
{
    public class EmployeeData
    {
        [Key]
        public int Employee_id { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Address { get; set; }
      
        public string Qualification { get; set; }
        [ForeignKey("DepartmentData")]
        public int Department_Id { get; set; } 
        public string SkillsSet { get; set; }

        public virtual DepartmentData DepartmentData { get; set; }
    }
}
