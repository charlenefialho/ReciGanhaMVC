using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace Reciganha_MVC.Models
{
    public class ClienteViewModel
    {
        public int IdCliente {get; set;}
        public string NomeCliente{get; set;}

        public string EmailCliente {get; set;}
        public string TelefoneCliente{get; set;}
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt { get; set; }

       
        public string PasswordString { get; set; }
    }
}