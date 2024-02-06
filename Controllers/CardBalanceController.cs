using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wallet_API.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Wallet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardBalanceController : ControllerBase
    {

        [HttpGet (Name ="GetCardBalance")]
        public IActionResult GetCardBalance(int userId)
        {
            var random = new Random();
            float cardBalance = (float)(random.Next(100, GlobalVariables.MaxCardLimit + 1)) / 100.0f;
            return Ok(new
            {
                BlockTitle = "CardBalance",
                CardBalance = cardBalance,
                AvailableFunds = GlobalVariables.MaxCardLimit - cardBalance
            });

        }

        //[HttpGet]
        //public IActionResult GetDuePayments() 
        //{
        //    return Ok(new {Message = $"You’ve paid your {DateTime.Now.Month} balance." });
        //}

        //[HttpGet(Name = "GetPoints")]

       

    }
}
