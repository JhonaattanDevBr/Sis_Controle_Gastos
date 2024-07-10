using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenGastosControl
{
    public class CategoriasCtl
    {
        string _NomeDaCategoria;

        public string NomeDaCategoria
        {
            get { return _NomeDaCategoria;}
            set { _NomeDaCategoria = value;}
        }

        public bool AutenticarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return false;
            }
            else
            {
                NomeDaCategoria = nome;
                return true;
            }
        }
    }
}
