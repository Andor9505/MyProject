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
using System.Text.RegularExpressions;

namespace Raktár_v._2
{
    public partial class Reg : Form
    {
       
        public static bool Sucess = true;
        public Reg()
        {
            InitializeComponent();
        }

        private void btn_vissza_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
            Form_Betoltes();
        }

        private void Form_Betoltes()
        {
            combo_Jog.Items.Add("Raktáros");
            combo_Jog.Items.Add("Admin");
            tx_jelszo.PasswordChar = '*';
            Sucess = true;
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (Login.Karakter_kodolaa(tx_jelszo.Text,tx_user.Text) == true)
            { 
                if (tx_user.Text!= string.Empty && tx_jelszo.Text != string.Empty && combo_Jog.SelectedIndex != -1)
                {
                    if (Sucess == true && Reg_validacio() == true)
                    {
                        Seged.Regisztacio(tx_user.Text,tx_jelszo.Text,combo_Jog.SelectedIndex);
                        Seged.Tortenet(tx_user.Text,"Regisztrált");
                        tx_user.Text = "";
                        tx_jelszo.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("Ez a felhasználó név már foglalt.");
                    }
                
                }
                else
                {
                    MessageBox.Show("Hibás adatok!","Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ne használjon különleges karaktereket!");
            }
           
            
        }

        private bool Reg_validacio()
        {
            bool resul;

            int count = Seged.Reg_Validalas(tx_user.Text); //Felhaszáló név ellenörzés

            if (count > 0)
            {
                resul = false;
            }
            else resul = true;
            return resul;
        }

        private void combo_Jog_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Jog.SelectedIndex == 1)
            {
                Sucess = false;
                LogAdmin la = new LogAdmin();
                la.Show();
            }
            else
            {
                Sucess = true;
            }
        }
    }
}
