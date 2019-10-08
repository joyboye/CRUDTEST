using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDTEST.Data
{
    public class Departments
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        public string DeptName { get; set; }
        public String DeptLocation { get; set; }
    }
}
