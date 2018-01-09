namespace Paper2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecondTable")]
    public partial class SecondTable
    {
        public int CarID { get; set; }

        [Key]
        public int Year { get; set; }

        [Required]
        [StringLength(10)]
        public string Milage { get; set; }
    }
}
