using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lopworks.Controllers
{
    [Route("api/lopworks")]
    [ApiController]
    public class LopworksController : ControllerBase
    {
        [HttpGet("")]
        public string GetFirstResponse()
        {
            var newData = "Kindly insert a query parameter";
            return newData;
        }

        [HttpGet("{queryParameter}")]
        public string GetFirstResponse(string queryParameter)
        {
            var newData = "";
            if (queryParameter == "name")
            {
                newData = "My name is Emmanuel";
            }
            else if (queryParameter == "job")
            {
                newData = "I work as a developer";
            }

            return newData;
        }
    }
}