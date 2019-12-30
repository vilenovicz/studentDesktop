namespace StudentMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Courses
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public int CompetenceId { get; set; }

        public int? StatusId { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateFrom { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateTo { get; set; }

        public virtual Competences Competences { get; set; }
    }
}
