using System.Collections.Generic;
using System.Threading.Tasks;
using TSOnline.Common.Interfaces.Models;

namespace TSOnline.Common.Interfaces.Services
{
    public interface ICountriesDatabaseService
    {
        Task<long> EstimatedCountCountriesAsync();

        Task<long> CountCountriesAsync();

        Task<List<ICountry>> GetAllAsync();
    }
}
