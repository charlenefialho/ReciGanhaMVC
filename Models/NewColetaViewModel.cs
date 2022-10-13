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

        public float PesoPlastico { get; set; }
        public float PesoMetal { get; set; }
    }
}