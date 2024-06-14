using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class Greeting2Controller : ApiController
    {
        public string Get(int id)
        {
            return $"Greetings to {id} people!";
        }
    }
}
