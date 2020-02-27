using FarmaciaPagueMenos.DAO;
using FarmaciaPagueMenos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmaciaPagueMenos
{
    public partial class form_JaSouCliente : Form
    {
        public form_JaSouCliente()
        {
            InitializeComponent();
        }

        private void form_JaSouCliente_Load(object sender, EventArgs e)
        {

        }

        private void mskTxt_CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            
            Controle controle = new Controle();
            controle.acessar(mskBox_Cpf.Text, mskBox_Senha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Entrando", "Bem-vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form_Bemvindo formBemVindo = new form_Bemvindo();
                    formBemVindo.Show();
                    
                }
                else
                {
                    MessageBox.Show("CPF ou Senha estão incorretos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}