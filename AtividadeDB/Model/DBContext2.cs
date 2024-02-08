using Microsoft.EntityFrameworkCore;

namespace AtividadeDB.Model
{
    public class DBContext2 : DbContext
    {
        public DbSet<Pessoas> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            IConfigurationRoot Configuration = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
            .Build();

            var ConnectionString = Configuration.GetConnectionString("MariaDB");
            OptionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));
        }
    }
}
