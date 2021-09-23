
namespace Raktár_v._2
{
    partial class Beszallitok
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
            this.btn_felvesz = new System.Windows.Forms.Button();
            this.tx_telefonszam = new System.Windows.Forms.TextBox();
            this.tx_cim = new System.Windows.Forms.TextBox();
            this.tx_irszam = new System.Windows.Forms.TextBox();
            this.tx_orszag = new System.Windows.Forms.TextBox();
            this.tx_cnev = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_orszakeres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_keres = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tx_varos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(590, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beszállítók Kezelése";
            // 
            // btn_felvesz
            // 
            this.btn_felvesz.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_felvesz.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_felvesz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_felvesz.Location = new System.Drawing.Point(16, 432);
            this.btn_felvesz.Name = "btn_felvesz";
            this.btn_felvesz.Size = new System.Drawing.Size(140, 51);
            this.btn_felvesz.TabIndex = 36;
            this.btn_felvesz.Text = "Felvétel";
            this.btn_felvesz.UseVisualStyleBackColor = false;
            this.btn_felvesz.Click += new System.EventHandler(this.btn_felvesz_Click);
            // 
            // tx_telefonszam
            // 
            this.tx_telefonszam.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_telefonszam.Location = new System.Drawing.Point(179, 381);
            this.tx_telefonszam.Name = "tx_telefonszam";
            this.tx_telefonszam.Size = new System.Drawing.Size(173, 29);
            this.tx_telefonszam.TabIndex = 35;
            // 
            // tx_cim
            // 
            this.tx_cim.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_cim.Location = new System.Drawing.Point(179, 311);
            this.tx_cim.Name = "tx_cim";
            this.tx_cim.Size = new System.Drawing.Size(173, 29);
            this.tx_cim.TabIndex = 34;
            // 
            // tx_irszam
            // 
            this.tx_irszam.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_irszam.Location = new System.Drawing.Point(179, 248);
            this.tx_irszam.Name = "tx_irszam";
            this.tx_irszam.Size = new System.Drawing.Size(173, 29);
            this.tx_irszam.TabIndex = 33;
            // 
            // tx_orszag
            // 
            this.tx_orszag.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_orszag.Location = new System.Drawing.Point(179, 135);
            this.tx_orszag.Name = "tx_orszag";
            this.tx_orszag.Size = new System.Drawing.Size(173, 29);
            this.tx_orszag.TabIndex = 32;
            // 
            // tx_cnev
            // 
            this.tx_cnev.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_cnev.Location = new System.Drawing.Point(179, 70);
            this.tx_cnev.Name = "tx_cnev";
            this.tx_cnev.Size = new System.Drawing.Size(173, 29);
            this.tx_cnev.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(11, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ország:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(4, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 28);
            this.label7.TabIndex = 29;
            this.label7.Text = "Irányítószám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "Cím:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(4, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefonszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cég Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(1032, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ország:";
            // 
            // tx_orszakeres
            // 
            this.tx_orszakeres.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_orszakeres.Location = new System.Drawing.Point(1146, 102);
            this.tx_orszakeres.Name = "tx_orszakeres";
            this.tx_orszakeres.Size = new System.Drawing.Size(156, 29);
            this.tx_orszakeres.TabIndex = 24;
            this.tx_orszakeres.TextChanged += new System.EventHandler(this.tx_orszakeres_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(612, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cég Név:";
            // 
            // tx_keres
            // 
            this.tx_keres.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_keres.Location = new System.Drawing.Point(767, 101);
            this.tx_keres.Name = "tx_keres";
            this.tx_keres.Size = new System.Drawing.Size(156, 29);
            this.tx_keres.TabIndex = 22;
            this.tx_keres.TextChanged += new System.EventHandler(this.tx_keres_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 425);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(212, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 51);
            this.button1.TabIndex = 37;
            this.button1.Text = "Szerkeszt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_varos
            // 
            this.tx_varos.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_varos.Location = new System.Drawing.Point(179, 192);
            this.tx_varos.Name = "tx_varos";
            this.tx_varos.Size = new System.Drawing.Size(173, 29);
            this.tx_varos.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(11, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.TabIndex = 38;
            this.label9.Text = "Város:";
            // 
            // Beszallitok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 657);
            this.Controls.Add(this.tx_varos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_felvesz);
            this.Controls.Add(this.tx_telefonszam);
            this.Controls.Add(this.tx_cim);
            this.Controls.Add(this.tx_irszam);
            this.Controls.Add(this.tx_orszag);
            this.Controls.Add(this.tx_cnev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_orszakeres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_keres);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Beszallitok";
            this.Text = "Beszallitok";
            this.Load += new System.EventHandler(this.Beszallitok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_felvesz;
        private System.Windows.Forms.TextBox tx_telefonszam;
        private System.Windows.Forms.TextBox tx_cim;
        private System.Windows.Forms.TextBox tx_irszam;
        private System.Windows.Forms.TextBox tx_orszag;
        private System.Windows.Forms.TextBox tx_cnev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_orszakeres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_keres;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_varos;
        private System.Windows.Forms.Label label9;
    }
}