
namespace Raktár_v._2
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_username = new System.Windows.Forms.TextBox();
            this.tx_pass = new System.Windows.Forms.TextBox();
            this.btn_belep = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(120, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(120, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jelszó:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 47);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bejelentkezés";
            // 
            // tx_username
            // 
            this.tx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_username.Location = new System.Drawing.Point(116, 120);
            this.tx_username.Name = "tx_username";
            this.tx_username.Size = new System.Drawing.Size(261, 27);
            this.tx_username.TabIndex = 8;
            this.tx_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_username_KeyDown);
            // 
            // tx_pass
            // 
            this.tx_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tx_pass.Location = new System.Drawing.Point(116, 231);
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.Size = new System.Drawing.Size(261, 27);
            this.tx_pass.TabIndex = 9;
            this.tx_pass.UseSystemPasswordChar = true;
            this.tx_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_pass_KeyDown);
            // 
            // btn_belep
            // 
            this.btn_belep.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_belep.Location = new System.Drawing.Point(175, 289);
            this.btn_belep.Name = "btn_belep";
            this.btn_belep.Size = new System.Drawing.Size(121, 37);
            this.btn_belep.TabIndex = 10;
            this.btn_belep.Text = "Belépés";
            this.btn_belep.UseVisualStyleBackColor = true;
            this.btn_belep.Click += new System.EventHandler(this.btn_belep_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_reg.Location = new System.Drawing.Point(281, 343);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(156, 46);
            this.btn_reg.TabIndex = 11;
            this.btn_reg.Text = "Regisztráció";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilep.Location = new System.Drawing.Point(21, 343);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(156, 46);
            this.btn_kilep.TabIndex = 12;
            this.btn_kilep.Text = "Bezárás";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.btn_kilep_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 405);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_belep);
            this.Controls.Add(this.tx_pass);
            this.Controls.Add(this.tx_username);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_username;
        private System.Windows.Forms.TextBox tx_pass;
        private System.Windows.Forms.Button btn_belep;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Button btn_kilep;
    }
}