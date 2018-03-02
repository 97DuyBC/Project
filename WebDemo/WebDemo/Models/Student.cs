namespace WebDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
    
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(10)]
        public string codeSV { get; set; }

        [StringLength(30)]
        public string fullName { get; set; }

        public DateTime? birthday { get; set; }

        [StringLength(10)]
        public string codeCN { get; set; }
    }
}
