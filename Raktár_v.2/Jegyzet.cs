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
    public partial class Jegyzet : Form
    {
        private string jegyzetnev;
        public Jegyzet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Seged.Tx_Box_text_hossz(tx_jegyzetnev.Text,"","",""))
            {
                if (Validate_jegyzetek() == true)
                {
                    if (tx_jegyzetnev.Text != string.Empty && tx_jegyzetszoveg.Text != string.Empty)
                    {

                        Seged.Jegyzet_Hozzaadas(tx_jegyzetnev.Text, tx_jegyzetszoveg.Text);
                        tx_jegyzetnev.Text = "";
                        tx_jegyzetszoveg.Text = "ide írd a jegyzetet...";
                        Seged.Tortenet(Login.Username, $"{tx_jegyzetnev.Text} Jegyzet felvéve.");
                        Datagrid_Toltes();
                    }
                    else
                    {
                        MessageBox.Show("Minden mezőt ki kell tölteni!");
                    }
                }
                else
                {
                    MessageBox.Show("Már létezik ilyen névvel jegyzet!");
                }
            }
            else
            {
                MessageBox.Show("Túl hosszú a Jegyzetnév!");
            }
        }

        private bool Validate_jegyzetek()
        {
            bool resul;

            int count = Seged.Jegyzet_Validalas(tx_jegyzetnev.Text);
            
            if (count > 0)
            {
                resul = false;
            }
            else resul = true;

            return resul;
        }

        private void Jegyzet_Load(object sender, EventArgs e)
        {
            Datagrid_Toltes();
        }

        private void Datagrid_Toltes()
        {            
            dataGridView1.DataSource = Seged.Jegyzet_Feltoltes(); 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                jegyzetnev = row.Cells[2].Value.ToString();
                tx_jegyzetnev.Text = row.Cells[2].Value.ToString();
                tx_jegyzetszoveg.Text = row.Cells[3].Value.ToString();
            }
            
        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Biztosan Törli?", "Töröl", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (re == DialogResult.Yes)
            {
                if (tx_jegyzetnev.Text != string.Empty)
                {
                    Seged.Jegyzet_Torles(jegyzetnev);
                    Datagrid_Toltes();
                    tx_jegyzetnev.Text = "";
                    tx_jegyzetszoveg.Text = "ide írd a jegyzetet...";
                    Seged.Tortenet(Login.Username, $"{tx_jegyzetnev.Text} Törölve");
                }

                else
                {
                    MessageBox.Show("Nincs sor kijelölve!");
                }
            }
           
        }

         private void tx_jegyzetszoveg_Click(object sender, EventArgs e)
        {
            tx_jegyzetszoveg.Text = "";
        }
    }
}
