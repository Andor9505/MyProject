
namespace Raktár_v._2
{
    partial class TermekFel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.termekekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Raktár_v._2.Database1DataSet();
            this.termekekTableAdapter = new Raktár_v._2.Database1DataSetTableAdapters.termekekTableAdapter();
            this.pic_termek = new System.Windows.Forms.PictureBox();
            this.pic_qrcode = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combo_beszallito = new System.Windows.Forms.ComboBox();
            this.tx_termeknev = new System.Windows.Forms.TextBox();
            this.tx_keszlet = new System.Windows.Forms.TextBox();
            this.tx_cikkszam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_kepmegnyit = new System.Windows.Forms.Button();
            this.btn_felvesz = new System.Windows.Forms.Button();
            this.combo_kategoria = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_ar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_termek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(218, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 312);
            this.dataGridView1.TabIndex = 1;
            // 
            // termekekBindingSource
            // 
            this.termekekBindingSource.DataMember = "termekek";
            this.termekekBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // termekekTableAdapter
            // 
            this.termekekTableAdapter.ClearBeforeFill = true;
            // 
            // pic_termek
            // 
            this.pic_termek.Location = new System.Drawing.Point(758, 64);
            this.pic_termek.Name = "pic_termek";
            this.pic_termek.Size = new System.Drawing.Size(224, 166);
            this.pic_termek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_termek.TabIndex = 2;
            this.pic_termek.TabStop = false;
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.Location = new System.Drawing.Point(1181, 64);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(224, 166);
            this.pic_qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_qrcode.TabIndex = 3;
            this.pic_qrcode.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Terméknév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(0, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cikkszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Készlet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Beszállító:";
            // 
            // combo_beszallito
            // 
            this.combo_beszallito.DropDownHeight = 150;
            this.combo_beszallito.DropDownWidth = 4;
            this.combo_beszallito.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combo_beszallito.FormattingEnabled = true;
            this.combo_beszallito.IntegralHeight = false;
            this.combo_beszallito.Location = new System.Drawing.Point(142, 243);
            this.combo_beszallito.Name = "combo_beszallito";
            this.combo_beszallito.Size = new System.Drawing.Size(243, 32);
            this.combo_beszallito.TabIndex = 8;
            // 
            // tx_termeknev
            // 
            this.tx_termeknev.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_termeknev.Location = new System.Drawing.Point(142, 23);
            this.tx_termeknev.Name = "tx_termeknev";
            this.tx_termeknev.Size = new System.Drawing.Size(151, 26);
            this.tx_termeknev.TabIndex = 9;
            // 
            // tx_keszlet
            // 
            this.tx_keszlet.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_keszlet.Location = new System.Drawing.Point(142, 141);
            this.tx_keszlet.Name = "tx_keszlet";
            this.tx_keszlet.Size = new System.Drawing.Size(151, 26);
            this.tx_keszlet.TabIndex = 10;
            // 
            // tx_cikkszam
            // 
            this.tx_cikkszam.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_cikkszam.Location = new System.Drawing.Point(142, 85);
            this.tx_cikkszam.Name = "tx_cikkszam";
            this.tx_cikkszam.Size = new System.Drawing.Size(151, 26);
            this.tx_cikkszam.TabIndex = 11;
            this.tx_cikkszam.TextChanged += new System.EventHandler(this.tx_cikkszam_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(296, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generálás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_general_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(530, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kép Feltöltése";
            // 
            // btn_kepmegnyit
            // 
            this.btn_kepmegnyit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kepmegnyit.Location = new System.Drawing.Point(535, 115);
            this.btn_kepmegnyit.Name = "btn_kepmegnyit";
            this.btn_kepmegnyit.Size = new System.Drawing.Size(140, 44);
            this.btn_kepmegnyit.TabIndex = 14;
            this.btn_kepmegnyit.Text = "Megnyitás";
            this.btn_kepmegnyit.UseVisualStyleBackColor = true;
            this.btn_kepmegnyit.Click += new System.EventHandler(this.btn_kepmegnyit_Click);
            // 
            // btn_felvesz
            // 
            this.btn_felvesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_felvesz.Location = new System.Drawing.Point(666, 254);
            this.btn_felvesz.Name = "btn_felvesz";
            this.btn_felvesz.Size = new System.Drawing.Size(113, 44);
            this.btn_felvesz.TabIndex = 16;
            this.btn_felvesz.Text = "Felvétel";
            this.btn_felvesz.UseVisualStyleBackColor = true;
            this.btn_felvesz.Click += new System.EventHandler(this.btn_felvesz_Click);
            // 
            // combo_kategoria
            // 
            this.combo_kategoria.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.combo_kategoria.FormattingEnabled = true;
            this.combo_kategoria.Location = new System.Drawing.Point(142, 190);
            this.combo_kategoria.Name = "combo_kategoria";
            this.combo_kategoria.Size = new System.Drawing.Size(243, 32);
            this.combo_kategoria.TabIndex = 18;
           
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(3, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kategoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1054, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Qr Kód:";
            // 
            // tx_ar
            // 
            this.tx_ar.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_ar.Location = new System.Drawing.Point(376, 21);
            this.tx_ar.Name = "tx_ar";
            this.tx_ar.Size = new System.Drawing.Size(95, 26);
            this.tx_ar.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(333, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ár:";
            // 
            // TermekFel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 653);
            this.Controls.Add(this.tx_ar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_kategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_felvesz);
            this.Controls.Add(this.btn_kepmegnyit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tx_cikkszam);
            this.Controls.Add(this.tx_keszlet);
            this.Controls.Add(this.tx_termeknev);
            this.Controls.Add(this.combo_beszallito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_qrcode);
            this.Controls.Add(this.pic_termek);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TermekFel";
            this.Text = "TermekFel";
            this.Load += new System.EventHandler(this.TermekFel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termekekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_termek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource termekekBindingSource;
        private Database1DataSetTableAdapters.termekekTableAdapter termekekTableAdapter;
        private System.Windows.Forms.PictureBox pic_termek;
        private System.Windows.Forms.PictureBox pic_qrcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combo_beszallito;
        private System.Windows.Forms.TextBox tx_termeknev;
        private System.Windows.Forms.TextBox tx_keszlet;
        private System.Windows.Forms.TextBox tx_cikkszam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_kepmegnyit;
        private System.Windows.Forms.Button btn_felvesz;
        private System.Windows.Forms.ComboBox combo_kategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tx_ar;
        private System.Windows.Forms.Label label9;
    }
}