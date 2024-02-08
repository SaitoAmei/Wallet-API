
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
        /// <param name="userId">The ID of current user. Use userId = 1 for test</param>
        /// <returns>Transaction List</returns>
        [HttpGet]
        public IActionResult GetTransactionList(int? userId)
        {
            if (userId == null)
                return BadRequest("userId cannot be null.");

            if (!context.Users.Any(x => x.Id == userId))
                return Ok("User not found.");

            try
            {
                var transactions = context.Transactions.Include(x => x.TransactionSender).Where(x => x.UserId == userId).Take(10).Select(x =>
                new
                {
                    TransactionId = x.ID,
                    TransactionName = x.TransactionName,
                    Description = x.TransactionType == "Payment" ? $"{x.TransactionType} - {x.TransactionDescription}" : "",
                    TransactionAmount = x.TransactionType == "Payment" ? $"+{x.TransactionAmount}" : x.TransactionAmount.ToString(),
                    Date = ProcessDate(x),
                    TransactionIcon = x.TransactionIcon


                });

                return Ok(transactions);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
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
