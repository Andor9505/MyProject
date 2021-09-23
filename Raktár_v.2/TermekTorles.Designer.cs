
namespace Raktár_v._2
{
    partial class TermekTorles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pic_termek = new System.Windows.Forms.PictureBox();
            this.pic_qr = new System.Windows.Forms.PictureBox();
            this.tx_termeknev = new System.Windows.Forms.TextBox();
            this.tx_katnev = new System.Windows.Forms.TextBox();
            this.tx_ar = new System.Windows.Forms.TextBox();
            this.tx_keszlet = new System.Windows.Forms.TextBox();
            this.tx_cikkszam = new System.Windows.Forms.TextBox();
            this.tx_besznev = new System.Windows.Forms.TextBox();
            this.tx_tnkeres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_cikkkeres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_szerkeszt = new System.Windows.Forms.Button();
            this.btn_torol = new System.Windows.Forms.Button();
            this.btn_kepmegnyit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_termek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(404, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termek Törlése/Szerkesztése";
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowUserToAddRows = false;
            this.dataGrid1.AllowUserToDeleteRows = false;
            this.dataGrid1.AllowUserToResizeColumns = false;
            this.dataGrid1.AllowUserToResizeRows = false;
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGrid1.Location = new System.Drawing.Point(409, 117);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.Size = new System.Drawing.Size(998, 482);
            this.dataGrid1.TabIndex = 1;
            this.dataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terméknév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Beszállítónév:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategórianév:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ár:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Készlet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cikkszám:";
            // 
            // pic_termek
            // 
            this.pic_termek.Location = new System.Drawing.Point(16, 441);
            this.pic_termek.Name = "pic_termek";
            this.pic_termek.Size = new System.Drawing.Size(175, 171);
            this.pic_termek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_termek.TabIndex = 8;
            this.pic_termek.TabStop = false;
            // 
            // pic_qr
            // 
            this.pic_qr.Location = new System.Drawing.Point(214, 441);
            this.pic_qr.Name = "pic_qr";
            this.pic_qr.Size = new System.Drawing.Size(175, 171);
            this.pic_qr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_qr.TabIndex = 9;
            this.pic_qr.TabStop = false;
            // 
            // tx_termeknev
            // 
            this.tx_termeknev.Enabled = false;
            this.tx_termeknev.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_termeknev.Location = new System.Drawing.Point(157, 21);
            this.tx_termeknev.Name = "tx_termeknev";
            this.tx_termeknev.Size = new System.Drawing.Size(125, 26);
            this.tx_termeknev.TabIndex = 10;
            // 
            // tx_katnev
            // 
            this.tx_katnev.Enabled = false;
            this.tx_katnev.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_katnev.Location = new System.Drawing.Point(157, 217);
            this.tx_katnev.Name = "tx_katnev";
            this.tx_katnev.Size = new System.Drawing.Size(125, 26);
            this.tx_katnev.TabIndex = 11;
            // 
            // tx_ar
            // 
            this.tx_ar.Enabled = false;
            this.tx_ar.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_ar.Location = new System.Drawing.Point(157, 171);
            this.tx_ar.Name = "tx_ar";
            this.tx_ar.Size = new System.Drawing.Size(125, 26);
            this.tx_ar.TabIndex = 12;
            // 
            // tx_keszlet
            // 
            this.tx_keszlet.Enabled = false;
            this.tx_keszlet.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_keszlet.Location = new System.Drawing.Point(157, 117);
            this.tx_keszlet.Name = "tx_keszlet";
            this.tx_keszlet.Size = new System.Drawing.Size(125, 26);
            this.tx_keszlet.TabIndex = 13;
            // 
            // tx_cikkszam
            // 
            this.tx_cikkszam.Enabled = false;
            this.tx_cikkszam.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_cikkszam.Location = new System.Drawing.Point(157, 68);
            this.tx_cikkszam.Name = "tx_cikkszam";
            this.tx_cikkszam.Size = new System.Drawing.Size(125, 26);
            this.tx_cikkszam.TabIndex = 14;
            this.tx_cikkszam.TextChanged += new System.EventHandler(this.tx_cikkszam_TextChanged);
            // 
            // tx_besznev
            // 
            this.tx_besznev.Enabled = false;
            this.tx_besznev.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_besznev.Location = new System.Drawing.Point(157, 285);
            this.tx_besznev.Name = "tx_besznev";
            this.tx_besznev.Size = new System.Drawing.Size(125, 26);
            this.tx_besznev.TabIndex = 15;
            // 
            // tx_tnkeres
            // 
            this.tx_tnkeres.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_tnkeres.Location = new System.Drawing.Point(715, 77);
            this.tx_tnkeres.Name = "tx_tnkeres";
            this.tx_tnkeres.Size = new System.Drawing.Size(189, 26);
            this.tx_tnkeres.TabIndex = 17;
            this.tx_tnkeres.Click += new System.EventHandler(this.tx_tnkeres_Click);
            this.tx_tnkeres.TextChanged += new System.EventHandler(this.tx_tnkeres_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(566, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Terméknév:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(985, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cikkszám:";
            // 
            // tx_cikkkeres
            // 
            this.tx_cikkkeres.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_cikkkeres.Location = new System.Drawing.Point(1112, 77);
            this.tx_cikkkeres.Name = "tx_cikkkeres";
            this.tx_cikkkeres.Size = new System.Drawing.Size(189, 26);
            this.tx_cikkkeres.TabIndex = 19;
            this.tx_cikkkeres.Click += new System.EventHandler(this.tx_cikkkeres_Click);
            this.tx_cikkkeres.TextChanged += new System.EventHandler(this.tx_cikkkeres_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(946, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 29);
            this.label10.TabIndex = 20;
            this.label10.Text = "Keresés";
            // 
            // btn_szerkeszt
            // 
            this.btn_szerkeszt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_szerkeszt.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_szerkeszt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_szerkeszt.Location = new System.Drawing.Point(113, 327);
            this.btn_szerkeszt.Name = "btn_szerkeszt";
            this.btn_szerkeszt.Size = new System.Drawing.Size(120, 42);
            this.btn_szerkeszt.TabIndex = 21;
            this.btn_szerkeszt.Text = "Szerkeszt";
            this.btn_szerkeszt.UseVisualStyleBackColor = false;
            this.btn_szerkeszt.Click += new System.EventHandler(this.btn_szerkeszt_Click);
            // 
            // btn_torol
            // 
            this.btn_torol.BackColor = System.Drawing.Color.Crimson;
            this.btn_torol.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_torol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_torol.Location = new System.Drawing.Point(283, 327);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(106, 42);
            this.btn_torol.TabIndex = 22;
            this.btn_torol.Text = "Töröl";
            this.btn_torol.UseVisualStyleBackColor = false;
            this.btn_torol.Click += new System.EventHandler(this.btn_torol_Click);
            // 
            // btn_kepmegnyit
            // 
            this.btn_kepmegnyit.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kepmegnyit.Location = new System.Drawing.Point(16, 376);
            this.btn_kepmegnyit.Name = "btn_kepmegnyit";
            this.btn_kepmegnyit.Size = new System.Drawing.Size(141, 42);
            this.btn_kepmegnyit.TabIndex = 23;
            this.btn_kepmegnyit.Text = "Megnyitás";
            this.btn_kepmegnyit.UseVisualStyleBackColor = true;
            this.btn_kepmegnyit.Click += new System.EventHandler(this.btn_kepmegnyit_Click);
            // 
            // TermekTorles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 655);
            this.Controls.Add(this.btn_kepmegnyit);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.btn_szerkeszt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tx_cikkkeres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tx_tnkeres);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tx_besznev);
            this.Controls.Add(this.tx_cikkszam);
            this.Controls.Add(this.tx_keszlet);
            this.Controls.Add(this.tx_ar);
            this.Controls.Add(this.tx_katnev);
            this.Controls.Add(this.tx_termeknev);
            this.Controls.Add(this.pic_qr);
            this.Controls.Add(this.pic_termek);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.label1);
            this.Name = "TermekTorles";
            this.Text = "TermekTorles";
            this.Load += new System.EventHandler(this.TermekTorles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_termek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pic_termek;
        private System.Windows.Forms.PictureBox pic_qr;
        private System.Windows.Forms.TextBox tx_termeknev;
        private System.Windows.Forms.TextBox tx_katnev;
        private System.Windows.Forms.TextBox tx_ar;
        private System.Windows.Forms.TextBox tx_keszlet;
        private System.Windows.Forms.TextBox tx_cikkszam;
        private System.Windows.Forms.TextBox tx_besznev;
        private System.Windows.Forms.TextBox tx_tnkeres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_cikkkeres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_szerkeszt;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.Button btn_kepmegnyit;
        private System.Windows.Forms.Timer timer1;
    }
}