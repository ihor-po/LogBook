using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("marks")]
    public class Mark
    {
        [Column("student_id")]
        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [Column("subject_id")]
        public Guid SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        [Column("mark")]
        [Required]
        [Range(minimum: 1, maximum:12)]
        public virtual int StudentMark { get; set; }
    }
}
