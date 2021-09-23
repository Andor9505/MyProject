
namespace Raktár_v._2
{
    partial class Loading
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cibar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 60);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(171, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rendszer betöltése";
            // 
            // cibar
            // 
            this.cibar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cibar.AnimationSpeed = 500;
            this.cibar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cibar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.cibar.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cibar.InnerColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cibar.InnerMargin = 2;
            this.cibar.InnerWidth = -1;
            this.cibar.Location = new System.Drawing.Point(196, 122);
            this.cibar.MarqueeAnimationSpeed = 2000;
            this.cibar.Name = "cibar";
            this.cibar.OuterColor = System.Drawing.Color.DimGray;
            this.cibar.OuterMargin = -25;
            this.cibar.OuterWidth = 26;
            this.cibar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.cibar.ProgressWidth = 15;
            this.cibar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cibar.Size = new System.Drawing.Size(128, 122);
            this.cibar.StartAngle = 270;
            this.cibar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cibar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cibar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cibar.SubscriptText = ".23";
            this.cibar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cibar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cibar.SuperscriptText = "°C";
            this.cibar.TabIndex = 5;
            this.cibar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cibar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 315);
            this.Controls.Add(this.cibar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar cibar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

