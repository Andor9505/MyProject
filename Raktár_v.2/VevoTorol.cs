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
    public partial class VevoTorol : Form
    {
        private int publikID;
        private string publikNev;
        
        public VevoTorol()
        {
            InitializeComponent();
        }

        private void VevoTorol_Load(object sender, EventArgs e)
        {
            Datagrid_Toltes();
        }

        private void Datagrid_Toltes()
        {
           
            dataGridView1.DataSource = Seged.VevoKeres_VevokFeltoltes();

            Seged.con.Close();
        }

        private void btn_szerkeszt_Click(object sender, EventArgs e)
        {
            if (Seged.Tx_Box_text_hossz(tx_tnev.Text,tx_telefonszam.Text,tx_orszag.Text,tx_cim.Text) == true && Seged.TX_Box_szam_3(tx_irszam.Text,"1","1") == true)
            {
                if (tx_cim.Text != string.Empty && tx_irszam.Text != string.Empty && tx_orszag.Text != string.Empty && tx_tnev.Text != string.Empty && tx_telefonszam.Text != string.Empty)
                {

                    Seged.Vevoszerkesztes(tx_tnev.Text, tx_orszag.Text, tx_irszam.Text, tx_cim.Text, tx_telefonszam.Text, publikID);
                    MessageBox.Show("Szerkesztés sikeres!");


                    Seged.Tortenet(Login.Username, $"{tx_tnev.Text} Vevő adatai szerkesztve");
                    Datagrid_Toltes();

                }
                else MessageBox.Show("Töltse ki mindegyik mezőt!");
            }
            else
            {
                MessageBox.Show("Helyzeten karakterformátum a mezőben!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIndex = e.RowIndex;
            if (selectIndex >= 0)
            {
                DataGridViewRow selectrow = dataGridView1.Rows[selectIndex];
                tx_tnev.Text = selectrow.Cells[1].Value.ToString();
                tx_orszag.Text = selectrow.Cells[2].Value.ToString();
                tx_irszam.Text = selectrow.Cells[3].Value.ToString();
                tx_cim.Text = selectrow.Cells[4].Value.ToString();
                tx_telefonszam.Text = selectrow.Cells[5].Value.ToString();
                publikNev = selectrow.Cells[1].Value.ToString();
                publikID = Convert.ToInt32(selectrow.Cells[0].Value);
            }
           

            // TEXTBOX ENABLED

            tx_tnev.Enabled = true;
            tx_orszag.Enabled = true;
            tx_irszam.Enabled = true;
            tx_cim.Enabled = true;
            tx_telefonszam.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Text_box_ellentorzes() == true)
            {
                DialogResult dr = MessageBox.Show($"Biztosan törli a {publikNev} nevű vevőt?", "Biztosan törli?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    Seged.VevoTorles(publikID);
                    Seged.Tortenet(Login.Username,$"{publikNev} Vevő törölve");
                    Datagrid_Toltes();
                }
                
            }
            else MessageBox.Show("Nincs oszlop kijelölve!");
        }

        private bool Text_box_ellentorzes()
        {
            bool result;

            if (tx_cim.Text == string.Empty || tx_irszam.Text == string.Empty || tx_orszag.Text == string.Empty || tx_tnev.Text == string.Empty)
            {
               
                result = false;
                
            }
            else result = true;

            return result;
        }
        
    }
}
