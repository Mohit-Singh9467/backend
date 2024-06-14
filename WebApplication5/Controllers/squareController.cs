using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class squareController : ApiController
    {
        public int square(int id)
        {

            return id * id;
        }


    }
}
