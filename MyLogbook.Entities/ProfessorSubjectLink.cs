using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("professors_subjects_links")]
    public class ProfessorSubjectLink
    {
        [Column("professor_id")]
        public Guid ProfessorId { get; set; }

        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }

        [Column("subject_id")]
        public Guid SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }
    }
}
