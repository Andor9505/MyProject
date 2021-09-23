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
using System.IO;

namespace Raktár_v._2
{
    public partial class TermekTorles : Form
    {
        private int termID;
        private string tnev;
        private int rowindex;
       
        public TermekTorles()
        {
            InitializeComponent();
            
        }

        private void TermekTorles_Load(object sender, EventArgs e)
        {
            Row_color();
            //Táblázat feltöltése
            Datagrid_Toltes();
            
        }

        private void Row_color()
        {
            if (dataGrid1.Rows.Count > 0)
            { 
                foreach (DataGridViewRow da in dataGrid1.Rows)
                {
                if (Convert.ToInt32(da.Cells[3].Value) == 0)
                {
                    da.DefaultCellStyle.BackColor = Color.Red;
                    da.DefaultCellStyle.ForeColor = Color.White;
                }
                }

            }
           
           
        }

        private void Datagrid_Toltes()
        {
            dataGrid1.DataSource = Seged.TermekTorles_TermekFeltoltes();
          
        }

        private void dataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kiválaszott sorok,oszlopok átadása textBoxok-nak
            int selectedI = e.RowIndex; // táblátat szerinti sorindex
            rowindex = selectedI;
            if (selectedI >=0)
            {
            DataGridViewRow selectrow = dataGrid1.Rows[selectedI];
            tx_termeknev.Text = selectrow.Cells[1].Value.ToString();
            tx_cikkszam.Text = selectrow.Cells[2].Value.ToString();
            tx_keszlet.Text = selectrow.Cells[3].Value.ToString();
            tx_ar.Text = selectrow.Cells[4].Value.ToString();
            tx_katnev.Text = selectrow.Cells[5].Value.ToString();
            tx_besznev.Text = selectrow.Cells[6].Value.ToString();
            termID = Convert.ToInt32(selectrow.Cells[0].Value); // termék ID átadása, a pontos kép kiválasztása miatt
            tnev = selectrow.Cells[1].Value.ToString();
            pic_qr.Image = TermekFel.QR_Kod_generalas(tx_cikkszam.Text);
            }
           

            if (van_e_termekkep(termID) == true) //csak akkor keresi ki a képet ha az adott termékhez van kép(Hibaelkerülés)
            {
                pic_termek.Visible = true;
                pic_termek.Image = Kep_kereses(termID);
            }
            else pic_termek.Visible = false;

            //TEXT enebled
            tx_termeknev.Enabled = true;
            tx_cikkszam.Enabled = true;
            tx_keszlet.Enabled = true;
            tx_ar.Enabled = true;
            Row_color();
        }

        private bool van_e_termekkep(int _selectedI)
        {
            bool result;
            Seged.con.Open();

            SqlCommand com = new SqlCommand("SELECT count(*) from termekek t where TermekId = @id and Kep is not null", Seged.con);
            com.Parameters.AddWithValue("@id",_selectedI);
            com.ExecuteNonQuery();
            int count = Convert.ToInt32(com.ExecuteScalar());
            Seged.con.Close();
            if (count > 0)
            {
                result = true;

            }
            else
            {
                result = false;
            }
            return result;
        }

        private Image Kep_kereses(int _selectedI) //adatbázisból kikeresi a hozzá tartozó képet
        {
            Image result;

            Seged.con.Open();
            SqlCommand com = new SqlCommand("select Kep from termekek where TermekID = @id", Seged.con);
            com.Parameters.AddWithValue("@id",_selectedI);
            com.ExecuteNonQuery();
            result = Byte_to_kep((byte[])com.ExecuteScalar());
            Seged.con.Close();

            return result;
        }

        private Image Byte_to_kep(byte[] _bit)
        {
            Image result;

            MemoryStream ms = new MemoryStream(_bit);
            result = Image.FromStream(ms);

            return result;
        } //Adatbázisból lekérdezett byte kód képpé alakítása

        private void tx_cikkszam_TextChanged(object sender, EventArgs e)
        {
            pic_qr.Image = TermekFel.QR_Kod_generalas(tx_cikkszam.Text);
        }

        private void btn_kepmegnyit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    pic_termek.Image = Image.FromFile(of.FileName);
                    pic_termek.Visible = true;
                }
                else pic_termek.Visible = false;
            }
        }//kép feltöltés

        private void tx_tnkeres_TextChanged(object sender, EventArgs e)
        {
            (dataGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("TermekNev like '{0}%'", tx_tnkeres.Text);
        }

        private void tx_cikkkeres_TextChanged(object sender, EventArgs e)
        {
            (dataGrid1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cikkszam like '{0}%'", tx_cikkkeres.Text);
        }

        private void tx_tnkeres_Click(object sender, EventArgs e)
        {
            tx_cikkkeres.Text = "";
        } //Üres string-et ad a másik TextBoxnak

        private void tx_cikkkeres_Click(object sender, EventArgs e)
        {
            tx_tnkeres.Text = "";
        }

        private void btn_szerkeszt_Click(object sender, EventArgs e)
        {
            if (Seged.TX_Box_szam_3(tx_ar.Text,tx_cikkszam.Text,tx_keszlet.Text) == true && Seged.Tx_Box_text_hossz(tx_termeknev.Text,"","",""))
            {
                if (Text_box_Ellenorzes() == true)
                {
                    if (van_e_termekkep(termID) == true || pic_termek.Image != null)
                    {

                        Seged.TErmekTorol_Szerkesztes_Keppel(tx_termeknev.Text, tx_cikkszam.Text, tx_keszlet.Text, tx_ar.Text, pic_termek.Image, pic_qr.Image, termID);
                        MessageBox.Show("Termék modosítva!");
                        Seged.Tortenet(Login.Username, $"{tx_termeknev.Text} módosítva");
                        Datagrid_Toltes();
                    }
                    else
                    {
                        Seged.Termektotol_Szerkesztes_kepnelkul(tx_termeknev.Text, tx_cikkszam.Text, tx_keszlet.Text, tx_ar.Text, pic_qr.Image, termID);
                        Seged.Tortenet(Login.Username, $"{tx_termeknev.Text} módosítva");
                        Datagrid_Toltes();
                    }
                }

                else
                {
                    MessageBox.Show("Üresen hagyott mező!");
                }
            }
            else
            {
                MessageBox.Show("Helytelen karakterformátum a mezőben!");
            }
            Row_color();
        }

        private void btn_torol_Click(object sender, EventArgs e)
        {
            
            if (Text_box_Ellenorzes() == true)
            {
                DialogResult torol = MessageBox.Show($"Biztosan törlia {tnev} nevű terméket?", "Biztos Benne?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (torol == DialogResult.Yes)
                {

                    if (dataGrid1.SelectedRows != null && Text_box_Ellenorzes() == true)
                    {
                        Seged.TermekTorol_Torol(termID);
                        MessageBox.Show($"{tnev} termék törölve.");
                        Seged.Tortenet(Login.Username, $"{tx_termeknev.Text} Törölve");
                    }
                    Datagrid_Toltes();

                }

            }
            else
            {
                MessageBox.Show("Nincs kijelölve termék!");
            }
            Row_color();

        }
        public bool Text_box_Ellenorzes()
        {
            bool result;

            if (tx_ar.Text == string.Empty || tx_keszlet.Text == string.Empty || tx_termeknev.Text == string.Empty || tx_cikkszam.Text == string.Empty)
            {
                result = false;
            }
            else result = true;

            return result;
        }
    }
}
