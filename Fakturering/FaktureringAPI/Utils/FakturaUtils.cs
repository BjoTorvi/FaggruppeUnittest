using System;
using System.Collections.Generic;
using FaktureringAPI.Entities;

namespace FaktureringAPI.Utils
{
    public static class FakturaUtils
    {
        public static void MakeDescriptionsLowercase(IList<Faktura> fakturaer)
        {
            foreach (var faktura in fakturaer)
            {
                faktura.Beskrivelse = 
                    faktura.Beskrivelse.Substring(0,1)
                    + faktura.Beskrivelse.Substring(1).ToLower();

            }
        }
    }
}