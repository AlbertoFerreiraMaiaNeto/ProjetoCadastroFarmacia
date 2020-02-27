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
    public partial class Promocoes : Form
    {
        public Promocoes()
        {

            InitializeComponent();

            int numeroDeLinhas = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(7);
            
            dataGridView1.Rows[0].Cells[0].Value = "Shampoo Jhonson's Baby";
            dataGridView1.Rows[0].Cells[1].Value = "15%";
            dataGridView1.Rows[1].Cells[0].Value = "Protetor Solar Sundown";
            dataGridView1.Rows[1].Cells[1].Value = "20%";
            dataGridView1.Rows[2].Cells[0].Value = "Desodorante Rexona";
            dataGridView1.Rows[2].Cells[1].Value = "25%";
            dataGridView1.Rows[3].Cells[0].Value = "Tylenol Baby";
            dataGridView1.Rows[3].Cells[1].Value = "25%";
            dataGridView1.Rows[4].Cells[0].Value = "Batom Labial Nivea";
            dataGridView1.Rows[4].Cells[1].Value = "30%";
            dataGridView1.Rows[5].Cells[0].Value = "Fralda Pampers";
            dataGridView1.Rows[5].Cells[1].Value = "35%";
            dataGridView1.Rows[6].Cells[0].Value = "Leite Ninho 1+";
            dataGridView1.Rows[6].Cells[1].Value = "40%";

        }
        }
    }