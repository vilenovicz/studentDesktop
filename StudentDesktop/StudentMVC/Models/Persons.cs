namespace StudentMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Persons
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public int? DepartmentId { get; set; }

        public virtual Departments Departments { get; set; }
    }
}
