using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaktureringAPI.Entities;
using FaktureringAPI.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

namespace FaktureringAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<Kunde> GetAsync(int id)
        {
            var service = new Service();

            return await service.GetKunde(id);
        }
    }
}
