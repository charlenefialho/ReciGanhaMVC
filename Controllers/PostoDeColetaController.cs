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
    [Route("[controller]")]
    public class PostoDeColetaController : Controller
    {
        public string uriBase = "http://localhost:5000/PostoDeColeta/";


        [HttpPost]
        public async Task<ActionResult> AutenticarAsync(PostoDeColetaViewModel p)
        {
            try
            {
                HttpClient httpClient = new HttpClient();//Instancia do objeto HttpClient
                string uriComplementar = "Autenticar";

                var content = new StringContent(JsonConvert.SerializeObject(p));//serialização do objeto c
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);

                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)//Consultando qual foi o status da requisição, se foi Ok
                {
                    HttpContext.Session.SetString("SessionTokenPostoColeta", serialized);
                    TempData["Mensagem"] = string.Format("Bem-vindo{0}!!", p.NomePosto);
                    return RedirectToAction("IndexColeta");
                }
                else
                {
                    throw new System.Exception(serialized); 
                }
            }
            catch(Exception ex)
            {
                 TempData["MensagemErro"] = ex.Message;
                return IndexLogin();// caso de erro -> irá direcionar para Index exibir mensagem
            }
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(PostoDeColetaViewModel p)
        {
            try
            {
                HttpClient httpClient = new HttpClient();

                string uriComplementar = "Registrar";
                var content = new StringContent(JsonConvert.SerializeObject(p));//serialização do objeto c
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);//envio dos dados para API

                string PostoSerialized = await response.Content.ReadAsStringAsync();//Buscando e armazenando dados de de retorno dentro do retorno da requisição

                if(response.StatusCode == System.Net.HttpStatusCode.OK)//Consultando qual foi o status da requisição, se foi Ok
                {
                    TempData["Mensagem"] = string.Format("{0} foi registrado com sucesso! Faça o login para acessar.", p.NomePosto);//exibir mensagem temporaria
                    return RedirectToAction("Indexlogin"); //redirecionar para a view de login
                }
                else
                {
                    throw new System.Exception(PostoSerialized); //lançará uma exceção com o que retornou de “PostoSerialized” para o catch
                }
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("IndexCadastro");
            }
        }
        
        [HttpGet]
        public ActionResult IndexColeta()
        {
            return View("NewColeta");
        }


        [HttpGet]
        public ActionResult IndexLogin()
        {
            return View("AutenticarPostoDeColeta");
        }

        [HttpGet]
        public ActionResult IndexCadastro()
        {
            return View("RegistrarPostoDeColeta");
        }
    }
}