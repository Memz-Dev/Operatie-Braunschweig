namespace ReactApp1.Server.Classes
{
    public class HuurAanvraag
    {
        public int verzoekId { get; set; }



        public string postcode { get; set; }
        public int huisNummer { get; set; }
        public string straatNaam { get; set; }
        public int rijbewijsNummer  { get; set; }
        public string huurReden { get; set; }
        public string eindBestemming { get; set; }
        public int verwachtingReisAfstand { get; set; }


        public int accountId { get; set; }  // FK
        public Account account { get; set; }  // Nav

    }
}
