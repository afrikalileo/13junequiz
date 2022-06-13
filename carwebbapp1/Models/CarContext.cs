using Microsoft.EntityFrameworkCore;

namespace carwebbapp1.Models


{
    public class CarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database = Carslist ; Trusted_Connection = True;");

        }

        public DbSet<Car> Carslist { get; set; }

        
    }
}
