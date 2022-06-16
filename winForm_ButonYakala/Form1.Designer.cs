namespace winForm_ButonYakala
{
    partial class Form1
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
            this.btnTuruncu = new System.Windows.Forms.Button();
            this.btnYukari = new System.Windows.Forms.Button();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTuruncu
            // 
            this.btnTuruncu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnTuruncu.Location = new System.Drawing.Point(248, 193);
            this.btnTuruncu.Name = "btnTuruncu";
            this.btnTuruncu.Size = new System.Drawing.Size(75, 23);
            this.btnTuruncu.TabIndex = 0;
            this.btnTuruncu.UseVisualStyleBackColor = false;
            // 
            // btnYukari
            // 
            this.btnYukari.Location = new System.Drawing.Point(650, 29);
            this.btnYukari.Name = "btnYukari";
            this.btnYukari.Size = new System.Drawing.Size(60, 30);
            this.btnYukari.TabIndex = 1;
            this.btnYukari.Text = "Up";
            this.btnYukari.UseVisualStyleBackColor = true;
            this.btnYukari.Click += new System.EventHandler(this.btnYukari_Click);
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(714, 64);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(60, 30);
            this.btnSag.TabIndex = 2;
            this.btnSag.Text = "Right";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(586, 64);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(60, 30);
            this.btnSol.TabIndex = 3;
            this.btnSol.Text = "Left";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(650, 102);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(60, 30);
            this.btnAsagi.TabIndex = 4;
            this.btnAsagi.Text = "Down";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.btnAsagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(809, 452);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnYukari);
            this.Controls.Add(this.btnTuruncu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTuruncu;
        private System.Windows.Forms.Button btnYukari;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnAsagi;
    }
}

