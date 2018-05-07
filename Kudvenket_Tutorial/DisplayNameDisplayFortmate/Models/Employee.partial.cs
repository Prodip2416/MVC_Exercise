using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DisplayNameDisplayFortmate.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
    }

    public class EmployeeMetadata
    {
        [DataType(DataType.Url)]
        [UIHint("OpenNewPage")]
        public string PersonalWebSite { get; set; } 
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }    
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        //[DisplayFormat(DataFormatString = "{0:d}")]
       // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
        [DataType(DataType.Time)]
        public DateTime? HireDate { get; set; }
        [DisplayFormat(NullDisplayText = "Gender Not Specified")]
        public string Gender { get; set; }
        [ScaffoldColumn(false)]
        public int? Salary { get; set; } 
    }
}