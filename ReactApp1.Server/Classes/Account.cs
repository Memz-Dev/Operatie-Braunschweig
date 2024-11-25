using System.ComponentModel.DataAnnotations;

namespace ReactApp1.Server.Classes
{
    public abstract class Account
    {
        [Key]
        public int accountId { get; set; }
        public string gebruikersNaam { get; set; }
        public string wachtwoord { get; set; }

        public Account() 
        {
            
        }
    }
}
