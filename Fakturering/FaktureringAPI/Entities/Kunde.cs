using System.Collections.Generic;

namespace FaktureringAPI.Entities
{
    public class Kunde
    {
        public string Navn { get; set; }
        public IList<Faktura> Fakturaer { get; set; }
    }
}