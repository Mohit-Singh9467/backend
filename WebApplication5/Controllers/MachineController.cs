using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class MachineController : Controller
    {
        public ActionResult Get(int id)
        {
            // Applying four mathematical operations
            int addition = id + 5;
            int subtraction = id - 3;
            int multiplication = id * 2;
            double division = id != 0 ? (double)id / 4 : 0; // Prevent division by zero

            string result = $"Addition: {addition}, Subtraction: {subtraction}, Multiplication: {multiplication}, Division: {division}";
            return result;
        }
    }
}