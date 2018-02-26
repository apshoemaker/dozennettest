using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DozenNetTest.Domain.Models
{
    [Table("Schools")]
    public class School : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("pkSchoolsKey")]
        public override int Id { get; set; }

        public string Name { get; set; }
    }
}
