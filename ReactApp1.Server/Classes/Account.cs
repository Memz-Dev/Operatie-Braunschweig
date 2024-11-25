using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.Classes
{
    public abstract class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Het wachtwoord moet minimaal 8 tekens lang zijn.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$",
         ErrorMessage = "Het wachtwoord moet minimaal één hoofdletter, één kleine letter, één cijfer en één speciaal teken bevatten.")]
        public string Wachtwoord { get; set; }

        public Account()
        {
        }
    }
}
