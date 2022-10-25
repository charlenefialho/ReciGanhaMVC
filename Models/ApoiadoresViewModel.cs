using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciGanhaMVC.Models
{
    public class ApoiadoresViewModel
    {
        public int IdApoiadores {get; set;}
        public string NomeApoiadores{get; set;}
        public string EmailApoiadores {get; set;}
        public string CnpjApoiadores{get; set;}
        public byte[] FotoApoiador { get; set; } 
        

    }
}