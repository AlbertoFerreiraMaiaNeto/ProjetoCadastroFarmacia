using FarmaciaPagueMenos.DAO;
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
    public partial class form_Bemvindo : Form
    {
        SqlCommand cmd = new SqlCommand();
        Connection con = new Connection();
        SqlDataReader dr;
        public string nome = "";
        public string mensagem = "";
        public form_Bemvindo()
        {
            InitializeComponent();
        }

        private void form_Bemvindo_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_Bemvindo_Click(object sender, EventArgs e)
        {

        }

        private void promoçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void promoçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Promocoes promocoes = new Promocoes();
            promocoes.ShowDialog();
        }
    }
}
