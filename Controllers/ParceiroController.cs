using Microsoft.AspNetCore.Mvc;
using ReciGanhaMVC.Models;
using System.Threading.Tasks;//Uso para Try/Catch
using System.Net.Http;//Using para JsonConvert
using Newtonsoft.Json;//Using para HttpClient
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System;

namespace ReciGanhaMVC.Controllers
{
    public class ParceiroController : Controller
    {
        public string uriBase = "http://localhost:5000/Parceiro/";

        
        
        [HttpGet]
        public ActionResult IndexPageParceiro()
        {
            return View("PageParceiro");
        }

         


    }
}