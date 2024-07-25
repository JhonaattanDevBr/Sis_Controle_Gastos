using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisGenGastosControl
{
    public class GastosFixosCtl
    {
        // ======================================================== Propriedades da classe
        private string _NomeDoGasto;
        private string _Categoria;
        private string _DataDoPagamento;
        private string _valor;
        private string _FormaDePagamento;
        private string _status;

        public string NomeDoGasto
        {
            get { return _NomeDoGasto; }
            set {  _NomeDoGasto = value; }
        }

        public string Categoria
        {
            get { return _Categoria; }
            set { _Categoria = value; }
        }

        public string DataDoPagamento
        {
            get { return _DataDoPagamento; }
            set { _DataDoPagamento = value; }
        }

        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        public string FormaDePagamento
        {
            get { return _FormaDePagamento; }
            set { _FormaDePagamento = value;}
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        // ======================================================== Metodos da classe
        public bool AutenticarNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return false;
            }
            else
            {
                NomeDoGasto = nome;
                return true;
            }
        }

        public bool AutenticarCategoria(string categoria)
        {
            if (string.IsNullOrEmpty(categoria))
            {
                return false;
            }
            else
            {
                Categoria = categoria;
                return true;
            }
        }

        // Aqui vou implementar um metodo para ele ligar o banco de dados e pegar o Id da categoria reutilizando o metodo acima.
        private void PegarIdCategoria()
        {
            bool estaPreenchido = AutenticarCategoria(Categoria);
            if (estaPreenchido)
            {
                // Aqui eu chamo o metodo para conectar ao banco de dados passando a categoria que foi selecionada e buscando e pegando o ID pertencente
                // a ela.
            }
        }

        public void FormatarData(string dataDePagamento)
        {
            string[] dataFracioada = dataDePagamento.Split('/');
            DataDoPagamento = $"{dataFracioada[2]}/{dataFracioada[1]}/{dataFracioada[0]}";
        }

        public bool AutenticarValor(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                return false;
            }
            else
            {
                Valor = valor;
                return true;
            }
        }

        public bool AutenticarFormaDePagamento(string formDePagamento)
        {
            if (string.IsNullOrEmpty(formDePagamento))
            {
                return false;
            }
            else
            {
                FormaDePagamento = formDePagamento;
                return true;
            }
        }

        // Aqui vou implementar um metodo para ele ligar o banco de dados e pegar o Id da forma de pagamento reutilizando o metodo acima.
        private void PegarIdFormaDePagamento()
        {
            bool estaPreenchido = AutenticarFormaDePagamento(FormaDePagamento);
            if(estaPreenchido)
            {
                // Aqui eu chamo o metodo para conectar ao banco de dados passando a forma de pagamento que foi selecionada e
                // buscando e pegando o ID pertencente a ela.
            }
        }

        public bool AutenticarStatus(string status)
        {
            if (string.IsNullOrEmpty(status))
            {
                return false;
            }
            else
            {
                Status = status;
                return true;
            }
        }
    }
}
