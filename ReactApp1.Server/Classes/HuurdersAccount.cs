namespace ReactApp1.Server.Classes
{
    public class HuurdersAccount : Account
    {
        public string Naam { get; set; }
        public string EmailAdres { get; set; }
        public string Adres { get; set; }
        public string Telefoonnummer { get; set; }

        public ICollection<HuurAanvraag> aanvragen { get; set; }

        public HuurdersAccount() { }

    }
}
