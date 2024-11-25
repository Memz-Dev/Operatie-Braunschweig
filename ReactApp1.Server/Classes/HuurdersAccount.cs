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
        [Required(ErrorMessage = "Adres is verplicht.")]
        [RegularExpression(@"^[a-zA-Z0-9À-ÿ.,' -]+$", ErrorMessage = "Adres mag alleen letters, cijfers, spaties en standaard leestekens bevatten.")]
        public string Adres { get; set; }
>>>>>>> ac5c10136917391e4906d20c28e12315a35120a7

        [Phone(ErrorMessage = "Ongeldig telefoonnummer.")]
        public string Telefoonnummer { get; set; }

        public ICollection<HuurAanvraag> Aanvragen { get; set; }
    }
}
