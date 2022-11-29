using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciGanhaMVC.Models
{
    public class NewColetaViewModel
    {
        public int TipMat {get; set;}
        public float Pes{get; set;}
        public List<NewColetaViewModel> MaterialCadastro { get; set; }

        public string EmailCliente {get; set;}

        public float Plastico { get; set; }
        public float Metal { get; set; }

        public float Papel { get; set; }

        public float Vidro { get; set; }
    }
}