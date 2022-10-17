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
        public string? EmailPosto { get; set; }
        public string? TelefonePosto { get; set; }
        public string? WebSite { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime DataLimiteExibicao { get; set; }
        public int StatusPosto { get; set; }
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt { get; set; }

        public string PasswordString { get; set; }
        
        public List<MateriaisAceitos> MateriaisAceitos { get; set; }
    }
}