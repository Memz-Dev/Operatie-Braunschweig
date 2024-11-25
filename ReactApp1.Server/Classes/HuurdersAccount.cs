using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.Classes
{
    public class HuurdersAccount : Account
    {
        [Required(ErrorMessage = "Naam is verplicht")]
        public string Naam { get; set; }

        [Required(ErrorMessage = "Emailadres is verplicht")]
        [EmailAddress(ErrorMessage = "Ongeldig e-mailadres")]
        public string EmailAdres { get; set; }


        [Required(ErrorMessage = "Adres is verplicht")]
        public string Adres { get; set; }


        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        [Phone(ErrorMessage = "Ongeldig telefoonnummer")]
        public string Telefoonnummer { get; set; }
    }
}
