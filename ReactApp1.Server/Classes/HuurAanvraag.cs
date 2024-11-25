using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.Classes
{
    public class HuurAanvraag
    {
        [Key]
        public int huurAanvraagId { get; set; }

        public HuurAanvraag() { }

        public string postcode { get; set; }
        public int huisnummer { get; set; }
        public string straatnaam { get; set; }
        public int rijbewijsnummer { get; set; }
        public string huurreden { get; set; }
        public string eindbestemming { get; set; }
        public int verwachtingreisafstand { get; set; }


        public int accountid { get; set; }  // fk
        public Account account { get; set; }  // nav

    }
}
