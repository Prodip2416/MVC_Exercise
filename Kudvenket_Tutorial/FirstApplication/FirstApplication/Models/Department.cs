using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FirstApplication.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}