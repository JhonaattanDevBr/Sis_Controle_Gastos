using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenGastosControl
{
    public class FormaDePagamentoCtl
    {
        string _NomeDaFormaDePagamento;

        public string NomeDaFormaDePagamento
        {
            get { return _NomeDaFormaDePagamento; }
            set { _NomeDaFormaDePagamento = value; }
        }

        public bool AutenticarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return false;
            }
            else
            {
                NomeDaFormaDePagamento = nome;
                return true;
            }
        }
    }
}
