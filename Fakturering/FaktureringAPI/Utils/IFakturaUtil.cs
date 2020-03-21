using System.Collections.Generic;
using FaktureringAPI.Entities;

namespace FaktureringAPI.Utils
{
    public interface IFakturaUtil
    {
        IList<Faktura> MakeDescriptionsLowercase(IList<Faktura> fakturaer);
    }
}