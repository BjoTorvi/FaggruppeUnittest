using System.Collections.Generic;
using System.Threading.Tasks;
using FaktureringAPI.DataLayer;
using FaktureringAPI.Entities;
using FaktureringAPI.Utils;

namespace FaktureringAPI.ServiceLayer
{
    public class Service
    {
        private readonly DataReader _dataReader = new DataReader();

      
        public async Task<Kunde> GetKunde(int id)
        {
            var kunde = await _dataReader.GetKundeAsync(id);
            var fakturaer = await _dataReader.GetFakturaerAsync(id);

            FakturaUtils.MakeDescriptionsLowercase(fakturaer);
            kunde.Fakturaer = fakturaer;

            return kunde;
        }
    }
}