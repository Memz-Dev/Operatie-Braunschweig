using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Classes;

namespace ReactApp1.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        // POST: api/Account/create-huurdersaccount
        [HttpPost("create-huurdersaccount")]
        public IActionResult CreateHuurdersAccount([FromBody] HuurdersAccount account)
        {
            if (ModelState.IsValid)
            {
                // Hier voeg je de logica toe voor het opslaan van een HuurdersAccount.
                return Ok(new { message = "Huurdersaccount succesvol aangemaakt!", account });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Account/create-bedrijfsaccount
        [HttpPost("create-bedrijfsaccount")]
        public IActionResult CreateBedrijfsAccount([FromBody] BedrijfsAccount account)
        {
            if (ModelState.IsValid)
            {
                // Hier voeg je de logica toe voor het opslaan van een BedrijfsAccount.
                return Ok(new { message = "Bedrijfsaccount succesvol aangemaakt!", account });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Account/create-medewerkersaccount
        [HttpPost("create-medewerkersaccount")]
        public IActionResult CreateMedewerkersAccount([FromBody] MedewerkersAccount account)
        {
            if (ModelState.IsValid)
            {
                // Hier voeg je de logica toe voor het opslaan van een MedewerkersAccount.
                return Ok(new { message = "Medewerkersaccount succesvol aangemaakt!", account });
            }

            return BadRequest(ModelState);
        }

        // POST: api/Account/create-beheerdersaccount
        [HttpPost("create-beheerdersaccount")]
        public IActionResult CreateBeheerdersAccount([FromBody] BeheerdersAccount account)
        {
            if (ModelState.IsValid)
            {
                // Hier voeg je de logica toe voor het opslaan van een BeheerdersAccount.
                return Ok(new { message = "Beheerdersaccount succesvol aangemaakt!", account });
            }

            return BadRequest(ModelState);
        }

        // GET: api/Account/{accountType}/{id}
        [HttpGet("{accountType}/{id}")]
        public IActionResult GetAccount(string accountType, int id)
        {
            // Voeg logica toe om een account op te halen op basis van accountType en ID.
            // Bijvoorbeeld: "HuurdersAccount", "BedrijfsAccount", etc.
            return Ok(new { message = $"Account van type {accountType} met ID {id} opgehaald." });
        }

        // DELETE: api/Account/{accountType}/{id}
        [HttpDelete("{accountType}/{id}")]
        public IActionResult DeleteAccount(string accountType, int id)
        {
            // Voeg logica toe om een account te verwijderen op basis van accountType en ID.
            return Ok(new { message = $"Account van type {accountType} met ID {id} verwijderd." });
        }
    }
}
