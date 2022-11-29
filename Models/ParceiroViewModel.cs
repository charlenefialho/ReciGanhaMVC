using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciGanhaMVC.Models
{
    public class ParceiroViewModel
    {
        public int IdParceiro {get; set;}
        public string NomeParceiro {get; set;}
        public string EmailParceiro {get; set;}
        public string CnpjParceiro{get; set;}
        public byte[] FotoParceiro { get; set; } 
        public string RegiaoParceiro {get; set;}
        

    }
}