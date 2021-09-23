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
    public partial class Loading : Form
    {
        
        public Loading()
        {
            InitializeComponent();
        }

    

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Interval == 1500)
            {
                timer1.Stop();
                this.Hide();
                try
                {
                    int a = 0;
                    Seged.con.Open();

                    SqlCommand com = new SqlCommand("SELECT COUNT(f.ID) FROM felhasznalok f", Seged.con);
                    a = Convert.ToInt32(com.ExecuteScalar());
                    Seged.con.Close();
                    if (a > 0)
                    {
                        Login l = new Login();
                        l.Show();

                    }
                }
                catch (Exception)
                {
                   DialogResult res = MessageBox.Show("Nem tud csatlakozni az adatbázishoz.\nKérem ellenőrizze az internet kapcsolatát!","Hiba a kapcsolódáskor",MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
               
            }
        }
    }
}
