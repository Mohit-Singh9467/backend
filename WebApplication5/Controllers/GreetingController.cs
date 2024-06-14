using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class GreetingController : ApiController
    {
        // Controller Action Method
        [HttpPost]
        [Route("api/Greeting")]
        public string Greeting()
        {
            // Return a static greeting message
            return "Hello World!";
        }

    }
}

