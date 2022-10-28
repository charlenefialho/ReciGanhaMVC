using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReciGanhaMVC.Utils
{
    public class Validacoes
    {
        public static bool ValidarTamanhoCnpj(string cnpj)
        {
            if(cnpj.Replace(".","").Replace("-","").Replace("/","").Length != 14)
                return false;
            else
                return true;
        }

        
    }
}