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
    public partial class Login : Form
    {
        public static string Username;
        public static string Jog;
        public static int UserID; 

        public Login()
        {
            InitializeComponent();
            
        }

        private void Form_Betoltes()
        {
            tx_pass.PasswordChar = '*';
           
        }

       

        private void btn_reg_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            this.Hide();
            r.Show();
        }

        private void btn_kilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Seged.Tortenet("Ismeretlen", "Megnyitották a programot de bezárták");
        }

        private void btn_belep_Click(object sender, EventArgs e)
        {
            if (tx_pass.Text.Length < 20 && tx_username.Text.Length < 20 && Karakter_kodolaa(tx_username.Text,tx_pass.Text) == true)
            { 
                    if (User_Validate() == true)
                    {
                    Jog = Seged.Jog_Login(tx_username.Text,tx_pass.Text); //Jogosultásgot adja vissza
                    UserID = Seged.UserID_feltoltes(tx_username.Text, tx_pass.Text); //user ID adja vissza
                    MainForm m = new MainForm();
                    this.Hide();
                    m.Show(); 
                     }

                    else
                     {
                    MessageBox.Show("Nem megfelelő felhasználónév vagy jelszó!","Hibás Adatok",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }

            }
            else
            {
                MessageBox.Show("Ne használjon különleges karaktereket!");
            }
           
            
        }

       public static bool Karakter_kodolaa(string _tx1, string _tx2)
        {
            bool result = true;
            if (Regex.IsMatch(_tx1,"['|/|!|%|=|(|)|{|}|?|:|-|.|<|>|]") || Regex.IsMatch(_tx2, "['|/|!|%|=|(|)|{|}|?|:|-|.|<|>|]"))
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        private bool User_Validate()
        {
           bool result;
           int count = Seged.User_Validalas(tx_username.Text, tx_pass.Text);

            if (count >0)
            {
                result = true;
                Username = tx_username.Text;
                
            }

            else result = false;

            return result;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Form_Betoltes();
        }

        private void tx_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_belep_Click(sender, e);
            }
        }

        private void tx_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_belep_Click(sender, e);
            }
        }
    }
}
