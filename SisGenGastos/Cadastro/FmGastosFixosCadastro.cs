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
    }
}
