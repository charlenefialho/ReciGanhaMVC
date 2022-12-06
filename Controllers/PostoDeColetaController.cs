using Microsoft.AspNetCore.Mvc;
using ReciGanhaMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;//Uso para Try/Catch
using System.Net.Http;//Using para JsonConvert
using Newtonsoft.Json;//Using para HttpClient
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System;
using ReciGanhaMVC.Utils;

namespace ReciGanhaMVC.Controllers
{
    public class PostoDeColetaController : Controller
    {
        public string uriBase = "http://reciganha.somee.com/API/PostoDeColeta/";


        [HttpPost]
        public async Task<ActionResult> AutenticarAsync(PostoDeColetaViewModel p)
        {
            try
            {
                if(string.IsNullOrEmpty(p.CNPJ))
                    throw new Exception("Digite o CNPJ");
                    
                if(Validacoes.ValidarTamanhoCnpj(p.CNPJ) == false)
                    throw new Exception("O cnpj deve ter 14 caracteres");

                if(Validacoes.IsCnpj(p.CNPJ) == false)
                    throw new Exception("Insira um CNPJ Válido");

                HttpClient httpClient = new HttpClient();//Instancia do objeto HttpClient
                string uriComplementar = "Autenticar";

                var content = new StringContent(JsonConvert.SerializeObject(p));//serialização do objeto c
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar ,content);

                string serialized = await response.Content.ReadAsStringAsync();

                if(response.StatusCode == System.Net.HttpStatusCode.OK)//Consultando qual foi o status da requisição, se foi Ok
                {
                    HttpContext.Session.SetString("SessionTokenPostoColeta", serialized);
                    TempData["Mensagem"] = string.Format("Bem-vindo{0}!!", p.NomePosto);
                    return View("NewColeta");
                }
                else
                {
                    throw new System.Exception(serialized); 
                }
            }
            catch(Exception ex)
            {
                 TempData["MensagemErro"] = ex.Message;
                return View("AutenticarPostoDeColeta");// caso de erro -> irá direcionar para Index exibir mensagem
            }
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(PostoDeColetaViewModel p)
        {
            try
            {
                if(string.IsNullOrEmpty(p.CNPJ))
                    throw new Exception("Digite o CNPJ");

                if(string.IsNullOrEmpty(p.NomePosto))
                    throw new Exception("Digite o nome do posto de coleta");
                    
                if(Validacoes.ValidarTamanhoCnpj(p.CNPJ) == false)
                    throw new Exception("O cnpj deve ter 14 caracteres");

                if(Validacoes.IsCnpj(p.CNPJ) == false)
                    throw new Exception("Insira um CNPJ Válido");

                
                p.MateriaisAceitos = new List<MateriaisAceitos>();
                if(p.SelecionadoPlastico == true)
                {
                    MateriaisAceitos itemPlastico = new MateriaisAceitos();
                    itemPlastico.TipoMaterialId = (int)Models.Enuns.TipoMaterialEnum.Plastico;
                    p.MateriaisAceitos.Add(itemPlastico);
                }

                 if(p.SelecionadoMetal == true)
                {
                    MateriaisAceitos itemMetal = new MateriaisAceitos();
                    itemMetal.TipoMaterialId = (int)Models.Enuns.TipoMaterialEnum.Metal;
                    p.MateriaisAceitos.Add(itemMetal);
                }

                if(p.SelecionadoPapel == true)
                {
                    MateriaisAceitos itemPapel = new MateriaisAceitos();
                    itemPapel.TipoMaterialId = (int)Models.Enuns.TipoMaterialEnum.Papel;
                    p.MateriaisAceitos.Add(itemPapel);
                }

                if(p.SelecionadoVidro == true)
                {
                    MateriaisAceitos itemVidro = new MateriaisAceitos();
                    itemVidro.TipoMaterialId = (int)Models.Enuns.TipoMaterialEnum.Vidro;
                    p.MateriaisAceitos.Add(itemVidro);
                }
                
                
                HttpClient httpClient = new HttpClient();
                string uriComplementar = "Registrar";
                var content = new StringContent(JsonConvert.SerializeObject(p));//serialização do objeto c
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar,content);//envio dos dados para API
                
                TempData["Mensagem"] += JsonConvert.SerializeObject(p);
                string PostoSerialized = await response.Content.ReadAsStringAsync();//Buscando e armazenando dados de de retorno dentro do retorno da requisição

                if(response.StatusCode == System.Net.HttpStatusCode.OK)//Consultando qual foi o status da requisição, se foi Ok
                {
                    TempData["Mensagem"] = string.Format("{0} foi registrado com sucesso! Faça o login para acessar", p.NomePosto);//exibir mensagem temporaria
                    return View("AutenticarPostoDeColeta"); //redirecionar para a view de login
                }
                else
                {
                    throw new System.Exception(PostoSerialized); //lançará uma exceção com o que retornou de “PostoSerialized” para o catch
                }
            }
            catch(Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return View("RegistrarPostoDeColeta", p);
            }
        }
        [HttpGet]
        public ActionResult IndexCadastroPosto()
        {
            return View("RegistrarPostoDeColeta");
        }

        [HttpGet]
        public ActionResult IndexAutenticarPosto()
        {
            return View("AutenticarPostoDeColeta");
        }
    }

    
}