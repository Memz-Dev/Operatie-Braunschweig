using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ReactApp1.Server.Classes
{
    public class HuurdersAccount : Account
    {
        [Required(ErrorMessage = "Naam is verplicht.")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ' -]+$", ErrorMessage = "Naam mag alleen letters, spaties, apostrofs en streepjes bevatten.")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "E-mailadres is verplicht.")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres.")]
        public string EmailAdres { get; set; }

<<<<<<< HEAD
        [Required(ErrorMessage = "Adres is verplicht")]
        public string Adres { get; set; }
=======
>>>>>>> 0dfbf37ca147bc5d1e99d3a60fa67d071ea19358


        [Required(ErrorMessage = "Adres is verplicht.")]
        [RegularExpression(@"^[a-zA-Z0-9À-ÿ.,' -]+$", ErrorMessage = "Adres mag alleen letters, cijfers, spaties en standaard leestekens bevatten.")]
        public string Adres { get; set; }

        [Phone(ErrorMessage = "Ongeldig telefoonnummer.")]
        public string Telefoonnummer { get; set; }

        public ICollection<HuurAanvraag> Aanvragen { get; set; }
    }
}
