using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("professors_groups_links")]
    public class ProfessorGroupLink
    {
        [Column("group_id")]
        public Guid GroupId { get; set; }

        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; }

        [Column("professor_id")]
        public Guid ProfessorId { get; set; }

        [ForeignKey("ProfessorId")]
        public virtual Professor Professor { get; set; }
    }
}
