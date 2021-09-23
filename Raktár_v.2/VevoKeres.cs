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
    public partial class VevoKeres : Form
    {
       
        public VevoKeres()
        {
            InitializeComponent();
        }

        private void VevoKeres_Load(object sender, EventArgs e)
        {
            DataGrid_Toltes();
        }

        public void DataGrid_Toltes()
        {
            dataGridView1.DataSource = Seged.VevoKeres_VevokFeltoltes();  
        }

        private void tx_keres_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nev like '{0}%'", tx_keres.Text);
        }

       

        private void tx_keres_Click(object sender, EventArgs e)
        {
            tx_orszagkeres.Text = "";
            Seged.Tortenet(Login.Username, "Vevő keresve(Név alapján)");
        }

       

        private void btn_felvesz_Click(object sender, EventArgs e)
        {

            if (Seged.Tx_Box_text_hossz(tx_tnev.Text,tx_orszag.Text,tx_cim.Text,tx_telefonszam.Text) == true && Seged.TX_Box_szam_3(tx_irszam.Text,"1","1") == true)
            {
                if (Vevo_Adat_kereses() == true)
                {
                    if (tx_cim.Text != string.Empty && tx_irszam.Text != string.Empty && tx_orszag.Text != string.Empty && tx_tnev.Text != string.Empty)
                    {
                        Seged.VevoKeres_VevokFelvetete(tx_tnev.Text, tx_orszag.Text, tx_irszam.Text, tx_cim.Text, tx_telefonszam.Text);
                        MessageBox.Show("Vevő adatai hozzáadava!");

                        Seged.Tortenet(Login.Username, $"{tx_tnev.Text} Vevő Felvéve");
                        DataGrid_Toltes();
                    }
                    else
                    {
                        MessageBox.Show("Töltse ki az összes mezőt!", "Hibaüzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                else
                {
                    MessageBox.Show("Ez a Vevő már létezik az adatbázisban!");
                }
            }
            else
            {
                MessageBox.Show("Nem megfelelő Karakter a mezőben!");
            }
            
        }

        private bool Vevo_Adat_kereses()
        {
            bool result;
            
            int count = Seged.VevoKeres_Vevok_Validacio(tx_tnev.Text,tx_cim.Text);
            if (count > 0)
            {
                result = false;
            }
            else result = true;
            return result;
        }

        private void btn_bezar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void tx_orszagkeres_Click(object sender, EventArgs e)
        {
            tx_keres.Text = "";
            Seged.Tortenet(Login.Username, "Vevő keresve(Ország alapján)");
        }

        private void tx_orszagkeres_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Orszag like '{0}%'", tx_orszagkeres.Text);
        }
    }
}
