using SisGenGastos.Cadastro;
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
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
