namespace SIMajorAssistance
{
    partial class Question4
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
            this.lblheader = new System.Windows.Forms.Label();
            this.lblketerangan = new System.Windows.Forms.Label();
            this.lblpagenumber = new System.Windows.Forms.Label();
            this.checkT = new System.Windows.Forms.CheckBox();
            this.checkA = new System.Windows.Forms.CheckBox();
            this.checkM = new System.Windows.Forms.CheckBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblheader.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblheader.Location = new System.Drawing.Point(16, 48);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(73, 24);
            this.lblheader.TabIndex = 1;
            this.lblheader.Text = "Header";
            // 
            // lblketerangan
            // 
            this.lblketerangan.AutoSize = true;
            this.lblketerangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblketerangan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblketerangan.Location = new System.Drawing.Point(16, 192);
            this.lblketerangan.Name = "lblketerangan";
            this.lblketerangan.Size = new System.Drawing.Size(538, 24);
            this.lblketerangan.TabIndex = 11;
            this.lblketerangan.Text = "Berdasarkan penjelasan di atas pilihlah bidang yang anda sukai";
            // 
            // lblpagenumber
            // 
            this.lblpagenumber.AutoSize = true;
            this.lblpagenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagenumber.ForeColor = System.Drawing.Color.Red;
            this.lblpagenumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblpagenumber.Location = new System.Drawing.Point(16, 16);
            this.lblpagenumber.Name = "lblpagenumber";
            this.lblpagenumber.Size = new System.Drawing.Size(107, 16);
            this.lblpagenumber.TabIndex = 33;
            this.lblpagenumber.Text = "Question Page 4";
            // 
            // checkT
            // 
            this.checkT.AutoSize = true;
            this.checkT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkT.Location = new System.Drawing.Point(24, 240);
            this.checkT.Name = "checkT";
            this.checkT.Size = new System.Drawing.Size(112, 28);
            this.checkT.TabIndex = 35;
            this.checkT.Text = "Technical";
            this.checkT.UseVisualStyleBackColor = true;
            // 
            // checkA
            // 
            this.checkA.AutoSize = true;
            this.checkA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkA.Location = new System.Drawing.Point(24, 280);
            this.checkA.Name = "checkA";
            this.checkA.Size = new System.Drawing.Size(108, 28);
            this.checkA.TabIndex = 36;
            this.checkA.Text = "Analytical";
            this.checkA.UseVisualStyleBackColor = true;
            // 
            // checkM
            // 
            this.checkM.AutoSize = true;
            this.checkM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkM.Location = new System.Drawing.Point(24, 320);
            this.checkM.Name = "checkM";
            this.checkM.Size = new System.Drawing.Size(122, 28);
            this.checkM.TabIndex = 37;
            this.checkM.Text = "Managerial";
            this.checkM.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            this.btnback.BackgroundImage = global::SIMajorAssistance.Properties.Resources.back;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnback.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnback.Location = new System.Drawing.Point(712, 400);
            this.btnback.Name = "btnback";
            this.btnback.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnback.Size = new System.Drawing.Size(50, 50);
            this.btnback.TabIndex = 34;
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackgroundImage = global::SIMajorAssistance.Properties.Resources.next;
            this.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnnext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnnext.Location = new System.Drawing.Point(776, 400);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(50, 50);
            this.btnnext.TabIndex = 8;
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
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
            // Question4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 480);
            this.Controls.Add(this.checkM);
            this.Controls.Add(this.checkA);
            this.Controls.Add(this.checkT);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblpagenumber);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.lblketerangan);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Question4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question1";
            this.Load += new System.EventHandler(this.Questionform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblketerangan;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lblpagenumber;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.CheckBox checkT;
        private System.Windows.Forms.CheckBox checkA;
        private System.Windows.Forms.CheckBox checkM;
    }
}