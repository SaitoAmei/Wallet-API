using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.NetworkInformation;

namespace Wallet_API.Data.DbModels
{
    public class Transaction
    {
        [Key]
        public int ID { get; set; }

        public int UserId { get; set; }
        public string TransactionType { get; set; }
        public int TransactionAmount { get; set; }

        public string TransactionName { get; set; }
        public string TransactionDescription { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionStatus { get; set; }
        public string TransactionIcon {  get; set; }
        public int? TransactionSenderId { get; set; }
        public User TransactionSender {  get; set; }

    }
}
