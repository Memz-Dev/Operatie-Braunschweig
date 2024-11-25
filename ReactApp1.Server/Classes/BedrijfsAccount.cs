namespace ReactApp1.Server.Classes
{
    public class BedrijfsAccount : Account
    {
        public int bedrijfId { get; set; }
        public string bedrijfsNaam { get; set; }
        public string adres { get; set; }
        public string kvkNummer { get; set; }
        public ICollection<HuurAanvraag> aanvragen { get; set; }
        public BedrijfsAccount() { }

    }
}
