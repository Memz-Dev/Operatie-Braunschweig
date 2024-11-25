using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.Classes
{
    public abstract class Account
    {

        [Key]
        public int accountId { get; set; }

        [Required(ErrorMessage = "Gebruikersnaam is verplicht")]
        [StringLength(50, ErrorMessage = "Gebruikersnaam mag niet langer zijn dan 50 tekens")]
        public string gebruikersNaam { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht")]
        [MinLength(8, ErrorMessage = "Wachtwoord moet minstens 8 tekens bevatten")]
        public string wachtwoord { get; set; }
    }

}
