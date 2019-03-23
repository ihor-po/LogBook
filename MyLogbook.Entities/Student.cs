using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("students")]
    public class Student:DbEntity
    {
        [Column("first_name")]
        [StringLength(maximumLength: 32, ErrorMessage = "Minimun 2 chars, max 32 chars", MinimumLength = 2)]
        [Required(ErrorMessage = "First Name - cannot be  empty")]
        public string FirstName { get; set; }

        [Column("last_name")]
        [StringLength(maximumLength: 32, ErrorMessage = "Minimun 2 chars, max 32 chars", MinimumLength = 2)]
        [Required(ErrorMessage = "Last Name - cannot be  empty")]
        public string LastName { get; set; }

        [Column("middle_name")]
        [StringLength(maximumLength: 32, ErrorMessage = "Minimun 2 chars, max 32 chars", MinimumLength = 2)]
        [Required(ErrorMessage = "Middle Name - cannot be  empty")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Group - must be selected")]
        public Guid GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
