using SisGenGastosControl;
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

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Cancelar operação?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cancelar == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            GastosFixosCtl gastosFixosCtl = new GastosFixosCtl();
            bool[] autenticados = new bool[5];
            string[] msgErro = new string[5];

            msgErro[0] = "Este campo não pode ser vazio! Preencha o nome corretamente.";
            msgErro[1] = "Este campo não pode ser vazio! Selecione uma categoria.";
            msgErro[2] = "Este campo não pode ser vazio! Informe um valor.";
            msgErro[3] = "Este campo não pode ser vazio! Selecione uma forma de pagamento.";
            msgErro[4] = "Este campo não pode ser vazio! Selecione um status para o pagamento.";

            autenticados[0] = gastosFixosCtl.AutenticarNome(TxtNomeDoGasto.Text);
            autenticados[1] = gastosFixosCtl.AutenticarCategoria(CmbCategoria.Text);
            autenticados[2] = gastosFixosCtl.AutenticarValor(TxtValor.Text);
            autenticados[3] = gastosFixosCtl.AutenticarFormaDePagamento(CmbFormaDePagamento.Text);
            autenticados[4] = gastosFixosCtl.AutenticarStatus(CmbStatusDoPagamento.Text);
            gastosFixosCtl.FormatarData(DtpDataDoPagamento.Text);

            for(int i = 0; i < autenticados.Length; i++)
            {
                if (autenticados[i] == false)
                {
                    MessageBox.Show(msgErro[i], "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                GastosFixosMdl gastosFixosMdl = new GastosFixosMdl();
                gastosFixosCtl.Categoria = gastosFixosMdl.ColetarIdCategoria(gastosFixosCtl);
                gastosFixosCtl.FormaDePagamento = gastosFixosMdl.ColetarIdFormaDePagamento(gastosFixosCtl);

                // Ja esta funcionando os metodos, agora preciso salvar o gasto fixo no banco de dados.
            }
        }

        
    }
}
