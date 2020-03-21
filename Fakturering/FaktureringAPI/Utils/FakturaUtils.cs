using System;
using System.Collections.Generic;
using FaktureringAPI.Entities;

namespace FaktureringAPI.Utils
{
    public class FakturaUtil : IFakturaUtil
    {
        public IList<Faktura> MakeDescriptionsLowercase(IList<Faktura> fakturaer)
        {
            foreach (var faktura in fakturaer)
            {
                faktura.Beskrivelse =
                    faktura.Beskrivelse.Substring(0, 1)
                    + faktura.Beskrivelse.Substring(1).ToLower();
            }

            return fakturaer;
        }
    }
}