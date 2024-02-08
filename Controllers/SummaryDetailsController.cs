using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Wallet_API.Common;
using Wallet_API.Data;
using Wallet_API.Data.DbModels;
using static Wallet_API.Common.GlobalVariables;

namespace Wallet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryDetailsController : ControllerBase
    {
        private ApplicationDbContext context;
        public SummaryDetailsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <param name="userId">The ID of current user. Use userId = 1 for test</param>
        /// <returns>Data for blocks "Card Balance", "Daily Points", "No Payment Due"</returns>
        [HttpGet]
        public IActionResult GetSummaryDetails(int? userId)
        {
            if (userId is null)
                return BadRequest("userId cannot be null.");

            if (!context.Users.Any(x => x.Id == userId))
                return Ok("User not found.");

            try
            {
                var cardBalance = context.CardBalances.FirstOrDefault(x => x.UserId == userId);
                var points = CalculateDailyPoints(DateTime.Now);

                var data = new
                {
                    DailyPoints = new
                    {
                        BlockTitle = "Daily Points",
                        DailyPoints = points > 1000 ? $"{points / 1000}K" : points.ToString()
                    },
                    DuePayments = new
                    {
                        BlockTitle = "No Payment Due",
                        Message = GetDuePayments()
                    },
                    CardBalance = new
                    {
                        BlockTitle = "CardBalance",
                        CardBalance = cardBalance.CardBalanceAmount,
                        AvailableFunds = cardBalance.CardLimit - cardBalance.CardBalanceAmount
                    },
                };
                return Ok(data);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        private static string GetDuePayments() => $"You’ve paid your {DateTime.Now.ToString("dddd", System.Globalization.CultureInfo.GetCultureInfo("en-US"))} balance.";

        private int CalculateDailyPoints(DateTime date)
        {
            int points;
            if (date.Month % 3 == 1 && date.Day == 1)
                points = 2;

            else if (date.Month % 3 == 1 && date.Day == 2)
                points = 3;
            else
            {
                int previousDayPoints = CalculateDailyPoints(date.AddDays(-1));
                int twoDaysAgoPoints = CalculateDailyPoints(date.AddDays(-2));

                points = (int)(previousDayPoints + 0.6 * twoDaysAgoPoints);
            }
            return points;
        }
    }
}

