namespace SIMajorAssistance
{
    partial class CheckHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckHistory));
            this.parentlogobox = new System.Windows.Forms.PictureBox();
            this.dgvhistory = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parentlogobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).BeginInit();
            this.SuspendLayout();
            // 
            // parentlogobox
            // 
            this.parentlogobox.BackColor = System.Drawing.Color.White;
            this.parentlogobox.Image = global::SIMajorAssistance.Properties.Resources.Mfy__Programs_;
            resources.ApplyResources(this.parentlogobox, "parentlogobox");
            this.parentlogobox.Name = "parentlogobox";
            this.parentlogobox.TabStop = false;
            // 
            // dgvhistory
            // 
            this.dgvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvhistory, "dgvhistory");
            this.dgvhistory.Name = "dgvhistory";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.BackgroundImage = global::SIMajorAssistance.Properties.Resources.close;
            resources.ApplyResources(this.btnclose, "btnclose");
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.Name = "btnclose";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txbpassword
            // 
            resources.ApplyResources(this.txbpassword, "txbpassword");
            this.txbpassword.Name = "txbpassword";
            // 
            // btnsubmit
            // 
            resources.ApplyResources(this.btnsubmit, "btnsubmit");
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblpassword
            // 
            resources.ApplyResources(this.lblpassword, "lblpassword");
            this.lblpassword.Name = "lblpassword";
            // 
            // CheckHistory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dgvhistory);
            this.Controls.Add(this.parentlogobox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckHistory";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentlogobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox parentlogobox;
        private System.Windows.Forms.DataGridView dgvhistory;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblpassword;
    }
}

