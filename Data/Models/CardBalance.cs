using System.ComponentModel.DataAnnotations;

namespace Wallet_API.Data.DbModels
{
    public class CardBalance
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public float CardBalanceAmount { get; set; }
        public float CardLimit { get; set; }
        public User User { get; set; }
    }
}
