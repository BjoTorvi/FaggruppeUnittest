using FaktureringAPI.DataLayer;
using FaktureringAPI.Entities;
using FaktureringAPI.ServiceLayer;
using FaktureringAPI.Utils;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace FaktureringTests.ServiceLayer
{
    public class ServiceTests
    {
        [Fact]
        public async Task GetKunde_Always_CallDatareaderAndUtil()
        {

            var fakturaer = new List<Faktura> { new Faktura { Belop = 100, Beskrivelse = "TEST" }, new Faktura { Belop = 200, Beskrivelse = "TEST2" } };
            var fakturaerLowerCase = new List<Faktura> { new Faktura { Belop = 100, Beskrivelse = "Test" }, new Faktura { Belop = 200, Beskrivelse = "Test2" } };
            var kunde = new Kunde { Navn = "Ola" };

            var dataReader = Substitute.For<IDataReader>();
            dataReader.GetKundeAsync(1).Returns(kunde);
            dataReader.GetFakturaerAsync(1).Returns(fakturaer);
            var fakturautil = Substitute.For<IFakturaUtil>();
            fakturautil.MakeDescriptionsLowercase(fakturaer).Returns(fakturaerLowerCase);
            var _service = new Service(dataReader, fakturautil);

            var result = await _service.GetKunde(1);

            Assert.Equal("Ola", result.Navn);
            Assert.Equal("Test", result.Fakturaer[0].Beskrivelse);
            Assert.Equal("Test2", result.Fakturaer[1].Beskrivelse);
        }
    }
}
