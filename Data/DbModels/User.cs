using System.ComponentModel.DataAnnotations;

namespace Wallet_API.Data.DbModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public List<Transaction> SentTransactions {  get; set; }
        public User()
        {
                SentTransactions = new List<Transaction>();
        }
    }
}
