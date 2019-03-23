using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("subjects")]
    public class Subject : DbEntity
    {
        [Column("title")]
        [StringLength(maximumLength: 32, ErrorMessage = "Minimun 2 chars, max 32 chars", MinimumLength = 2)]
        [Required(ErrorMessage = "Title - cannot be  empty")]
        public string Title { get; set; }

        public virtual ICollection<ProfessorSubjectLink> ProfessorSubjectLink { get; set; }
        public virtual ICollection<GroupSubjectLink> GroupSubjectLink { get; set; }
    }
}
