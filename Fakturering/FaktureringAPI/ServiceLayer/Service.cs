using System.Threading.Tasks;
using FaktureringAPI.DataLayer;
using FaktureringAPI.Entities;
using FaktureringAPI.Utils;

namespace FaktureringAPI.ServiceLayer
{
    public class Service : IService
    {
        private readonly IDataReader _dataReader;
        private readonly IFakturaUtil _fakturaUtil;

        public Service( IDataReader  dataReader, IFakturaUtil fakturaUtil)
        {
            _dataReader = dataReader;
            _fakturaUtil = fakturaUtil;
        }
       
        public async Task<Kunde> GetKunde(int id)
        {
            var kunde = await _dataReader.GetKundeAsync(id);
            var fakturaer = await _dataReader.GetFakturaerAsync(id);

            fakturaer= _fakturaUtil.MakeDescriptionsLowercase(fakturaer);
            kunde.Fakturaer = fakturaer;

            return kunde;
        }
    }
}