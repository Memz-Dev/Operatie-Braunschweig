    namespace ReactApp1.Server.Classes
{
    public abstract class Voertuig
    {
        public int voertuigId { get; set; }
        public string merk { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public int aanschafJaar {  get; set; }
        public string kleur {  get; set; }

        public Voertuig()
        {

        }
    }
}
