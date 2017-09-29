namespace ProjectSampleEntityFramework
{
    using System.Data.Entity;

    public partial class Model : DbContext
    {
        public Model(string connectionString)
            : base(connectionString)
        {
        }

        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual DbSet<OCCUPATION> OCCUPATIONS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
