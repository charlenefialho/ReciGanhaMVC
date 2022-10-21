using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciGanhaMVC.Models
{
    public class ColetaViewModel
    {
        public int IdCliente {get; set;}
        public int IdColeta { get; set; }  

        public  int idPosto{get; set;}
        public float resultadoDePontos{get; set;}

        public DateTime dataColeta {get; set;}

        public int statusColeta{get; set;}


    }
}