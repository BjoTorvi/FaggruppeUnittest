using System.Collections.Generic;
using System.Threading.Tasks;
using FaktureringAPI.Entities;

namespace FaktureringAPI.DataLayer
{
    public interface IDataReader
    {
        Task<IList<Faktura>> GetFakturaerAsync(int id);
        Task<Kunde> GetKundeAsync(int id);
    }
}