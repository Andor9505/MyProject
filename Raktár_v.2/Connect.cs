using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raktár_v._2
{
    public partial class Connect : Form
    {

        public static string eleres = @"C:\Users\Andor\source\repos\Raktár_v.2\Raktár_v.2\Database1.mdf";
        
        public Connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    eleres = opf.FileName;
                    Seged.con = new System.Data.SqlClient.SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={eleres};Integrated Security=True");
                    Loading f = new Loading();
                    f.Show();
                    this.Close();
                }
            }
          
        }

       

        private void Connect_Load(object sender, EventArgs e)
        {
           
        }
    }
}
