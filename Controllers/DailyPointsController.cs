using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wallet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyPointsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDailyPoints()
        {
            var points = CalculateDailyPoints(DateTime.Now);
            return Ok(new {BlockTitle = "Daily Points", DailyPoints= points>1000 ? $"{points/1000}K": points.ToString() });
        }

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

                points = (int)(1.0 * previousDayPoints + 0.6 * twoDaysAgoPoints);
            }
            return points;
        }

    }
}
