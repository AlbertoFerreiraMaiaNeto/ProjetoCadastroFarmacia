using FarmaciaPagueMenos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaPagueMenos
{
    public partial class form_Cadastrar : Form
    {
        public form_Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            String mensagem = controle.cadastrar(txtNome.Text, txtCPF.Text, txtSenha.Text, txtConfSenha.Text);

            if(controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
