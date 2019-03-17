using MyLogbook.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLogbook.Entities
{
    [Table("faculties")]
    public class Faculty:DbEntity
    {
        [Column("title")]
        [StringLength(64)]
        public string Title { get; set; }
       
        public virtual List<Group> Groups { get; set; }
    }
}
