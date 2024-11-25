namespace ReactApp1.Server.Classes
{
    public class HuurdersAccount : Account
    {
        public string naam { get; set; }
        public string emailAdres { get; set; }
        public string adres { get; set; }
        public string telefoonnummer { get; set; }

        public ICollection<HuurAanvraag> aanvragen { get; set; }

        public HuurdersAccount() { }

    }
}
