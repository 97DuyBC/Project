namespace WebDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Specialized")]
    public partial class Specialized
    {
        [Key]
        [StringLength(10)]
        public string codeCN { get; set; }

        [StringLength(10)]
        public string nameCN { get; set; }
    }
}
