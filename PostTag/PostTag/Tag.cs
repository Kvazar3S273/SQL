using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PostTag
{
    [Table("tblTag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }
        
        [Required, StringLength(255)]
        public string UrlSlug { get; set; }
        
        [Required, StringLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<PostTagMap> PostTagMap { get; set; }
    }
}
