namespace Mini_Box
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cms_yuru = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çocukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruSorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ShowPopup = new System.Windows.Forms.NotifyIcon(this.components);
            this.cocuk = new DevExpress.Utils.ImageCollection(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.robot = new DevExpress.Utils.ImageCollection(this.components);
            this.kız = new DevExpress.Utils.ImageCollection(this.components);
            this.kızToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cocuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kız)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cms_yuru,
            this.değiştirToolStripMenuItem,
            this.soruSorToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 114);
            this.contextMenuStrip1.Text = "Masaüstü Faresi";
            // 
            // cms_yuru
            // 
            this.cms_yuru.CheckOnClick = true;
            this.cms_yuru.Image = ((System.Drawing.Image)(resources.GetObject("cms_yuru.Image")));
            this.cms_yuru.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cms_yuru.Name = "cms_yuru";
            this.cms_yuru.Size = new System.Drawing.Size(177, 22);
            this.cms_yuru.Text = "Masaüstümde Yürü";
            this.cms_yuru.CheckedChanged += new System.EventHandler(this.cms_yuru_CheckedChanged);
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robotToolStripMenuItem,
            this.çocukToolStripMenuItem,
            this.kızToolStripMenuItem});
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            // 
            // robotToolStripMenuItem
            // 
            this.robotToolStripMenuItem.CheckOnClick = true;
            this.robotToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("robotToolStripMenuItem.Image")));
            this.robotToolStripMenuItem.Name = "robotToolStripMenuItem";
            this.robotToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.robotToolStripMenuItem.Text = "Robot";
            this.robotToolStripMenuItem.CheckedChanged += new System.EventHandler(this.robotToolStripMenuItem_CheckedChanged);
            // 
            // çocukToolStripMenuItem
            // 
            this.çocukToolStripMenuItem.Checked = true;
            this.çocukToolStripMenuItem.CheckOnClick = true;
            this.çocukToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.çocukToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çocukToolStripMenuItem.Image")));
            this.çocukToolStripMenuItem.Name = "çocukToolStripMenuItem";
            this.çocukToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çocukToolStripMenuItem.Text = "Erkek";
            this.çocukToolStripMenuItem.CheckedChanged += new System.EventHandler(this.çocukToolStripMenuItem_CheckedChanged);
            // 
            // soruSorToolStripMenuItem
            // 
            this.soruSorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("soruSorToolStripMenuItem.Image")));
            this.soruSorToolStripMenuItem.Name = "soruSorToolStripMenuItem";
            this.soruSorToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.soruSorToolStripMenuItem.Text = "Soru sor...";
            this.soruSorToolStripMenuItem.Click += new System.EventHandler(this.soruSorToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 20;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // ShowPopup
            // 
            this.ShowPopup.ContextMenuStrip = this.contextMenuStrip1;
            this.ShowPopup.Icon = ((System.Drawing.Icon)(resources.GetObject("ShowPopup.Icon")));
            this.ShowPopup.Text = "Mini Box";
            // 
            // cocuk
            // 
            this.cocuk.ImageSize = new System.Drawing.Size(32, 32);
            this.cocuk.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("cocuk.ImageStream")));
            this.cocuk.Images.SetKeyName(0, "SagaDurus.png");
            this.cocuk.Images.SetKeyName(1, "SagYurume1.png");
            this.cocuk.Images.SetKeyName(2, "SagYurume2.png");
            this.cocuk.Images.SetKeyName(3, "SagYurume3.png");
            this.cocuk.Images.SetKeyName(4, "SagYurume4.png");
            this.cocuk.Images.SetKeyName(5, "SagYurume5.png");
            this.cocuk.Images.SetKeyName(6, "SagYurume6.png");
            this.cocuk.Images.SetKeyName(7, "SolaDurus.png");
            this.cocuk.Images.SetKeyName(8, "SolYurume1.png");
            this.cocuk.Images.SetKeyName(9, "SolYurume2.png");
            this.cocuk.Images.SetKeyName(10, "SolYurume3.png");
            this.cocuk.Images.SetKeyName(11, "SolYurume4.png");
            this.cocuk.Images.SetKeyName(12, "SolYurume5.png");
            this.cocuk.Images.SetKeyName(13, "SolYurume6.png");
            // 
            // timer4
            // 
            this.timer4.Interval = 200;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // robot
            // 
            this.robot.ImageSize = new System.Drawing.Size(32, 32);
            this.robot.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("robot.ImageStream")));
            this.robot.Images.SetKeyName(0, "sag.png");
            this.robot.Images.SetKeyName(1, "sag1.png");
            this.robot.Images.SetKeyName(2, "sag2.png");
            this.robot.Images.SetKeyName(3, "sag3.png");
            this.robot.Images.SetKeyName(4, "sag4.png");
            this.robot.Images.SetKeyName(5, "sag5.png");
            this.robot.Images.SetKeyName(6, "sag6.png");
            this.robot.Images.SetKeyName(7, "sag7.png");
            this.robot.Images.SetKeyName(8, "sag8.png");
            this.robot.Images.SetKeyName(9, "sag9.png");
            this.robot.Images.SetKeyName(10, "sag10.png");
            this.robot.Images.SetKeyName(11, "sag11.png");
            this.robot.Images.SetKeyName(12, "sag12.png");
            this.robot.Images.SetKeyName(13, "sag13.png");
            this.robot.Images.SetKeyName(14, "sol.png");
            this.robot.Images.SetKeyName(15, "sol1.png");
            this.robot.Images.SetKeyName(16, "sol2.png");
            this.robot.Images.SetKeyName(17, "sol3.png");
            this.robot.Images.SetKeyName(18, "sol4.png");
            this.robot.Images.SetKeyName(19, "sol5.png");
            this.robot.Images.SetKeyName(20, "sol6.png");
            this.robot.Images.SetKeyName(21, "sol7.png");
            this.robot.Images.SetKeyName(22, "sol8.png");
            this.robot.Images.SetKeyName(23, "sol9.png");
            this.robot.Images.SetKeyName(24, "sol10.png");
            this.robot.Images.SetKeyName(25, "sol11.png");
            this.robot.Images.SetKeyName(26, "sol12.png");
            this.robot.Images.SetKeyName(27, "sol13.png");
            // 
            // kız
            // 
            this.kız.ImageSize = new System.Drawing.Size(32, 32);
            this.kız.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("kız.ImageStream")));
            this.kız.Images.SetKeyName(0, "Sag1.png");
            this.kız.Images.SetKeyName(1, "Sag2.png");
            this.kız.Images.SetKeyName(2, "Sag3.png");
            this.kız.Images.SetKeyName(3, "Sag4.png");
            this.kız.Images.SetKeyName(4, "Sag5.png");
            this.kız.Images.SetKeyName(5, "Sag6.png");
            this.kız.Images.SetKeyName(6, "Sag7.png");
            this.kız.Images.SetKeyName(7, "Sag8.png");
            this.kız.Images.SetKeyName(8, "Sol1.png");
            this.kız.Images.SetKeyName(9, "Sol2.png");
            this.kız.Images.SetKeyName(10, "Sol3.png");
            this.kız.Images.SetKeyName(11, "Sol4.png");
            this.kız.Images.SetKeyName(12, "Sol5.png");
            this.kız.Images.SetKeyName(13, "Sol6.png");
            this.kız.Images.SetKeyName(14, "Sol7.png");
            this.kız.Images.SetKeyName(15, "Sol8.png");
            // 
            // kızToolStripMenuItem
            // 
            this.kızToolStripMenuItem.CheckOnClick = true;
            this.kızToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kızToolStripMenuItem.Image")));
            this.kızToolStripMenuItem.Name = "kızToolStripMenuItem";
            this.kızToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kızToolStripMenuItem.Text = "Kız";
            this.kızToolStripMenuItem.CheckedChanged += new System.EventHandler(this.kızToolStripMenuItem_CheckedChanged);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Appearance.BorderColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(32, 32);
            this.DoubleBuffered = true;
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(32, 32);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cocuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kız)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cms_yuru;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.NotifyIcon ShowPopup;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private DevExpress.Utils.ImageCollection cocuk;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ToolStripMenuItem soruSorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çocukToolStripMenuItem;
        private DevExpress.Utils.ImageCollection robot;
        private DevExpress.Utils.ImageCollection kız;
        private System.Windows.Forms.ToolStripMenuItem kızToolStripMenuItem;
    }
}