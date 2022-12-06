using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciGanhaMVC.Models
{
    public class PostoDeColetaViewModel
    {
        public int IdPosto { get; set; }
        public string NomePosto { get; set; }
        public string CNPJ { get; set; }
        #nullable enable
        public string? EmailPosto { get; set; }
        public string? TelefonePosto { get; set; }
        public string? WebSite { get; set; }
        #nullable disable

        public int NumeroRua{get;set;}
        public string Rua {get; set;}
        public string Bairro {get;set;}
        public string CEP {get;set;}
        public string Latitude { get; set; }
        
        public string Longitude { get; set; }
        public DateTime DataLimiteExibicao { get; set; }
        public int StatusPosto { get; set; }
        public int[] materiais {get;set;}
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt { get; set; }

        public string PasswordString { get; set; }

        public int[] Materiais { get; set; }
        
        
        public List<MateriaisAceitos> MateriaisAceitos { get; set; }
        
        public bool SelecionadoPlastico { get; set; }
        public bool SelecionadoMetal{ get; set; }
        public bool SelecionadoPapel{ get; set; }
        public bool SelecionadoVidro{ get; set; }

    }

}