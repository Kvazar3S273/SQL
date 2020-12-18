using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PostTag
{
    [Table("tblPost")]
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Title { get; set; }

        [Required, StringLength(255)]
        public string ShortDescription { get; set; }
        
        [Required, StringLength(2000)]
        public string Description { get; set; }
        
        [Required, StringLength(5000)]
        public string Meta { get; set; }
        
        [Required, StringLength(255)]
        public string UrlSlug { get; set; }
        
        public bool Published { get; set; }
        public DateTime PostedOn { get; set; }
        public DateTime Modified { get; set; }
        
        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<PostTagMap> PostTagMap { get; set; }

    }
}
