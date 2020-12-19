using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBbeaver.DAL
{
    [Table("tblDepartments")]
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }

        public override string ToString()
        {
            string info;
            info = $"{ Id,-3} {Name,-12}";
            return info;
        }
    }

}
