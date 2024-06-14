using System;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class HostingController : ApiController
    {
        /// <summary>
        /// Calculates and returns the total hosting cost including HST based on the number of days since hosting started.
        /// </summary>
        /// <param name="id">The number of days since hosting started.</param>
        /// <returns>Three strings describing the total hosting cost, HST, and total amount.</returns>
        [HttpGet]
        [Route("api/HostingCost/{id}")]
        public IHttpActionResult Get(int id)
        {
            int fortnights = (int)Math.Ceiling((double)id / 14);

            // Calculate cost details
            double cost = fortnights * 5.50;
            double hst = cost * 0.13;
            double totalCost = cost + hst;

            // Prepare response strings
            string fortnightsString = $"{fortnights} fortnights at $5.50/FN = ${cost:F2} CAD";
            string hstString = $"HST 13% = ${hst:F2} CAD";
            string totalString = $"Total = ${totalCost:F2} CAD";

            // Return Ok with the three strings
            return Ok(new[] { fortnightsString, hstString, totalString });
        }
    }
}
