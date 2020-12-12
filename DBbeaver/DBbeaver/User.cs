using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Hospital
{
    [Table("tblUsers")]
    public class User
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

        public override string ToString()
        {
            string info;

            if (Sex == 0)
            {
                info = $" {Id,-3} {Name,-15}    жін     {Age,-3}   {Weight,-3}     {Footsize,-3}     {Phone,-10}";
            }
            else if (Sex == 1)
            {
                info = $" {Id,-3} {Name,-15}    чол     {Age,-3}   {Weight,-3}     {Footsize,-3}     {Phone,-10}";
            }
            else
            {
                info = $" {Id,-3} {Name,-15}    ---     {Age,-3}   {Weight,-3}     {Footsize,-3}     {Phone,-10}";
            }
            return info;
        }
    }
    
}