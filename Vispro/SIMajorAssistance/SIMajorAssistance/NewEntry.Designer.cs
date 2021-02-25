namespace SIMajorAssistance
{
    partial class NewEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEntry));
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lbltextnama = new System.Windows.Forms.Label();
            this.txbnama = new System.Windows.Forms.TextBox();
            this.lbltextnim = new System.Windows.Forms.Label();
            this.txbnim = new System.Windows.Forms.TextBox();
            this.txbangkatan = new System.Windows.Forms.TextBox();
            this.lbltextangkatan = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.parentlogobox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentlogobox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            resources.ApplyResources(this.btnsubmit, "btnsubmit");
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lbltextnama
            // 
            resources.ApplyResources(this.lbltextnama, "lbltextnama");
            this.lbltextnama.Name = "lbltextnama";
            // 
            // txbnama
            // 
            resources.ApplyResources(this.txbnama, "txbnama");
            this.txbnama.Name = "txbnama";
            // 
            // lbltextnim
            // 
            resources.ApplyResources(this.lbltextnim, "lbltextnim");
            this.lbltextnim.Name = "lbltextnim";
            // 
            // txbnim
            // 
            resources.ApplyResources(this.txbnim, "txbnim");
            this.txbnim.Name = "txbnim";
            // 
            // txbangkatan
            // 
            resources.ApplyResources(this.txbangkatan, "txbangkatan");
            this.txbangkatan.Name = "txbangkatan";
            // 
            // lbltextangkatan
            // 
            resources.ApplyResources(this.lbltextangkatan, "lbltextangkatan");
            this.lbltextangkatan.Name = "lbltextangkatan";
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
            // picboxlogo
            // 
            this.picboxlogo.Image = global::SIMajorAssistance.Properties.Resources.Mafuyu_Solution;
            resources.ApplyResources(this.picboxlogo, "picboxlogo");
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.TabStop = false;
            this.picboxlogo.Click += new System.EventHandler(this.picboxlogo_Click);
            // 
            // parentlogobox
            // 
            this.parentlogobox.BackColor = System.Drawing.Color.White;
            this.parentlogobox.Image = global::SIMajorAssistance.Properties.Resources.Mfy__Programs_;
            resources.ApplyResources(this.parentlogobox, "parentlogobox");
            this.parentlogobox.Name = "parentlogobox";
            this.parentlogobox.TabStop = false;
            // 
            // NewEntry
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.parentlogobox);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.picboxlogo);
            this.Controls.Add(this.txbangkatan);
            this.Controls.Add(this.lbltextangkatan);
            this.Controls.Add(this.txbnim);
            this.Controls.Add(this.lbltextnim);
            this.Controls.Add(this.txbnama);
            this.Controls.Add(this.lbltextnama);
            this.Controls.Add(this.btnsubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewEntry";
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentlogobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lbltextnama;
        private System.Windows.Forms.TextBox txbnama;
        private System.Windows.Forms.Label lbltextnim;
        private System.Windows.Forms.TextBox txbnim;
        private System.Windows.Forms.TextBox txbangkatan;
        private System.Windows.Forms.Label lbltextangkatan;
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.PictureBox parentlogobox;
    }
}

