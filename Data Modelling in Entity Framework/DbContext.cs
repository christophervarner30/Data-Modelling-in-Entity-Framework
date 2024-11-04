namespace Data_Modelling_in_Entity_Framework
{
    public class DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your actual connection string
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=YourDatabaseName;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the many-to-many relationship (important!)
            modelBuilder.Entity<Like>()
                        .HasMany(c => c.Likes)
                        .WithMany(I => I.Customers)
                        .UsingEntity(j => j.ToTable("CustomerLikes")); // Creates a join table
        }
    }
}