using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiro_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var temErro = "N";
            if(txtNome.Text.Length == 0){ 
                MessageBox.Show("Informe o nome!");
                txtNome.Focus();
                temErro = "S";
            }

            if (txtSobreNome.Text.Length == 0)
            {
                MessageBox.Show("Informe o Sobrenome!");
                txtSobreNome.Focus();
                temErro = "S";
            }

            if (temErro == "N") 
            { 
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.Close();
            }
        }
    }
}
