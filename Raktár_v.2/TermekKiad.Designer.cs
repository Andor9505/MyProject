
namespace Raktár_v._2
{
    partial class TermekKiad
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
            this.tx_termar = new System.Windows.Forms.TextBox();
            this.tx_keszleten = new System.Windows.Forms.TextBox();
            this.tx_termeknev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_kellmennyiseg = new System.Windows.Forms.TextBox();
            this.tx_arosszesen = new System.Windows.Forms.TextBox();
            this.tx_vevonev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datatermekgrid = new System.Windows.Forms.DataGridView();
            this.datavevogrid = new System.Windows.Forms.DataGridView();
            this.btn_kiad = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_frissit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datatermekgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datavevogrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(627, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termek Kiadás";
            // 
            // tx_termar
            // 
            this.tx_termar.Enabled = false;
            this.tx_termar.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_termar.Location = new System.Drawing.Point(193, 184);
            this.tx_termar.Name = "tx_termar";
            this.tx_termar.Size = new System.Drawing.Size(151, 26);
            this.tx_termar.TabIndex = 17;
            // 
            // tx_keszleten
            // 
            this.tx_keszleten.Enabled = false;
            this.tx_keszleten.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_keszleten.Location = new System.Drawing.Point(193, 240);
            this.tx_keszleten.Name = "tx_keszleten";
            this.tx_keszleten.Size = new System.Drawing.Size(151, 26);
            this.tx_keszleten.TabIndex = 16;
            // 
            // tx_termeknev
            // 
            this.tx_termeknev.Enabled = false;
            this.tx_termeknev.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_termeknev.Location = new System.Drawing.Point(193, 122);
            this.tx_termeknev.Name = "tx_termeknev";
            this.tx_termeknev.Size = new System.Drawing.Size(254, 26);
            this.tx_termeknev.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(59, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Készleten:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(51, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Termék ár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Terméknév:";
            // 
            // tx_kellmennyiseg
            // 
            this.tx_kellmennyiseg.Enabled = false;
            this.tx_kellmennyiseg.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_kellmennyiseg.Location = new System.Drawing.Point(1140, 185);
            this.tx_kellmennyiseg.Name = "tx_kellmennyiseg";
            this.tx_kellmennyiseg.Size = new System.Drawing.Size(151, 26);
            this.tx_kellmennyiseg.TabIndex = 23;
            this.tx_kellmennyiseg.TextChanged += new System.EventHandler(this.tx_kellmennyiseg_TextChanged);
            this.tx_kellmennyiseg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_kellmennyiseg_KeyPress);
            // 
            // tx_arosszesen
            // 
            this.tx_arosszesen.Enabled = false;
            this.tx_arosszesen.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_arosszesen.Location = new System.Drawing.Point(1140, 259);
            this.tx_arosszesen.Name = "tx_arosszesen";
            this.tx_arosszesen.Size = new System.Drawing.Size(151, 26);
            this.tx_arosszesen.TabIndex = 22;
            // 
            // tx_vevonev
            // 
            this.tx_vevonev.Enabled = false;
            this.tx_vevonev.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_vevonev.Location = new System.Drawing.Point(1140, 123);
            this.tx_vevonev.Name = "tx_vevonev";
            this.tx_vevonev.Size = new System.Drawing.Size(151, 26);
            this.tx_vevonev.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(989, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ár összesen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(998, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mennyiség:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(1001, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Vevő Neve:";
            // 
            // datatermekgrid
            // 
            this.datatermekgrid.AllowUserToAddRows = false;
            this.datatermekgrid.AllowUserToDeleteRows = false;
            this.datatermekgrid.AllowUserToResizeColumns = false;
            this.datatermekgrid.AllowUserToResizeRows = false;
            this.datatermekgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datatermekgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatermekgrid.Location = new System.Drawing.Point(12, 336);
            this.datatermekgrid.Name = "datatermekgrid";
            this.datatermekgrid.RowHeadersWidth = 51;
            this.datatermekgrid.RowTemplate.Height = 24;
            this.datatermekgrid.Size = new System.Drawing.Size(637, 194);
            this.datatermekgrid.TabIndex = 25;
            this.datatermekgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatermekgrid_CellClick);
            // 
            // datavevogrid
            // 
            this.datavevogrid.AllowUserToAddRows = false;
            this.datavevogrid.AllowUserToDeleteRows = false;
            this.datavevogrid.AllowUserToResizeColumns = false;
            this.datavevogrid.AllowUserToResizeRows = false;
            this.datavevogrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datavevogrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datavevogrid.Location = new System.Drawing.Point(757, 336);
            this.datavevogrid.Name = "datavevogrid";
            this.datavevogrid.RowHeadersWidth = 51;
            this.datavevogrid.RowTemplate.Height = 24;
            this.datavevogrid.Size = new System.Drawing.Size(651, 194);
            this.datavevogrid.TabIndex = 26;
            this.datavevogrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datavevogrid_CellClick);
            // 
            // btn_kiad
            // 
            this.btn_kiad.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_kiad.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kiad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kiad.Location = new System.Drawing.Point(633, 146);
            this.btn_kiad.Name = "btn_kiad";
            this.btn_kiad.Size = new System.Drawing.Size(145, 66);
            this.btn_kiad.TabIndex = 27;
            this.btn_kiad.Text = "Kiadás";
            this.btn_kiad.UseVisualStyleBackColor = false;
            this.btn_kiad.Click += new System.EventHandler(this.btn_kiad_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_error.Location = new System.Drawing.Point(1013, 224);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 24);
            this.lbl_error.TabIndex = 28;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(583, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 51);
            this.button1.TabIndex = 29;
            this.button1.Text = "Új vevő Felvétele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_frissit
            // 
            this.btn_frissit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_frissit.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_frissit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_frissit.Location = new System.Drawing.Point(1003, 550);
            this.btn_frissit.Name = "btn_frissit";
            this.btn_frissit.Size = new System.Drawing.Size(167, 47);
            this.btn_frissit.TabIndex = 30;
            this.btn_frissit.Text = "Frissítés";
            this.btn_frissit.UseVisualStyleBackColor = false;
            this.btn_frissit.Click += new System.EventHandler(this.btn_frissit_Click);
            // 
            // TermekKiad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 652);
            this.Controls.Add(this.btn_frissit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_kiad);
            this.Controls.Add(this.datavevogrid);
            this.Controls.Add(this.datatermekgrid);
            this.Controls.Add(this.tx_kellmennyiseg);
            this.Controls.Add(this.tx_arosszesen);
            this.Controls.Add(this.tx_vevonev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_termar);
            this.Controls.Add(this.tx_keszleten);
            this.Controls.Add(this.tx_termeknev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TermekKiad";
            this.Text = "TermekKiad";
            this.Load += new System.EventHandler(this.TermekKiad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatermekgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datavevogrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_termar;
        private System.Windows.Forms.TextBox tx_keszleten;
        private System.Windows.Forms.TextBox tx_termeknev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_kellmennyiseg;
        private System.Windows.Forms.TextBox tx_arosszesen;
        private System.Windows.Forms.TextBox tx_vevonev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datatermekgrid;
        private System.Windows.Forms.DataGridView datavevogrid;
        private System.Windows.Forms.Button btn_kiad;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_frissit;
    }
}