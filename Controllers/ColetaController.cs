using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using ReciGanhaMVC.Models;

namespace ReciGanhaMVC.Controllers
{
    [Route("[controller]")]
    public class Coleta : Controller
    {
        public string uriBase =  "http://localhost:5000/Coleta/";

        [HttpPost]
        public async Task<ActionResult> InsertAsync(NewColetaViewModel c)
        {
            try{
                string uriComplementar = "Insert";
                HttpClient httpClient = new HttpClient();//Declaração Objeto Httpclient responsavel pelo trafego de dados na  internet

                //declaração da variavel que armazena token qeu está na string e passagem do token recuperado para a propiedade Authorization do objeto httpClient
                
                string token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiIxIiwidW5pcXVlX25hbWUiOiJQb3N0byDDoWd1YSBmcmlhIiwibmJmIjoxNjY0ODQwMDQ1LCJleHAiOjE2NjQ5MjY0NDUsImlhdCI6MTY2NDg0MDA0NX0.XV3dP8B1qLBgskjoL_EVp1wJYFp49-e_ijVr4aF4lXr14-8nhxpyIc_gpqiXdD3_hCBtuG4PYn2Q3BSjDcEtyA";
                /*string token = HttpContext.Session.GetString("SessionTokenPostoColeta");*/
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                //objeto c está sendo serializado no formato json e armazenado na variel content
                var content = new StringContent(JsonConvert.SerializeObject(c));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");//informado no cabealho do ocnteudo que ele é do tipo json

                //variavel que armazenará o resultado da requisição que está sendo postada com o conteudo serializado para o endereço
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);
                string serialized = await response.Content.ReadAsStringAsync();

                
                if(response.StatusCode ==  System.Net.HttpStatusCode.OK)
                {
                    TempData["Mensagem"] = string.Format("Coleta {0} incluida com sucesso!", serialized);
                    return RedirectToAction("Index");
                }
                else
                    throw new System.Exception(serialized);

            }
            catch(Exception ex)
            {
                TempData["Mensagem"] = ex.Message;
                return RedirectToAction("InsertColeta");
            }
        }

        [HttpGet]
        public ActionResult InsertColeta()
        {
            return View("NewColeta");
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}