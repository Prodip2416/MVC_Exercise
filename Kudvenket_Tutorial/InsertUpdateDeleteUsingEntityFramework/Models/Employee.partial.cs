using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsertUpdateDeleteUsingEntityFramework.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
    }

    public class EmployeeMetadata
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Display(Name="Department")]
        public int DepartmentId { get; set; } 
    }
}   