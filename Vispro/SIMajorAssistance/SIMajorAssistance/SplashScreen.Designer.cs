namespace SIMajorAssistance
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.parentlogobox = new System.Windows.Forms.PictureBox();
            this.picboxlogo = new System.Windows.Forms.PictureBox();
            this.lblcopy = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.onlytimer = new System.Windows.Forms.Timer(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parentlogobox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // parentlogobox
            // 
            this.parentlogobox.BackColor = System.Drawing.Color.White;
            this.parentlogobox.Image = global::SIMajorAssistance.Properties.Resources.Mfy__Programs_;
            resources.ApplyResources(this.parentlogobox, "parentlogobox");
            this.parentlogobox.Name = "parentlogobox";
            this.parentlogobox.TabStop = false;
            // 
            // picboxlogo
            // 
            this.picboxlogo.BackColor = System.Drawing.Color.White;
            this.picboxlogo.Image = global::SIMajorAssistance.Properties.Resources.Mafuyu_Solution;
            resources.ApplyResources(this.picboxlogo, "picboxlogo");
            this.picboxlogo.Name = "picboxlogo";
            this.picboxlogo.TabStop = false;
            // 
            // lblcopy
            // 
            resources.ApplyResources(this.lblcopy, "lblcopy");
            this.lblcopy.Name = "lblcopy";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // onlytimer
            // 
            this.onlytimer.Tick += new System.EventHandler(this.onlytimer_Tick);
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // SplashScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblcopy);
            this.Controls.Add(this.parentlogobox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.picboxlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentlogobox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxlogo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox parentlogobox;
        private System.Windows.Forms.Label lblcopy;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer onlytimer;
        private System.Windows.Forms.Label lbl2;
    }
}

