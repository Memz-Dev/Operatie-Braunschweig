namespace ReactApp1.Server.Classes
{
    public class BedrijfsAccount : Account
    {
        public int BedrijfId { get; set; }
        public string BedrijfsNaam { get; set; }
        public string Adres { get; set; }
        public string KvkNummer { get; set; }
        public ICollection<HuurAanvraag> aanvragen { get; set; }

        public BedrijfsAccount() { }

    }
}
