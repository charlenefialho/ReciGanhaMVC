using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciGanhaMVC.Models
{
    public class RecompensaViewModel
    {
        public int idRecompensa {get; set;}
        public string nomeRecompensa { get; set; }
        public string descricao { get; set; }   
        public float custodePontos { get; set; } 
        public int qtdeRecomepensas { get; set; }

    }
}