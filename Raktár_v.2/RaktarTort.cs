using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Raktár_v._2
{
    public partial class RaktarTort : Form
    {//comm
        public RaktarTort()
        {
            InitializeComponent();
        }

        private void RaktarTort_Load(object sender, EventArgs e)
        {
            Form_Betoltes();
        }

        private void Form_Betoltes()
        {
            comboBox1.Items.Add("Raktár Előzmények");
            comboBox1.Items.Add("Kiadott Termékek");
            comboBox1.Items.Add("Elfogyott Termékek");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
               dataGridView1.DataSource= Seged.Raktartortenet();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = Seged.Kiadott_termekek();
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = Seged.Elfogyott_termek();
            }
        }

        private void btn_torles_Click(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedIndex == 0)
            { DialogResult di = MessageBox.Show("Biztos törli az adatokat?","Biztos Benne?",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (di == DialogResult.Yes)
                {
                    Seged.Raktartortenet_torles();
                    Seged.Tortenet(Login.Username, "Előzmények Törlése");
                   dataGridView1.DataSource=  Seged.Raktartortenet(); 
                }
            }
           
            else
            {
                MessageBox.Show("Csak a Rakrár előzményeket tudjuk törölni!");
            }
        }
    }
}
