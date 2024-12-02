using Microsoft.Exchange.WebServices.Data;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
//using System.Web.Mvc;
using ReactApp1.Server.DTO;
using ReactApp1.Server.Classes;

namespace ReactApp1.Server.Functions
{
    public class HuurAccountService
    {
        private readonly HashFunction _hashFunction;
        private readonly DatabaseContext _databaseContext;

        public HuurAccountService(HashFunction hashFunction, DatabaseContext databaseContext)

        {
            _hashFunction = hashFunction;
            _databaseContext = databaseContext;
        }
      public async Task<ServiceResult> CreateHuurderAsync(HuurRequest request)
        {
            var user = new HuurdersAccount
            {
                Naam = request.Naam,
                EmailAdres = request.EmailAdres,
                Adres = request.Adres,
                Telefoonnummer = request.Telefoonnummer,
            };
            user.Wachtwoord = _hashFunction.CreateHash(request.Wachtwoord);

            await _databaseContext.HuurdersAccounts.AddAsync(user);
            await _databaseContext.SaveChangesAsync();

            return ServiceResult.Success;
        }
    }
}
