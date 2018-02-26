namespace WebDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GV")]
    public partial class GV
    {
        [Key]
        [StringLength(20)]
        public string codeGV { get; set; }

        [StringLength(20)]
        public string nameGV { get; set; }

        [StringLength(10)]
        public string codeCN { get; set; }
    }
}
