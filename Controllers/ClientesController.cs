using Microsoft.AspNetCore.Mvc;
using ReciGanhaMVC.Models;
using System.Threading.Tasks;//Uso para Try/Catch
using System.Net.Http;//Using para JsonConvert
using Newtonsoft.Json;//Using para HttpClient
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using ReciGanhaMVC.Utils;

namespace ReciGanhaMVC.Controllers
{
    public class ClientesController : Controller
    {
        public string uriBase = "http://reciganha-001-site1.gtempurl.com/API/Cliente/";
        


        //carregar a view inicialmente *mudar para a home*
        /*[HttpGet]
        public ActionResult IndexPageCliente()
        {
            return View("PageCliente");
        }*/

        [HttpGet]
        public async Task<ActionResult> IndexPageCliente()
        {
            try
            {
                string uriComplementar = "GetHist";
                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenCliente");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = await httpClient.GetAsync("http://reciganha-001-site1.gtempurl.com/API/Coleta/" + uriComplementar);
                string serialized = await response.Content.ReadAsStringAsync();

                //Get pontos do cliente
                string uriComplementar2 ="GetPoints";

                HttpResponseMessage responseInfo = await httpClient.GetAsync(uriBase + uriComplementar2);
                string serializedInfo = await responseInfo.Content.ReadAsStringAsync();

                if(responseInfo.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ViewBag.Message = serializedInfo;
                }

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    List<ClienteColetaViewModel> listaColetas = await Task.Run(() =>
                    
                    JsonConvert.DeserializeObject<List<ClienteColetaViewModel>>(serialized));

                    return View("PageCliente", listaColetas);
                }
                else
                    throw new Exception(serialized);
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return View("PageCliente");
            }

            

        }


        [HttpGet]
        public async Task<ActionResult> ResgatarPontosAsync(ColetaViewModel c)
        {
            try
            {
                
                string uriComplementar ="Pontos/" + c.IdColeta.ToString();

                HttpClient httpClient = new HttpClient();
                string token = HttpContext.Session.GetString("SessionTokenCliente");
                httpClient.DefaultRequestHeaders.Authorization  = new AuthenticationHeaderValue("Bearer", token);
                HttpResponseMessage response = await httpClient.GetAsync(uriBase + uriComplementar);
                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    /*string msg = await Task.Run(() =>
                    JsonConvert.DeserializeObject<string>(serialized));*/

                    TempData["Mensagem"] = string.Format(serialized);
                    return RedirectToAction("IndexPageCliente");
                }
                else
                {
                    throw new System.Exception(serialized);
                }
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("IndexPageCliente");
            }
                
            
        }




        [HttpPost]
        public async Task<ActionResult> AutenticarAsync(ClienteViewModel c)
        {
            try
            {
                if(string.IsNullOrEmpty(c.PasswordString))
                    throw new Exception("Digite a senha");

                if(string.IsNullOrEmpty(c.EmailCliente))
                    throw new Exception("Digite o Email");

                if(Validacoes.ValidarEmail(c.EmailCliente) == false)
                    throw new Exception("Digite um email válido");

                HttpClient httpClient = new HttpClient();//Instancia do objeto HttpClient
                string uriComplementar = "Autenticar";

                var content = new StringContent(JsonConvert.SerializeObject(c));//serialização do objeto c
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);

                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)//Consultando qual foi o status da requisição, se foi Ok
                {
                    HttpContext.Session.SetString("SessionTokenCliente", serialized);
                    TempData["Mensagem"] = string.Format("Bem-vindo {0} !!", c.NomeCliente);
                    return RedirectToAction("IndexPageCliente");
                }
                else
                {
                    throw new System.Exception(serialized); 
                }
            }
            catch(System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("IndexLogin");// caso de erro -> irá direcionar para Index exibir mensagem
            }
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(ClienteViewModel c)
        {
            try
            {
                 if(string.IsNullOrEmpty(c.NomeCliente))
                    throw new Exception("Digite um nome de usuário");

                if(string.IsNullOrEmpty(c.PasswordString))
                    throw new Exception("Digite a senha");

                if(string.IsNullOrEmpty(c.EmailCliente))
                    throw new Exception("Digite o Email");

                if(Validacoes.ValidarEmail(c.EmailCliente) == false)
                    throw new Exception("Digite um email válido");

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
                return RedirectToAction("IndexCadastro");// caso de erro -> irá direcionar para Index exibir mensagem  e envia o objeto para nao perder no input
            }
        }

        
        [HttpGet]
        public ActionResult IndexBuscarPostos()
        {
            return View("BuscarPostosCliente");
        }


        [HttpGet]
        public ActionResult IndexCadastro()
        {
            return View("CadastrarCliente");
        }

        [HttpGet]
        public ActionResult IndexLogin()
        {
            return View("AutenticarCliente");
        }

    }
}