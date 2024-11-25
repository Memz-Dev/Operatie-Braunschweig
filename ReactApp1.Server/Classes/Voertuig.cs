<<<<<<< HEAD
﻿ namespace ReactApp1.Server.Classes
=======
﻿    namespace ReactApp1.Server.Classes
>>>>>>> eaea136742fe919a6ff3357821bb79972f6a67fb
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
