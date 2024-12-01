using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.Classes
{
    public abstract class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required(ErrorMessage = "Wachtwoord is verplicht.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Het wachtwoord moet minimaal 8 tekens lang zijn.")]
        public string Wachtwoord { get; set; }

        public Account()
        {
        }
    }
}
