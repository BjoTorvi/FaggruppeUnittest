using FaktureringAPI.ServiceLayer;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FaktureringTests.ServiceLayer
{
    
    public class ServiceTests
    {
        [Fact]
        public async Task GetKundeTestAsync()
        {
            var _service = new Service();
            var kunde = await _service.GetKunde(1);
            Assert.Equal("Ola", kunde.Navn);
            Assert.Equal(100, kunde.Fakturaer[0].Belop);
            Assert.Equal(200, kunde.Fakturaer[1].Belop);

        }

    }
}
