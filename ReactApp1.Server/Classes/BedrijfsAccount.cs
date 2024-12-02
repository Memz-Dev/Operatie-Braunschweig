using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.Classes
{
    public class BedrijfsAccount : Account
    {
        [Required]
        public int bedrijfId { get; set; }

        [Required(ErrorMessage = "Bedrijfsnaam is verplicht")]
        [StringLength(255, ErrorMessage = "Bedrijfsnaam mag niet langer zijn dan 255 tekens")]
        public string bedrijfsNaam { get; set; }

        [Required(ErrorMessage = "Adres is verplicht")]
        [StringLength(255, ErrorMessage = "Adres mag niet langer zijn dan 255 tekens")]
        public string bedrijfAdres { get; set; }

        [Required(ErrorMessage = "KvK-nummer is verplicht")]
        [StringLength(20, ErrorMessage = "KvK-nummer mag niet langer zijn dan 20 tekens")]
        public string kvkNummer { get; set; }

        public ICollection<HuurAanvraag> aanvragen { get; set; }
    }
}
