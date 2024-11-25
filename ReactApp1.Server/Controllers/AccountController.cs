using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Classes;

[ApiController]
[Route("api/[controller]")]
public class AccountController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateHuurdersAccount([FromBody] HuurdersAccount account)
    {
        // Hier kun je de accountgegevens verwerken (bijv. opslaan in de database).
        return Ok(new { message = "Account succesvol aangemaakt!", account });
    }
}
