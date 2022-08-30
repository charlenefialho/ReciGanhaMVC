using Microsoft.AspNetCore.Mvc;
using Reciganha_MVC.Models;
using System.Threading.Tasks;//Uso para Try/Catch
using System.Net.Http;//Using para JsonConvert
using Newtonsoft.Json;//Using para HttpClient

namespace Reciganha_MVC.Controllers
{
    public class ClienteController : Controller
    {
        public string uriBase = "xyz/Cliente/";

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(ClienteViewModel c)
        {
            try
            {
                HttpClient httpClient = new HttpClient();//Instancia do objeto HttpClient
                string uriComplementar = "Registrar"; //endpoint da rota do método da API

                var content = new StringContent(JsonConvert.SerializeObject(c));//serialização do objeto c
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);//envio dos dados para API

                string serialized = await response.Content.ReadAsStringAsync();//Buscando e armazenando dados de de retorno dentro do retorno da requisição

                if(response.StatusCode == System.Net.HttpStatusCode.OK)//Consultando qual foi o status da requisição, se foi Ok
                {
                    TempData["Mensagem"] = string.Format("Cliente {0} foi registrado com sucesso! Faça o login para acessar.", c.NomeCliente);//exibir mensagem temporaria
                    return View("AutenticarCliente"); //redirecionar para a view de login
                }
                else
                {
                    throw new System.Exception(serialized); //lançará uma exceção com o que retornou de “serialized” para o catch
                }
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");// caso de erro -> irá direcionar para Index exibir mensagem
            }
        }

        //carregar a view inicialmente *mudar para a home*
        [HttpGet]
        public ActionResult Index()
        {
            return View("CadastrarCliente");
        }

    }
}