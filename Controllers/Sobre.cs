using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ReciGanhaMVC.Controllers
{
    public class Sobre : Controller
    {
       [HttpGet]
        public ActionResult IndexSobre()
        {
            return View("Sobre");
        }   
    }
}