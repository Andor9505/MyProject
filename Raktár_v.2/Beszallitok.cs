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
    public partial class Beszallitok : Form
    {
        private int BeszID;
        private string BeszNev;
        public Beszallitok()
        {
            InitializeComponent();
        }

        private void Beszallitok_Load(object sender, EventArgs e)
        {
            Datagrid_Toltes();
        }

        private void Datagrid_Toltes()
        {
            dataGridView1.DataSource = Seged.Beszallitok_Betoltese();
        }

        private void tx_keres_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nev like '{0}%'", tx_keres.Text);
        }

        private void tx_orszakeres_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Orszag like '{0}%'", tx_orszakeres.Text);
        }

        private void tx_keres_Click(object sender, EventArgs e)
        {
            tx_orszakeres.Text = "";
        }

        private void tx_irszkeres_Click(object sender, EventArgs e)
        {
            tx_keres.Text = "";
        }

        private void btn_felvesz_Click(object sender, EventArgs e)
        {
            if (Seged.Tx_Box_text_hossz(tx_cim.Text, tx_cnev.Text, tx_orszag.Text, tx_varos.Text) == true && Seged.TX_Box_szam_3(tx_irszam.Text, "1", "1") &&
                Seged.Tx_Box_text_hossz(tx_irszam.Text,tx_telefonszam.Text,"a","a"))
            {
                if (Beszallito_ellenorzes() == true)
                {
                    if (tx_cnev.Text != string.Empty && tx_cim.Text != string.Empty && tx_irszam.Text != string.Empty && tx_orszag.Text != string.Empty && tx_telefonszam.Text != string.Empty)
                    {
                        Seged.Beszallitok_felvetele(tx_cnev.Text, tx_orszag.Text, tx_irszam.Text, tx_varos.Text, tx_cim.Text, tx_telefonszam.Text);
                        Seged.Tortenet(Login.Username, $"{tx_cnev.Text} Beszállító felvéve");
                    }
                    else MessageBox.Show("Minden mezőt ki kell tölteni!");

                }
                else MessageBox.Show($"{tx_cnev.Text} besszállító már létezik!");

                Datagrid_Toltes();
            }
            else MessageBox.Show("Ellenőrizze a beírt karaktereket!");
            
        }

        private bool Beszallito_ellenorzes()
        {
            bool result;
            
            int count = Seged.Beszallito_Validalas(tx_cnev.Text);

            if (count > 0)
            {
                result = false;
            }
            else result = true;
            return result;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectIndex = e.RowIndex;
            if (selectIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectIndex];

                tx_cnev.Text = row.Cells[1].Value.ToString();
                BeszID = Convert.ToInt32(row.Cells[0].Value);
                BeszNev = row.Cells[1].Value.ToString();
                tx_orszag.Text = row.Cells[2].Value.ToString();
                tx_irszam.Text = row.Cells[3].Value.ToString();
                tx_varos.Text = row.Cells[4].Value.ToString();
                tx_cim.Text = row.Cells[5].Value.ToString();
                tx_telefonszam.Text = row.Cells[6].Value.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Seged.Tx_Box_text_hossz(tx_cim.Text, tx_cnev.Text, tx_orszag.Text, tx_varos.Text) == true && Seged.TX_Box_szam_3(tx_irszam.Text, "1", "1") &&
               Seged.Tx_Box_text_hossz(tx_irszam.Text, tx_telefonszam.Text, "a", "a"))
            {
                if (tx_cnev.Text != string.Empty && tx_orszag.Text != string.Empty && tx_irszam.Text != string.Empty && tx_cim.Text != string.Empty && tx_telefonszam.Text != string.Empty)
                {

                    Seged.Beszallito_Szerkesztes(tx_cnev.Text, tx_orszag.Text, tx_irszam.Text, tx_varos.Text, tx_cim.Text, tx_telefonszam.Text, BeszID);
                    Seged.Tortenet(Login.Username, $"{tx_cnev.Text} Beszállító adatai módosítva");

                    Datagrid_Toltes();
                }

                else MessageBox.Show("Ne hagyjon üres mezőt!");

            }
            else MessageBox.Show("Ellenőrizze a beírt karaktereket!");
                
            
        }
    }
}
