using Microsoft.EntityFrameworkCore;
using Wallet_API.Common;
using Wallet_API.Data.DbModels;

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


        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.TransactionSender)
                .WithMany(u => u.SentTransactions)
                .HasForeignKey(t => t.TransactionSenderId)
                .IsRequired(false); 

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var users = new List<User>
        {
            new User { Id = 1, Name = "Common User", IsActive = true },
            new User { Id = 2, Name = "Jane Doe", IsActive = true }
        };

            modelBuilder.Entity<User>().HasData(users);

            var transactions = GenerateTestTransactions(users);
            modelBuilder.Entity<Transaction>().HasData(transactions);
        }

        private List<Transaction> GenerateTestTransactions(List<User> users)
        {
            var transactions = new List<Transaction>();
            var random = new Random();


            for (int i = 1; i < 30; i++)
            {
                var transaction = new Transaction
                {
                    ID = i + 1,
                    UserId = 1,
                    TransactionType = random.Next(2) == 0 ? "Payment" : "Credit",
                    TransactionAmount = random.Next(100, 1000),
                    TransactionName = $"Transaction {i + 1} for {users.FirstOrDefault()?.Name}",
                    TransactionDescription = $"Description for Transaction {i + 1}",
                    TransactionDate = DateTime.UtcNow,
                    TransactionStatus = random.Next(3) == 0 ? "Pending" : "Completed",
                    TransactionIcon = GenerateRandomIcon(),
                    TransactionSenderId = i%3 == 1 ? 2:null
                };

                transactions.Add(transaction);
            }
            

            return transactions;
        }

        private string GenerateRandomIcon()
        {
            Random random = new Random();
            string randomBackground = GlobalVariables.CommonImageBackgrounds[random.Next(GlobalVariables.CommonImageBackgrounds.Length)];
            string randomIcon = GlobalVariables.StandardIcons[random.Next(GlobalVariables.StandardIcons.Length)];

            return $"{randomBackground} {randomIcon}";
        }
    }
}
