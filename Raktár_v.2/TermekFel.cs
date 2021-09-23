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
    public partial class TermekFel : Form
    {
        
        
        public TermekFel()
        {
            InitializeComponent();
        }
        
        private void TermekFel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.termekek' table. You can move, or remove it, as needed.
            
            DataGrid_Feltoltes();
            Combo_Feltoltes_beszallito();
            Combo_Feltoltes_kategoria();
        }

        private void Combo_Feltoltes_kategoria()
        {
            combo_kategoria.Text = "   --Választás--";
            DataTable dt = Seged.Termekkeres_KategotiaCombobox_Feltoltes();
            foreach (DataRow item in dt.Rows)
            {
                combo_kategoria.Items.Add(item["katNev"].ToString());
            }
            Seged.con.Close();
        }

        private void DataGrid_Feltoltes()
        {
            dataGridView1.DataSource = Seged.TermekKeres_TermekFeltoltes();
        }

        private void Combo_Feltoltes_beszallito()
        {
            combo_beszallito.Text = "   --Választás--";

            DataTable dt = Seged.Termek_BeszallitoCombo_Feltoltes();
            foreach (DataRow item in dt.Rows)
            {
                combo_beszallito.Items.Add(item["Nev"].ToString());
            }

            
        }

        private int Cikkszam_Generator()
        {
            if (Seged.TX_Box_szam_3(tx_cikkszam.Text,"1","1"))
            {

            }
            Random rnd = new Random();
            return rnd.Next(1,99999);
        }

        private void btn_general_Click(object sender, EventArgs e)
        {
           
            tx_cikkszam.Text = Cikkszam_Generator().ToString();
        }

        private void btn_kepmegnyit_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pic_termek.Image = Image.FromFile(opf.FileName);
                }
            }
        }

        private void btn_felvesz_Click(object sender, EventArgs e)
        {
            
            if (Seged.TX_Box_szam_3(tx_cikkszam.Text,tx_ar.Text,tx_keszlet.Text) == true && Seged.Tx_Box_text_hossz(tx_termeknev.Text,"","",""))
            {
                if (tx_cikkszam.Text != string.Empty && tx_ar.Text != string.Empty && tx_keszlet.Text != string.Empty && tx_keszlet.Text != string.Empty && combo_beszallito.SelectedIndex != -1 && combo_kategoria.SelectedIndex != -1)
                {
                    if (Termek_Ellenorzes(tx_termeknev.Text, tx_cikkszam.Text))
                    {
                        if (PictureBox_kep_ellenorzes() == true)
                        {
                            Seged.TermekFelvetel_Keppel(Seged.KatComboSelect(combo_kategoria.SelectedItem), tx_termeknev.Text, tx_cikkszam.Text, tx_keszlet.Text, tx_ar.Text, pic_termek.Image, pic_qrcode.Image,Seged.BeszallitoCombo(combo_beszallito.SelectedItem.ToString()));
                            Seged.Tortenet(Login.Username, $"{tx_termeknev.Text} Felvétele");
                            MessageBox.Show("Termék Hozzáadva!");
                            pic_termek.Image = null;
                            tx_cikkszam.Text = "";
                            tx_termeknev.Text = "";
                            pic_qrcode.Image = null;
                        }
                        else
                        {
                            Seged.TermekFelvetel_Kepnelkul(Seged.KatComboSelect(combo_kategoria.SelectedItem), tx_termeknev.Text, tx_cikkszam.Text, tx_keszlet.Text, tx_ar.Text, pic_qrcode.Image, Seged.BeszallitoCombo(combo_beszallito.SelectedItem.ToString()));
                            Seged.Tortenet(Login.Username, $"{tx_termeknev.Text} Felvétele");
                            MessageBox.Show("Termék Hozzáadva!");
                            pic_termek.Image = null;
                            tx_cikkszam.Text = "";
                            pic_qrcode.Image = null;
                        }
                        DataGrid_Feltoltes();
                    }
                    else
                    {
                        MessageBox.Show("Ez a terméknév vagy Cikkszám foglalt!", "Foglalt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Kérem töltse ki az összes mezőt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Helyzeten Karakterformátum a mezőben!");
            }
        }

        private bool Termek_Ellenorzes(string _tnev, string _cikkszam)
        {
            
            bool result;
            int count = Seged.Termek_Ellenorzes(_tnev,_cikkszam);

            if (count > 0)
            {
                result = false;
            }
            else result = true;
            return result;
        }

        public static Image QR_Kod_generalas(string _cikkszam)
        {
            Image result;

            QRCoder.QRCodeGenerator qg = new QRCoder.QRCodeGenerator();
            var mydata = qg.CreateQrCode(_cikkszam, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(mydata);
            result = code.GetGraphic(50);

            return result;
        }

       

        private void tx_cikkszam_TextChanged(object sender, EventArgs e)
        {
            if (tx_cikkszam.Text != string.Empty)
            {
                pic_qrcode.Image = QR_Kod_generalas(tx_cikkszam.Text);
            }
        }

       

        public bool PictureBox_kep_ellenorzes()
        {
            bool result;

            if (pic_termek.Image == null)
            {
                result = false;
            }
            else result = true;

            return result;
        }

       
    }
}
