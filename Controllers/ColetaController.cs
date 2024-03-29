using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;//Uso para Try/Catch
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;//Using para HttpClient
using System.Net.Http;//Using para JsonConvert
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;//using para session.GetString
using ReciGanhaMVC.Models;

namespace ReciGanhaMVC.Controllers
{
    public class Coleta : Controller
    {
        //public string uriBase = "http://reciganha.somee.com/API/Coleta/";
        //public string uriBase = "http://reciganha-001-site1.gtempurl.com/Coleta/";
        public string uriBase = "http://ReciganhaHAS.somee.com/publishAPI/Coleta/";


        

        [HttpPost]
        public async Task<ActionResult> InsertAsync(NewColetaViewModel c)
        {
            try
            {
                
                c.MaterialCadastro = new List<NewColetaViewModel>();

                NewColetaViewModel itemPlastico = new NewColetaViewModel();
                itemPlastico.TipMat = (int)Models.Enuns.TipoMaterialEnum.Plastico;
                itemPlastico.Pes = c.Plastico;
                c.MaterialCadastro.Add(itemPlastico);


                NewColetaViewModel itemMetal = new NewColetaViewModel();
                itemMetal.TipMat = (int)Models.Enuns.TipoMaterialEnum.Metal;
                itemMetal.Pes = c.Metal;
                c.MaterialCadastro.Add(itemMetal);

                NewColetaViewModel itemPapel = new NewColetaViewModel();
                itemPapel.TipMat = (int)Models.Enuns.TipoMaterialEnum.Papel;
                itemPapel.Pes = c.Papel;
                c.MaterialCadastro.Add(itemPapel);

                NewColetaViewModel itemVidro = new NewColetaViewModel();
                itemVidro.TipMat = (int)Models.Enuns.TipoMaterialEnum.Vidro;
                itemVidro.Pes = c.Vidro;
                c.MaterialCadastro.Add(itemVidro);




                //TempData["Mensagem"] = $"Peso Plástico {c.PesoPlastico} - Peso Al. {c.PesoAluminio}" ;
                //return View("NewColeta");
                //

                string uriComplementar = "Insert/" + c.EmailCliente.ToString();
                HttpClient httpClient = new HttpClient();//Declaração Objeto Httpclient responsavel pelo trafego de dados na  internet

                //declaração da variavel que armazena token qeu está na string e passagem do token recuperado para a propiedade Authorization do objeto httpClient

                string token = HttpContext.Session.GetString("SessionTokenPostoColeta");

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                //objeto c está sendo serializado no formato json e armazenado na variel content
                var content = new StringContent(JsonConvert.SerializeObject(c.MaterialCadastro));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");//informado no cabealho do ocnteudo que ele é do tipo json

                //variavel que armazenará o resultado da requisição que está sendo postada com o conteudo serializado para o endereço
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);
                string serialized = await response.Content.ReadAsStringAsync();


                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    /*ColetaViewModel n = await Task.Run(() =>
                    JsonConvert.DeserializeObject<ColetaViewModel>(serialized));*/
                    TempData["Mensagem"] = string.Format("Coleta {0} incluida com sucesso!", serialized);
                    //return RedirectToAction("Index");
                    return View("NewColeta");
                }
                else
                    throw new System.Exception(serialized);

            }
            catch (Exception ex)
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