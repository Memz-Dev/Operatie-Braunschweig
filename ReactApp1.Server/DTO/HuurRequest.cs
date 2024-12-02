using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.DTO
{
    public class HuurRequest
    {
        [Required(ErrorMessage = "Naam is verplicht.")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ' -]+$", ErrorMessage = "Naam mag alleen letters, spaties, apostrofs en streepjes bevatten.")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "E-mailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres.")]
        public string EmailAdres { get; set; }

        [Required(ErrorMessage = "Adres is verplicht")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is verplicht.")]
        [Phone(ErrorMessage = "Ongeldig telefoonnummer.")]
        public string Telefoonnummer { get; set; }

        [StringLength(100, MinimumLength = 8, ErrorMessage = "Het wachtwoord moet minimaal 8 tekens lang zijn.")]
        public string Wachtwoord { get; set; }

    }
}
