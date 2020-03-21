using FaktureringAPI.Entities;
using FaktureringAPI.Utils;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FaktureringTests.ServiceLayer
{
    public class FakturaUtilsTests
    {
        [Fact]
        public void MakeDescriptionsLowercase_AllLettersUppercase_ReturnsLowerCase()
        {
            IList<Faktura> fakturaer = new List<Faktura>
            {
                new Faktura{Beskrivelse="DETTE ER EN TEST"}
            };
            var fakturaUtils = new FakturaUtil();
            var result= fakturaUtils.MakeDescriptionsLowercase(fakturaer);

            Assert.Equal("Dette er en test", result.Single().Beskrivelse);
        }

        [Fact]
        public void MakeDescriptionsLowercase_SomeLettersUppercase_ReturnsLowerCase()
        {
            IList<Faktura> fakturaer = new List<Faktura>
            {
                new Faktura{Beskrivelse="DEttE ER ogsÅ EN TesT"}
            };
            var fakturaUtils = new FakturaUtil();
            var result = fakturaUtils.MakeDescriptionsLowercase(fakturaer);

            Assert.Equal("Dette er også en test", result.Single().Beskrivelse);
        }

        [Fact]
        public void MakeDescriptionsLowercase_FirstLetterLowercase_ReturnsFristLetterAsUppercase()
        {
            IList<Faktura> fakturaer = new List<Faktura>
            {
                new Faktura{Beskrivelse="eEttE ER ogsÅ EN TesT"}
            };
            var fakturaUtils = new FakturaUtil();
            var result = fakturaUtils.MakeDescriptionsLowercase(fakturaer);

            Assert.Equal("Dette er også en test", result.Single().Beskrivelse);
        }

    }
}
