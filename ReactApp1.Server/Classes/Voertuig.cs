<<<<<<< HEAD
﻿ namespace ReactApp1.Server.Classes
=======
﻿    namespace ReactApp1.Server.Classes
>>>>>>> eaea136742fe919a6ff3357821bb79972f6a67fb
{
    public abstract class Voertuig
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
