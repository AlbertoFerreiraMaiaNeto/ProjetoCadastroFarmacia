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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jaSouCliente_Click(object sender, EventArgs e)
        {
            form_JaSouCliente formJasouCliente = new form_JaSouCliente();
            formJasouCliente.ShowDialog();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            form_Cadastrar formCadastrar = new form_Cadastrar();
            formCadastrar.ShowDialog();
        }
    }
}
