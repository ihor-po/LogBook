using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("groups")]
    public class Group : DbEntity
    {
        [Column("title")]
        [StringLength(64)]
        public string Title { get; set; }
        public Guid FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public virtual Faculty Faculty { get; set; }
        //public virtual List<Student> Students { get; set; }
    }
}
