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
        //public string uriBase = "http://localhost:5000/Recompensa/";]

        

        [HttpGet]
        public async Task<ActionResult> Resgatar(int? id)
        {
            try
            {
                string uriComplementar = "Resgatar/";
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenCliente");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar + id.ToString());
                string serialized = await response.Content.ReadAsStringAsync();

                //get recompensas
                    string uriComplementarInfo = "GetAll";
                    HttpResponseMessage responseInfo = await httpClient.GetAsync(uriBase + uriComplementarInfo );
                    string serializedInfo = await responseInfo.Content.ReadAsStringAsync();
                    

                //&& response.StatusCode == System.Net.HttpStatusCode.BadRequest

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<RecompensaViewModel> listaRecompensas= await Task.Run(() =>
                    
                    JsonConvert.DeserializeObject<List<RecompensaViewModel>>(serializedInfo));

                    TempData["CodigoRecompensa"] = string.Format(serialized);

                    return View("ListarRecompensa", listaRecompensas);
                }
                else
                    throw new Exception(serialized);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("IndexPageCliente", "Clientes");
            }
        }



        [HttpGet]
        public async Task<ActionResult> IndexRecompensa()
        {
            try
            {
                string uriComplementar = "GetAll";
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenCliente");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);
                string serialized = await response.Content.ReadAsStringAsync();


                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<RecompensaViewModel> listaRecompensas= await Task.Run(() =>
                    
                    JsonConvert.DeserializeObject<List<RecompensaViewModel>>(serialized));

                    return View("ListarRecompensa", listaRecompensas);
                }
                else
                    throw new Exception(serialized);

            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("IndexPageCliente", "Clientes");
            }
        }
    }
}