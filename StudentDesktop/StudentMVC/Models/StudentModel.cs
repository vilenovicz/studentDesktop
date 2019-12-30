namespace StudentMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModelConnection")
        {
        }

        public virtual DbSet<Competences> Competences { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competences>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Competences)
                .HasForeignKey(e => e.CompetenceId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Departments>()
                .HasMany(e => e.Persons)
                .WithOptional(e => e.Departments)
                .HasForeignKey(e => e.DepartmentId);
        }
    }
}
