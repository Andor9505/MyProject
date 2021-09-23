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
    public partial class LogAdmin : Form
    {
       
        public LogAdmin()
        {
            InitializeComponent();
        }

        private void LogAdmin_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }

        private void btn_adminvalid_Click(object sender, EventArgs e)
        {

            int count =Seged.Mester_Kulcs(textBox1.Text);

            if (count > 0)
            {
                MessageBox.Show("Jelszó Elfogadva!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reg.Sucess = true;
                this.Close();
            }

            else { Reg.Sucess = false; MessageBox.Show("Hibás Jelszó!"); }

        }
    }
}
