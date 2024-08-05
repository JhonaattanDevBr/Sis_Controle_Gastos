using SisGenGastos.Cadastro;
using SisGenGastos.Update;
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

namespace SisGenGastos
{
    public partial class FmGastosFixosConsulta : Form
    {
        public FmGastosFixosConsulta()
        {
            InitializeComponent();
        }

        private void BtnCadastrarNovoGastoFixo_Click(object sender, EventArgs e)
        {
            FmGastosFixosCadastro cadastro = new FmGastosFixosCadastro();
            cadastro.ShowDialog();
            AtulizarTabela();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FmGastosFixosConsulta_Load(object sender, EventArgs e)
        {
            GastosFixosMdl gastosFixos = new GastosFixosMdl();
            DgvTabelaDeGastos.DataSource = gastosFixos.TabelaDeGastosFixos();
            DgvTabelaDeGastos.Columns[0].Width = 70;
            DgvTabelaDeGastos.Columns[1].Width = 140;
            DgvTabelaDeGastos.Columns[2].Width = 70;
            DgvTabelaDeGastos.Columns[3].Width = 140;
            DgvTabelaDeGastos.Columns[5].Width = 70;
            DgvTabelaDeGastos.Columns[6].Width = 140;
            DgvTabelaDeGastos.Columns[7].Width = 90;
        }

        public void AtulizarTabela()
        {
            GastosFixosMdl gastosFixos = new GastosFixosMdl();
            DgvTabelaDeGastos.DataSource = gastosFixos.TabelaDeGastosFixos();
            DgvTabelaDeGastos.Columns[0].Width = 70;
            DgvTabelaDeGastos.Columns[1].Width = 140;
            DgvTabelaDeGastos.Columns[2].Width = 70;
            DgvTabelaDeGastos.Columns[3].Width = 140;
            DgvTabelaDeGastos.Columns[5].Width = 70;
            DgvTabelaDeGastos.Columns[6].Width = 140;
            DgvTabelaDeGastos.Columns[7].Width = 90;
        }

        private void BtnExcluirRegistro_Click(object sender, EventArgs e)
        {
            string idSelecionado = ColetarIdRegistro();
            GastosFixosCtl gastosFixosCtl = new GastosFixosCtl();
            bool devoExcluirRegistro = gastosFixosCtl.PegarIdGastoFixo(idSelecionado);

            if (devoExcluirRegistro)
            {
                DialogResult excluir = MessageBox.Show($"Deseja realmente excluír o registro de Nº{idSelecionado} ?\nEsta operação não pode se desfeita.", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (excluir == DialogResult.Yes)
                {
                    GastosFixosMdl gastosFixosMdl = new GastosFixosMdl();
                    bool foiExcluido = gastosFixosMdl.ExcluirRegistroGastoFixo(idSelecionado);
                    if (foiExcluido)
                    {
                        MessageBox.Show("Registro excluído com sucesso.", "Operação concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtulizarTabela();
                    }
                    else
                    {
                        MessageBox.Show("Registro excluído com sucesso.", "Erro na operação ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private string ColetarIdRegistro()
        {
            return DgvTabelaDeGastos.SelectedCells[0].Value.ToString(); // Aqui ele da um erro quando eu não seleciono nenhuma linha preciso resolver.
        }

        private void BtnAtualizarStatus_Click(object sender, EventArgs e)
        {
            // Vou ter q replicar a interface de cadastro mas agora fazern um update.
            string idSelecionado = ColetarIdRegistro();
            GastosFixosCtl gastosFixosCtl = new GastosFixosCtl();
            bool devoAtualizarRegistro = gastosFixosCtl.PegarIdGastoFixo(idSelecionado);

            if (devoAtualizarRegistro)
            {
                UpdateGastosFixos updateGastosFixos = new UpdateGastosFixos(idSelecionado);
                updateGastosFixos.ShowDialog();
                AtulizarTabela();
            }
        }
    }
}
