namespace ReactApp1.Server.Classes
{
    public abstract class Account
    {
        public int accountId { get; set; }
        public string gebruikersNaam { get; set; }
        public string wachtwoord { get; set; }

        public Account() 
        {
            
        }
    }    
    public class HuurdersAccount : Account
    {
        public string Naam {  get; set; }
        public string EmailAdres {  get; set; }
        public string Adres { get; set; }
        public string Telefoonnummer { get; set; }
        public HuurdersAccount() { }



    }
    public class AbonnementsAccount : Account
    {
        public int BedrijfId { get; set; }
        public string BedrijfsNaam { get; set; }
        public string Adres { get; set; }
        public string KvkNummer { get; set; }
        public AbonnementsAccount() { }

    }
    public class BeheerdersAccount: Account
    {
        public BeheerdersAccount() { }
    }
    public class  MedewerkersAccount: Account 
    {
        public string rol {  get; set; }
        public MedewerkersAccount() { }
    }
}
