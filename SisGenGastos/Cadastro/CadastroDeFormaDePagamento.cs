using SisGenGastosControl;
using SisGenGastosModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisGenGastos.Cadastro
{
    public partial class CadastroDeFormaDePagamento : Form
    {
        public CadastroDeFormaDePagamento()
        {
            InitializeComponent();
        }

        private void TxtNomeDaFormaDePagamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            FormaDePagamentoCtl FpgCtl = new FormaDePagamentoCtl();
            bool devoProseguir = FpgCtl.AutenticarNome(TxtNomeDaFormaDePagamento.Text);
            if (devoProseguir)
            {
                FormaDePagamentoMdl mdlCat = new FormaDePagamentoMdl();
                bool foiCadastrado = mdlCat.CadastrarNovaFormaDePagamento(FpgCtl);
                if (foiCadastrado)
                {
                    MessageBox.Show("Uma nova forma de pagamento foi cadastrada.", "OPERAÇÃO CONCLUÍDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNomeDaFormaDePagamento.Focus();
                    TxtNomeDaFormaDePagamento.SelectAll();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar uma nova forma de pagamento.", "FALHA NA OPERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNomeDaFormaDePagamento.Focus();
                    TxtNomeDaFormaDePagamento.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome corretamente", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtNomeDaFormaDePagamento.Focus();
                TxtNomeDaFormaDePagamento.SelectAll();
            }
        }
    }
}
