using Microsoft.AspNetCore.Mvc;
using ReciGanhaMVC.Models;
using System.Threading.Tasks;//Uso para Try/Catch
using System.Net.Http;//Using para JsonConvert
using Newtonsoft.Json;//Using para HttpClient
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;

namespace ReciGanhaMVC.Controllers
{
    public class RecompensaController : Controller
    {
        public string uriBase = "http://reciganha.somee.com/API/Recompensa/";
    }
}