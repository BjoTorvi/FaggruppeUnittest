using FaktureringAPI.Entities;
using FaktureringAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace FaktureringTests.ServiceLayer
{
    public class FakturaUtilsTests
    {
        [Fact]
        public void MakeDescriptionsLowercase_Always_ReturnsLowerCase()
        {
            IList<Faktura> fakturaer = new List<Faktura>
            {
                new Faktura{Beskrivelse="DETTE ER EN TEST"}
            };

            FakturaUtils.MakeDescriptionsLowercase(fakturaer);

            Assert.Equal("Dette er en test", fakturaer.Single().Beskrivelse);
        }
    }
}
