namespace WebDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subject")]
    public partial class Subject
    {
        [Key]
        [StringLength(10)]
        public string codeMH { get; set; }

        public int? ST { get; set; }

        [StringLength(20)]
        public string nameMH { get; set; }

        [StringLength(10)]
        public string codeGV { get; set; }
    }
}
