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
    public partial class TermekKiad : Form
    {
        private int termekID;
        private int vevoid;
        private bool szam_e = false;

        public TermekKiad()
        {
            InitializeComponent();

        }

        private void TermekKiad_Load(object sender, EventArgs e)
        {
            Datagrid_Toltes();
        }

        private void Datagrid_Toltes()
        {
            datatermekgrid.DataSource = Seged.TermekKiadas_Termekfeltoltes();
            datavevogrid.DataSource = Seged.TermekKiadas_VevoFeltoltes();
        }

        private void datatermekgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectindex = e.RowIndex;
            if (selectindex >= 0)
            {
            DataGridViewRow row = datatermekgrid.Rows[selectindex];
            tx_termeknev.Text = row.Cells[1].Value.ToString();
            tx_termar.Text = row.Cells[2].Value.ToString();
            tx_keszleten.Text = row.Cells[3].Value.ToString();
            termekID = Convert.ToInt32(row.Cells[0].Value);
            }
            

            if (tx_termeknev.Text != string.Empty)
            {
                tx_kellmennyiseg.Enabled = true;
            }

        }

        private void datavevogrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectindex = e.RowIndex;

            if (selectindex >= 0)
            {
                DataGridViewRow row = datavevogrid.Rows[selectindex];
                tx_vevonev.Text = row.Cells[1].Value.ToString();
                vevoid = Convert.ToInt32(row.Cells[0].Value);

            }
            

        }

        private void btn_kiad_Click(object sender, EventArgs e)
        {
            int marad = 0;
            int osszeg = 0;
            if (Text_Box_ellenorzes() == true && szam_e == true)
            {
                if (Keszlet_ellenorzes() == true)
                {
                    DialogResult di = MessageBox.Show("Kiadja a terméket?", "Véglegesítés", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (di == DialogResult.Yes)
                    {
                        marad = Convert.ToInt32(tx_keszleten.Text) - Convert.ToInt32(tx_kellmennyiseg.Text);
                        osszeg = Convert.ToInt32(tx_termar.Text) * Convert.ToInt32(tx_kellmennyiseg.Text);
            
                        Seged.KeszletModositas(marad,termekID);
                       
                        Seged.TermekKiad_Kiadott_Termekek(vevoid,tx_vevonev.Text,tx_termeknev.Text,tx_termar.Text,tx_kellmennyiseg.Text,osszeg);

                        Datagrid_Toltes();

                        Seged.Tortenet(Login.Username,$"{tx_kellmennyiseg.Text} DB kiadva {tx_termeknev.Text} -ből");
                        //txbox szöveg törlése
                        tx_termeknev.Text = "";
                        tx_keszleten.Text = "";
                        tx_termar.Text = "";
                    }

                }
                else MessageBox.Show($"A(z) {tx_termeknev.Text} termékből a kért mennyiség nincs raktáron!");

            }

            else
            {
                MessageBox.Show("Kéerem ellenőrizze a mezőket és a készletet!");
            }
        }

        private bool Keszlet_ellenorzes()
        {
            bool result;
            if ((Convert.ToInt32(tx_keszleten.Text) - Convert.ToInt32(tx_kellmennyiseg.Text)) >= 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        private bool Text_Box_ellenorzes()
        {
            bool result = true;
            if (tx_termeknev.Text != string.Empty && tx_vevonev.Text != string.Empty && tx_termar.Text != string.Empty && tx_kellmennyiseg.Text != string.Empty)
            {
                result = true;
            }
            else result = false;

            return result;
        }

        private void tx_kellmennyiseg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled != char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(lbl_error, "Csak Számot adjon meg!");
                lbl_error.Text = "";
                szam_e = true;
            }
            else
            {
                errorProvider1.SetError(lbl_error, "Csak Számot adjon meg!");
                lbl_error.Text = "Csak számot adjon meg!";
                szam_e = false;
            }
        }

        private void tx_kellmennyiseg_TextChanged(object sender, EventArgs e)
        {
            int osszeg = 0;
            if (szam_e == true && tx_termar.Text != string.Empty)
            {
                osszeg = Convert.ToInt32(tx_termar.Text) * Convert.ToInt32(tx_kellmennyiseg.Text);
                tx_arosszesen.Text = osszeg.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VevoKeres v = new VevoKeres();
            v.ShowDialog();
            
        }

        private void btn_frissit_Click(object sender, EventArgs e)
        {
            Datagrid_Toltes();
        }
    }
}
