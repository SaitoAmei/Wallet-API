using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wallet_API.Data;

namespace Wallet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionDetailsController : ControllerBase
    {
        private ApplicationDbContext context;
        public TransactionDetailsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <param name="transactionId">The ID of current transaction. Use TransactionDetails method to get list of transactions</param>
        /// <returns>Transaction Details</returns>
        [HttpGet]
        public IActionResult GetTransactionDetails(int? transactionId)
        {
            if (transactionId is null)
                return BadRequest("transactionId cannot be null.");

            try
            {
                var data = context.Transactions
                    .Where(x => x.ID == transactionId)
                    .Select(x => new
                    {
                        Name = x.TransactionName,
                        Status = x.TransactionStatus,
                        Description = x.TransactionDescription,
                        Amount = x.TransactionAmount,
                        Date = x.TransactionDate.ToString("g"),


                    }).FirstOrDefault();

                if (data == null)
                    return Ok("Transaction not found.");

                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
