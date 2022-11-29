using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ReciGanhaMVC.Models
{
    public class TesteViewModel
    {
        public TesteViewModel()
        {
            ListaColetas = new List<ColetaViewModel>();
            ListaClientes = new List<ClienteViewModel>();
        }
        
        public List<ColetaViewModel> ListaColetas { get; set; }
        public List<ClienteViewModel> ListaClientes { get; set; }
        public ClienteViewModel ClienteCadastro { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}