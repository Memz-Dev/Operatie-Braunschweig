using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
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

        [Required(ErrorMessage = "Adres is verplicht")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is verplicht.")]
        [Phone(ErrorMessage = "Ongeldig telefoonnummer.")]
        public string Telefoonnummer { get; set; }

        public ICollection<HuurAanvraag> Aanvragen { get; set; } = new List<HuurAanvraag>();
    }
}
