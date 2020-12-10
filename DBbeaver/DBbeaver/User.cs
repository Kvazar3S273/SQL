using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hospital
{
    [Table("tblUsers")]
    class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(255)]
        public string Name { get; set; }
        
        [StringLength(10)]
        public string Phone { get; set; }

        [Required]
        public int Age { get; set; }

        public int Weight { get; set; }

        public int Footsize { get; set; }

        [Required]
        public byte Sex { get; set; }
    }
}