using SisGenGastosModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisGenGastos.Cadastro
{
    public partial class FmGastosFixosCadastro : Form
    {
        public FmGastosFixosCadastro()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Cancelar operação?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(cancelar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TxtNomeDoGasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void DtpDataDoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 46 && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void FmGastosFixosCadastro_Load(object sender, EventArgs e)
        {

            List<string> categorias = new List<string>();
            CategoriasMdl catMdl = new CategoriasMdl();
            CmbCategoria.Items.Clear();
            categorias = catMdl.ConsultarCategorias();
            foreach (string listaDeCategorias in categorias.ToList())
            {
                CmbCategoria.Items.Add(listaDeCategorias);
            }

            List<string> formasDePagamento = new List<string>(); 
            FormaDePagamentoMdl formPagMdl = new FormaDePagamentoMdl();
            CmbFormaDePagamento.Items.Clear();
            formasDePagamento = formPagMdl.ConsultarFormasDePagamento();
            foreach (string listaDeFormasDePagamento in formasDePagamento.ToList())
            {
                CmbFormaDePagamento.Items.Add(listaDeFormasDePagamento);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            CategoriasMdl catMdl = new CategoriasMdl();
            FormaDePagamentoMdl formPagMdl = new FormaDePagamentoMdl();


        }
    }
}
