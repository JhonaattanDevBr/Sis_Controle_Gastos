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
    public partial class FmTelaInicial : Form
    {
        public FmTelaInicial()
        {
            InitializeComponent();
        }

        private void BtnGastosFixos_Click(object sender, EventArgs e)
        {
            FmGastosFixosConsulta gastosFixos = new FmGastosFixosConsulta();
            gastosFixos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // Esse evento é provisorio apenas para testar o metodo de cadastro de categorias.
        {
            CadastroDeCategorias categoriaTela = new CadastroDeCategorias();
            categoriaTela.ShowDialog();
        }
    }
}
