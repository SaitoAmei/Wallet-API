using Microsoft.EntityFrameworkCore;

namespace Wallet_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

    }
}
