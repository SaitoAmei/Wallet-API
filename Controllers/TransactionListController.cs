
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using Wallet_API.Data;
using Wallet_API.Data.DbModels;

namespace Wallet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionListController : ControllerBase
    {
        private ApplicationDbContext context;
        public TransactionListController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetTransactionList(int? userId)
        {
            if (userId == null)
                return NotFound();

            var transactions = context.Transactions.Include(x=> x.TransactionSender).Where(x => x.UserId == userId).Take(10).Select(x =>
            new
            {
                TransactionName = x.TransactionName,
                Description = x.TransactionType == "Payment" ? $"{x.TransactionType} - {x.TransactionDescription}" : "",
                TransactionAmount = x.TransactionType == "Payment" ? $"+{x.TransactionAmount}" : x.TransactionAmount.ToString(),
                Date = ProcessDate(x),
                TransactionIcon = x.TransactionIcon


            });

            return Ok(transactions);
        }

        private static string ProcessDate(Transaction transaction)
        {
            string result = "";
            if (DateTime.Now.AddDays(-7) < transaction.TransactionDate)
            {
                result += transaction.TransactionDate.ToString("dddd", CultureInfo.GetCultureInfo("en-US"));
            }
            else
            {
                result += transaction.TransactionDate.ToString("yyyy/MM/dd"); 
            }

            if (transaction.TransactionSenderId != null)
            {
                result = $"{transaction.TransactionSender.Name} - {result}";
            }
            return result;
        }

    }
}
