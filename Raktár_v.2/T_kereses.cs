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
    
    public partial class T_kereses : Form
    {
      
       

        public T_kereses()
        {
            InitializeComponent();  
        }

        private void T_kereses_Load(object sender, EventArgs e)
        {
            Loading_combobox();
            Datagrid_Toltes();
           
        }

      

        private void Loading_combobox()
        {
            DataTable dt = Seged.Termekkeres_KategotiaCombobox_Feltoltes();
            foreach (DataRow item in dt.Rows)
            {
                comboBox1.Items.Add(item["katNev"].ToString());
            }
           
        }

        private void Datagrid_Toltes()
        {
            dataGridView1.DataSource = Seged.TermekKeres_TermekFeltoltes();
        }

        private void tx_keres_TextChanged(object sender, EventArgs e)
        {
          
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("TermekNev like '{0}%'", tx_keres.Text);
        }

        private void tx_cikkszam_TextChanged(object sender, EventArgs e)
        {
            
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Cikkszam like '{0}%'",tx_cikkszam.Text);
        }

        private void tx_keres_Click(object sender, EventArgs e)
        {
         tx_cikkszam.Text = "";
            comboBox1.SelectedIndex = -1;
           
            Seged.Tortenet(Login.Username, "Termék Keresés(Név alapján)");
        }

        private void tx_cikkszam_Click(object sender, EventArgs e)
        {
         tx_keres.Text = "";
         comboBox1.SelectedIndex = -1;
            
            Seged.Tortenet(Login.Username, "Termék Keresés(Cikkszám alapján)");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tx_keres.Text = "";
            tx_cikkszam.Text = "";
            if (comboBox1.SelectedIndex != -1)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Kategória like '{0}%'", comboBox1.SelectedItem);
                Seged.Tortenet(Login.Username,$"Keserés ({comboBox1.SelectedItem}) kategoriára ");
            }
            else
            {
                Datagrid_Toltes();
            }
            
        }

       
    }
}
