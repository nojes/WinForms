using System.Data.Entity;

namespace DataLayer.DbLayer
{
    public partial class HumanContext : DbContext
    {
        public HumanContext()
            : base("name=HumanContext")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmpPromotion> EmpPromotions { get; set; }
        public virtual DbSet<JobTitle> JobTitles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.INN)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmpPromotions)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpPromotion>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<JobTitle>()
                .HasMany(e => e.EmpPromotions)
                .WithRequired(e => e.JobTitle)
                .WillCascadeOnDelete(false);
        }
    }
}
