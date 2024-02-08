using Microsoft.EntityFrameworkCore;
using System;
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
        public DbSet<CardBalance> CardBalances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.TransactionSender)
                .WithMany(u => u.SentTransactions)
                .HasForeignKey(t => t.TransactionSenderId)
                .IsRequired(false);

            modelBuilder.Entity<CardBalance>()
                .HasOne(t => t.User)
                .WithMany(u => u.CardBalances)
                .HasForeignKey(t => t.UserId)
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

            var CardBalances = new List<CardBalance> 
            {
                new CardBalance{Id=1, UserId=1, CardLimit=GlobalVariables.MaxCardLimit,CardBalanceAmount = GenerateCardBalance() },
                new CardBalance{Id=2, UserId=2, CardLimit=GlobalVariables.MaxCardLimit,CardBalanceAmount = GenerateCardBalance() }
            };
            modelBuilder.Entity<CardBalance>().HasData(CardBalances);

            var transactions = GenerateTestTransactions(users);
            modelBuilder.Entity<Transaction>().HasData(transactions);
        }

        private float GenerateCardBalance()
        {
            var random =new Random();
            return (float)(random.Next(100, GlobalVariables.MaxCardLimit + 1)) / 100.0f;
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
                    TransactionDate = i%2==0 ?DateTime.UtcNow: GenerateRandomDateInCurrentMonth(),
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

        private static DateTime GenerateRandomDateInCurrentMonth()
        {
            DateTime currentDate = DateTime.Now;
            var random = new Random();

            int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            int randomDay = random.Next(1, daysInMonth + 1);

            int randomHours = random.Next(24);
            int randomMinutes = random.Next(60);
            int randomSeconds = random.Next(60);

            DateTime randomDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, randomDay, randomHours, randomMinutes, randomSeconds, DateTimeKind.Utc);

            return randomDate;
        }
    }
}
