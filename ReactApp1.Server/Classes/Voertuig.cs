 namespace ReactApp1.Server.Classes
{
    public class Voertuig
    {
        public int VoertuigId { get; set; }
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int AanschafJaar {  get; set; }
        public string Kleur {  get; set; }

        public Voertuig()
        {

        }
    }
}
