
namespace Raktár_v._2
{
    partial class VevoKeres
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_orszagkeres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_keres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_tnev = new System.Windows.Forms.TextBox();
            this.tx_orszag = new System.Windows.Forms.TextBox();
            this.tx_irszam = new System.Windows.Forms.TextBox();
            this.tx_cim = new System.Windows.Forms.TextBox();
            this.tx_telefonszam = new System.Windows.Forms.TextBox();
            this.btn_felvesz = new System.Windows.Forms.Button();
            this.btn_bezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vevő Keresés/Felvétel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 425);
            this.dataGridView1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1011, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ország:";
            // 
            // tx_orszagkeres
            // 
            this.tx_orszagkeres.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_orszagkeres.Location = new System.Drawing.Point(1147, 116);
            this.tx_orszagkeres.Name = "tx_orszagkeres";
            this.tx_orszagkeres.Size = new System.Drawing.Size(156, 29);
            this.tx_orszagkeres.TabIndex = 8;
            this.tx_orszagkeres.Click += new System.EventHandler(this.tx_orszagkeres_Click);
            this.tx_orszagkeres.TextChanged += new System.EventHandler(this.tx_orszagkeres_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(613, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vevőnév:";
            // 
            // tx_keres
            // 
            this.tx_keres.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_keres.Location = new System.Drawing.Point(768, 115);
            this.tx_keres.Name = "tx_keres";
            this.tx_keres.Size = new System.Drawing.Size(156, 29);
            this.tx_keres.TabIndex = 6;
            this.tx_keres.Click += new System.EventHandler(this.tx_keres_Click);
            this.tx_keres.TextChanged += new System.EventHandler(this.tx_keres_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teljes Név:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefonszám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cím:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Irányítószám:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ország:";
            // 
            // tx_tnev
            // 
            this.tx_tnev.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_tnev.Location = new System.Drawing.Point(180, 84);
            this.tx_tnev.Name = "tx_tnev";
            this.tx_tnev.Size = new System.Drawing.Size(173, 29);
            this.tx_tnev.TabIndex = 15;
            // 
            // tx_orszag
            // 
            this.tx_orszag.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_orszag.Location = new System.Drawing.Point(180, 158);
            this.tx_orszag.Name = "tx_orszag";
            this.tx_orszag.Size = new System.Drawing.Size(173, 29);
            this.tx_orszag.TabIndex = 16;
            // 
            // tx_irszam
            // 
            this.tx_irszam.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_irszam.Location = new System.Drawing.Point(180, 227);
            this.tx_irszam.Name = "tx_irszam";
            this.tx_irszam.Size = new System.Drawing.Size(173, 29);
            this.tx_irszam.TabIndex = 17;
            // 
            // tx_cim
            // 
            this.tx_cim.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_cim.Location = new System.Drawing.Point(180, 299);
            this.tx_cim.Name = "tx_cim";
            this.tx_cim.Size = new System.Drawing.Size(173, 29);
            this.tx_cim.TabIndex = 18;
            // 
            // tx_telefonszam
            // 
            this.tx_telefonszam.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_telefonszam.Location = new System.Drawing.Point(180, 369);
            this.tx_telefonszam.Name = "tx_telefonszam";
            this.tx_telefonszam.Size = new System.Drawing.Size(173, 29);
            this.tx_telefonszam.TabIndex = 19;
            // 
            // btn_felvesz
            // 
            this.btn_felvesz.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_felvesz.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_felvesz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_felvesz.Location = new System.Drawing.Point(124, 445);
            this.btn_felvesz.Name = "btn_felvesz";
            this.btn_felvesz.Size = new System.Drawing.Size(140, 51);
            this.btn_felvesz.TabIndex = 20;
            this.btn_felvesz.Text = "Felvétel";
            this.btn_felvesz.UseVisualStyleBackColor = false;
            this.btn_felvesz.Click += new System.EventHandler(this.btn_felvesz_Click);
            // 
            // btn_bezar
            // 
            this.btn_bezar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_bezar.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_bezar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_bezar.Location = new System.Drawing.Point(17, 576);
            this.btn_bezar.Name = "btn_bezar";
            this.btn_bezar.Size = new System.Drawing.Size(140, 51);
            this.btn_bezar.TabIndex = 21;
            this.btn_bezar.Text = "Bezárás";
            this.btn_bezar.UseVisualStyleBackColor = false;
            this.btn_bezar.Click += new System.EventHandler(this.btn_bezar_Click);
            // 
            // VevoKeres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 652);
            this.Controls.Add(this.btn_bezar);
            this.Controls.Add(this.btn_felvesz);
            this.Controls.Add(this.tx_telefonszam);
            this.Controls.Add(this.tx_cim);
            this.Controls.Add(this.tx_irszam);
            this.Controls.Add(this.tx_orszag);
            this.Controls.Add(this.tx_tnev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_orszagkeres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_keres);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VevoKeres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VevoKeres";
            this.Load += new System.EventHandler(this.VevoKeres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_orszagkeres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_keres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_tnev;
        private System.Windows.Forms.TextBox tx_orszag;
        private System.Windows.Forms.TextBox tx_irszam;
        private System.Windows.Forms.TextBox tx_cim;
        private System.Windows.Forms.TextBox tx_telefonszam;
        private System.Windows.Forms.Button btn_felvesz;
        private System.Windows.Forms.Button btn_bezar;
    }
}