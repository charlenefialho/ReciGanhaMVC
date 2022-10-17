using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReciGanhaMVC.Models.Enuns;

namespace ReciGanhaMVC.Models
{
    public class MateriaisAceitos
    {
        public int PostoDeColetaId {get; set;}
        public PostoDeColetaViewModel PostoDeColeta { get; set;}
        public int TipoMaterialId {get; set;}
        public TipoMaterialEnum TipoMaterial { get; set;}
    }
}