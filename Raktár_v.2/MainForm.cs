using System;
using System.Drawing;
using System.Windows.Forms;

namespace Raktár_v._2
{
    public partial class MainForm : Form
    {
        private bool mozgatas = false;
        Point indulo_pont = new Point(0,0);
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Oldal_Betoltes()
        {
            
            DateTime date = DateTime.Now;
            lbl_ido.Text = date.ToShortDateString();
            lbl_felhasz.Text = Login.Username;
            if (Login.Jog == "0")
            {
                lbl_jog.Text = "Raktáros";
                vevőkToolStripMenuItem.Visible = false;
                raktárTörténetToolStripMenuItem.Visible = false;
                beszállítókToolStripMenuItem.Visible = false;
                raktárTörténetToolStripMenuItem.Visible = false;
            }
            else
            {
                lbl_jog.Text = "Admin";
            }

            // Főpanelhez adás(Kezdő képernyő)

            T_kereses tker = new T_kereses();
            tker.TopLevel = false;
            tker.AutoScroll = true;
            tker.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tker.Dock = DockStyle.Fill;
            fopanel.Controls.Add(tker);
            tker.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            T_kereses tker = new T_kereses();
            tker.TopLevel = false;
            tker.AutoScroll = true;
            tker.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tker.Dock = DockStyle.Fill;
            fopanel.Controls.Add(tker);
            tker.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            
            Oldal_Betoltes();
        }

        private void felvételToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            TermekFel tfel = new TermekFel();
            tfel.TopLevel = false;
            tfel.AutoScroll = true;
            tfel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tfel.Dock = DockStyle.Fill;
            fopanel.Controls.Add(tfel);
            tfel.Show();
            
        }

       

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            TermekTorles ttorol = new TermekTorles();
            ttorol.TopLevel = false;
            ttorol.AutoScroll = true;
            ttorol.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ttorol.Dock = DockStyle.Fill;
            fopanel.Controls.Add(ttorol);
            ttorol.Show();
          
        }

        private void kiadásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            TermekKiad tkiad = new TermekKiad();
            tkiad.TopLevel = false;
            tkiad.AutoScroll = true;
            tkiad.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tkiad.Dock = DockStyle.Fill;
            fopanel.Controls.Add(tkiad);
            tkiad.Show();
          
        }

        private void keresésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            VevoKeres vevoKer = new VevoKeres();
            vevoKer.TopLevel = false;
            vevoKer.AutoScroll = true;
            vevoKer.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            vevoKer.Dock = DockStyle.Fill;
            fopanel.Controls.Add(vevoKer);
            vevoKer.Show();

           
        }

       

        private void törlésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            VevoTorol vtotol = new VevoTorol();
            vtotol.TopLevel = false;
            vtotol.AutoScroll = true;
            vtotol.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            vtotol.Dock = DockStyle.Fill;
            fopanel.Controls.Add(vtotol);
            vtotol.Show();
           
        }

        private void beszállítókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            Beszallitok besz = new Beszallitok();
            besz.TopLevel = false;
            besz.AutoScroll = true;
            besz.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            besz.Dock = DockStyle.Fill;
            fopanel.Controls.Add(besz);
            besz.Show();
          
        }

        private void raktárTörténetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            RaktarTort rakt = new RaktarTort();
            rakt.TopLevel = false;
            rakt.AutoScroll = true;
            rakt.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rakt.Dock = DockStyle.Fill;
            fopanel.Controls.Add(rakt);
            rakt.Show();
            
        }

        private void jegyzetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fopanel.Controls.Clear();
            Jegyzet besz = new Jegyzet();
            besz.TopLevel = false;
            besz.AutoScroll = true;
            besz.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            besz.Dock = DockStyle.Fill;
            fopanel.Controls.Add(besz);
            besz.Show();
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mozgatas = true;
            indulo_pont = new Point(e.X,e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mozgatas)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - indulo_pont.X, p.Y - indulo_pont.Y);
            }

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mozgatas = false;
        }
    }
}
