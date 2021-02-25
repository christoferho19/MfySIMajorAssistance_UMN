namespace SIMajorAssistance
{
    partial class TermsAgreement
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
            this.btnclose = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnsetuju = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.BackgroundImage = global::SIMajorAssistance.Properties.Resources.close;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnclose.Location = new System.Drawing.Point(792, 16);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(35, 35);
            this.btnclose.TabIndex = 10;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblheader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblheader.Location = new System.Drawing.Point(16, 16);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(73, 24);
            this.lblheader.TabIndex = 11;
            this.lblheader.Text = "Header";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblinfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblinfo.Location = new System.Drawing.Point(16, 80);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(82, 24);
            this.lblinfo.TabIndex = 12;
            this.lblinfo.Text = "Greeting";
            // 
            // btnsetuju
            // 
            this.btnsetuju.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnsetuju.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsetuju.Location = new System.Drawing.Point(520, 416);
            this.btnsetuju.Name = "btnsetuju";
            this.btnsetuju.Size = new System.Drawing.Size(96, 40);
            this.btnsetuju.TabIndex = 13;
            this.btnsetuju.Text = "Agree";
            this.btnsetuju.UseVisualStyleBackColor = true;
            this.btnsetuju.Click += new System.EventHandler(this.btnsetuju_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btncancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btncancel.Location = new System.Drawing.Point(216, 416);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(96, 40);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // TermsAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 480);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsetuju);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.btnclose);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TermsAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question1";
            this.Load += new System.EventHandler(this.Question1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnsetuju;
        private System.Windows.Forms.Button btncancel;
    }
}