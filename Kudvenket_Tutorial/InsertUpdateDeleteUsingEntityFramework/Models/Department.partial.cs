using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsertUpdateDeleteUsingEntityFramework.Models
{
    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department
    {

    }
    public class DepartmentMetadata
    {
        [Display(Name = "Department Name")]
        public string Name { get; set; }    
    }
}