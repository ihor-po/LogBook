using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("departments")]
    public class Department : DbEntity
    {
        [Column("title")]
        [StringLength(64)]
        [Required(ErrorMessage = "Title - cannot be empty")]
        public string Title { get; set; }

        public Guid FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public virtual Faculty Faculty { get; set; }

        public virtual List<Professor> Professors { get; set; }
    }
}
