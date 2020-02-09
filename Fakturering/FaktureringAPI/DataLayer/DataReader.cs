using FaktureringAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FaktureringAPI.DataLayer
{
    internal class DataReader
    {
        private readonly string _basePath= "..//..//..//TestData//";

        public DataReader()
        {
        }

        public async Task<Kunde> GetKundeAsync(int id)
        {
            var kundeJson = await System.IO.File.ReadAllTextAsync($"{_basePath}Kunde{id}.json");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Kunde>(kundeJson);
        }

        public async Task<IList<Faktura>> GetFakturaerAsync(int id)
        {
            var fakturaerJson = await System.IO.File.ReadAllTextAsync($"{_basePath}Fakturaer{id}.json");
            return Newtonsoft.Json.JsonConvert.DeserializeObject<IList<Faktura>>(fakturaerJson);
        }
    }
}