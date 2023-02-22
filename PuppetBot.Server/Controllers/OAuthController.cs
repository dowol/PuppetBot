using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PuppetBot.Server.Controllers
{
    [Route("oauth")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        [HttpGet("twitch")]
        public IActionResult GetOAuthFromTwitch([FromQuery]string? token)
        {
            if (string.IsNullOrWhiteSpace(token))
            {
                return NotFound();
            }
            else
            {
#if DEBUG
                return Ok($"Your Twitch OAuth2 token is '{token}'.");
#else
                return NoContent();
#endif
            }
        }
    }
}
