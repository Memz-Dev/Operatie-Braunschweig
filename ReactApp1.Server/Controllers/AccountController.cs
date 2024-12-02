using Microsoft.AspNetCore.Mvc;
using ReactApp1.Server.Classes;

namespace ReactApp1.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AccountController : ControllerBase
    {
        private readonly DatabaseContext _context;

        private readonly EmailService _emailService;  // Voeg de emailservice toe

        // Constructor
        public AccountController(DatabaseContext context)
        {
            _context = context;
            _emailService = new EmailService();  // Initialiseer de emailservice
        }

        // POST: api/Account/create-huurdersaccount
        [HttpPost("create-huurdersaccount")]
        public async Task<IActionResult> CreateHuurdersAccount([FromBody] HuurdersAccount account)
        {
            if (ModelState.IsValid)
            {
                await _context.HuurdersAccounts.AddAsync(account);
                await _context.SaveChangesAsync();

                // Stuur een bevestigingsmail
                _emailService.SendEmail(account.EmailAdres, "Bevestiging van je account",
                    $"<h1>Welkom, {account.Naam}!</h1><p>Je huurdersaccount is succesvol aangemaakt.</p>");

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
        public async Task<IActionResult> GetAccount(string accountType, int id)
        {
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
