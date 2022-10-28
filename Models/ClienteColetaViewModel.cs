using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReciGanhaMVC.Models
{
    public class ClienteColetaViewModel
    {
        public int IdColeta {get;set;}
        public float resultadoDePontos{get; set;}
        public DateTime dataColeta {get; set;}
        public string NomeCliente{get; set;}
    }
}