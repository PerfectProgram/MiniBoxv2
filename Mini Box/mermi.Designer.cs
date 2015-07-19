namespace Mini_Box
{
    partial class mermi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mermi));
            this.mermiresim = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.patlamaresim = new System.Windows.Forms.ImageList(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // mermiresim
            // 
            this.mermiresim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mermiresim.ImageStream")));
            this.mermiresim.TransparentColor = System.Drawing.Color.Transparent;
            this.mermiresim.Images.SetKeyName(0, "mermisag1.png");
            this.mermiresim.Images.SetKeyName(1, "mermisag2.png");
            this.mermiresim.Images.SetKeyName(2, "mermisag3.png");
            this.mermiresim.Images.SetKeyName(3, "mermisag4.png");
            this.mermiresim.Images.SetKeyName(4, "mermisag5.png");
            this.mermiresim.Images.SetKeyName(5, "mermisag6.png");
            this.mermiresim.Images.SetKeyName(6, "mermisol1.png");
            this.mermiresim.Images.SetKeyName(7, "mermisol2.png");
            this.mermiresim.Images.SetKeyName(8, "mermisol3.png");
            this.mermiresim.Images.SetKeyName(9, "mermisol4.png");
            this.mermiresim.Images.SetKeyName(10, "mermisol5.png");
            this.mermiresim.Images.SetKeyName(11, "mermisol6.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // patlamaresim
            // 
            this.patlamaresim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("patlamaresim.ImageStream")));
            this.patlamaresim.TransparentColor = System.Drawing.Color.Transparent;
            this.patlamaresim.Images.SetKeyName(0, "patlama.png");
            this.patlamaresim.Images.SetKeyName(1, "patlama2.png");
            this.patlamaresim.Images.SetKeyName(2, "patlama3.png");
            this.patlamaresim.Images.SetKeyName(3, "patlama4.png");
            this.patlamaresim.Images.SetKeyName(4, "patlama5.png");
            this.patlamaresim.Images.SetKeyName(5, "patlama6.png");
            this.patlamaresim.Images.SetKeyName(6, "patlama7.png");
            this.patlamaresim.Images.SetKeyName(7, "patlama8.png");
            this.patlamaresim.Images.SetKeyName(8, "patlama9.png");
            this.patlamaresim.Images.SetKeyName(9, "patlama10.png");
            this.patlamaresim.Images.SetKeyName(10, "patlama11.png");
            this.patlamaresim.Images.SetKeyName(11, "patlama12.png");
            this.patlamaresim.Images.SetKeyName(12, "patlama13.png");
            this.patlamaresim.Images.SetKeyName(13, "patlama14.png");
            this.patlamaresim.Images.SetKeyName(14, "patlama15.png");
            this.patlamaresim.Images.SetKeyName(15, "patlama16.png");
            this.patlamaresim.Images.SetKeyName(16, "patlama17.png");
            this.patlamaresim.Images.SetKeyName(17, "patlama18.png");
            this.patlamaresim.Images.SetKeyName(18, "patlama19.png");
            this.patlamaresim.Images.SetKeyName(19, "patlama20.png");
            this.patlamaresim.Images.SetKeyName(20, "patlama21.png");
            this.patlamaresim.Images.SetKeyName(21, "patlama22.png");
            this.patlamaresim.Images.SetKeyName(22, "patlama23.png");
            this.patlamaresim.Images.SetKeyName(23, "patlama24.png");
            this.patlamaresim.Images.SetKeyName(24, "patlama25.png");
            this.patlamaresim.Images.SetKeyName(25, "patlama26.png");
            this.patlamaresim.Images.SetKeyName(26, "patlama27.png");
            this.patlamaresim.Images.SetKeyName(27, "patlama28.png");
            this.patlamaresim.Images.SetKeyName(28, "patlama29.png");
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // mermi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(32, 32);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(16, 16);
            this.Name = "mermi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "mermi";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.mermi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList mermiresim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList patlamaresim;
        private System.Windows.Forms.Timer timer2;
    }
}