using Microsoft.AspNetCore.Mvc;
using ReciGanhaMVC.Models;
using System.Threading.Tasks;//Uso para Try/Catch
using System.Net.Http;//Using para JsonConvert
using Newtonsoft.Json;//Using para HttpClient
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System;
using ReciGanhaMVC.Utils;

namespace ReciGanhaMVC.Controllers
{
    public class ParceiroController : Controller
    {
        public string uriBase = "http://reciganha.somee.com/API/Parceiro/";

        
        
        [HttpGet]
        public ActionResult IndexPageParceiro()
        {
            return View("PageParceiro");
        }



        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(ParceiroViewModel p)
        {
            try
            {
                 if(string.IsNullOrEmpty(p.NomeParceiro))
                    throw new Exception("Digite o nome da empresa");

                if(string.IsNullOrEmpty(p.CnpjParceiro))
                    throw new Exception("Digite o CNPJ da empresa");

                if(string.IsNullOrEmpty(p.EmailParceiro))
                    throw new Exception("Digite o Email");

                if(Validacoes.ValidarEmail(p.EmailParceiro) == false)
                    throw new Exception("Digite um email válido");

                /*if(Validacoes.IsCnpj(p.CnpjParceiro) == false)
                    throw new Exception("Digite um CNPJ válido");*/

                HttpClient httpClient = new HttpClient();//Instancia do objeto HttpClient
                string uriComplementar = "Registrar"; //endpoint da rota do método da API

                var content = new StringContent(JsonConvert.SerializeObject(p));//serialização do objeto c
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);//envio dos dados para API

                string serialized = await response.Content.ReadAsStringAsync();//Buscando e armazenando dados de de retorno dentro do retorno da requisição

                if(response.StatusCode == System.Net.HttpStatusCode.OK)//Consultando qual foi o status da requisição, se foi Ok
                {
                    TempData["Mensagem"] = string.Format("Parceiro {0} foi registrado com sucesso!", p.NomeParceiro);//exibir mensagem temporaria
                    return RedirectToAction("Index", "Home"); //redirecionar para a view de home
                }
                else
                {
                    throw new System.Exception(serialized); //lançará uma exceção com o que retornou de “serialized” para o catch
                }
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index", "Home");// caso de erro -> irá direcionar para Index exibir mensagem  e envia o objeto para nao perder no input
            }
        }




    }
}