using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wallet_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryDetailsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSummaryDetails()
        {
            return Ok();
        }

        private string GetDuePaiments()
        {
            return $"You’ve paid your {DateTime.Now.Month} balance.";
        }
    }
}

