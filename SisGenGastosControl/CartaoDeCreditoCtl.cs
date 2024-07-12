using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenGastosControl
{
    public class CartaoDeCreditoCtl
    {
        string _NomeDaCartaoDeCredito; // Ainda preciso terminar essa classe
        string _DataDeVencimento;

        public string NomeDaCartaoDeCredito
        {
            get { return _NomeDaCartaoDeCredito; }
            set { _NomeDaCartaoDeCredito = value; }
        }

        public string DataDeVencimento
        {
            get { return _DataDeVencimento; }
            set { _DataDeVencimento = value; }
        }

        public bool AutenticarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return false;
            }
            else
            {
                NomeDaCartaoDeCredito = nome;
                return true;
            }
        }

        public bool AutenticarDataVencimento(string dataVencimento)
        {
            int data = int.Parse(dataVencimento);
            if (data == 0)
            {
                return false;
            }
            else
            {
                DataDeVencimento = dataVencimento;
                return true;
            }
        }
    }
}
