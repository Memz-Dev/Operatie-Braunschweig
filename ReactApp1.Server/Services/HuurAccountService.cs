using Microsoft.Exchange.WebServices.Data;
using ReactApp1.Server.DTO;
using ReactApp1.Server.Classes;

namespace ReactApp1.Server.Services
{
    public class HuurAccountService
    {
        private readonly HashingService _hashFunction;
        private readonly DatabaseContext _databaseContext;

        public HuurAccountService(HashingService hashFunction, DatabaseContext databaseContext)
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
