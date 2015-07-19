﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mini_Box
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        string secim = "cocuk";
        Random r = new Random();
        int yon = 1, yuzey, sayac, sayac2 = 7;
        int width;
        int yondegistir, konusmadelay;
        public string dogrultu;
        bool tutuluyor;
        double ort;
        Point maus, form;
        int x, y, dusmehizi, firlatmax1, firlatmax2, firlatmay1, firlatmay2, firlatmahizix, firlatmahiziy, xdegeri, ydegeri;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        public static int GetTaskbarHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var screen = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
            var height = screen.Height;
            width = screen.Width;
            var taskbar = GetTaskbarHeight();
            yuzey = height - taskbar-32;
            timer1.Enabled = true;
            ShowPopup.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dusmehizi++;
            if (this.Location.Y >= yuzey)
            {
                this.Location = new Point(this.Location.X, yuzey);
                timer1.Enabled = false;
                y = 0;
                dusmehizi = 0;
            }
            else
            {
                x = this.Location.X;
                y = this.Location.Y + dusmehizi;
                this.Location = new Point(x, y);
            }
            if (this.Location.X > width)
            {
                this.Location = new Point(width - 21, this.Location.Y);
            }
            if (this.Location.X < 0)
            {
                this.Location = new Point(0, this.Location.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tutuluyor = true;
            maus = e.Location;
            firlatmax1 = this.Location.X;
            firlatmay1 = this.Location.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutuluyor)
            {
                /*Point dif = Point.Subtract(Cursor.Position, new Size(maus));
                this.Location = Point.Add(maus,new Size(dif));*/
                form = PointToScreen(e.Location);
                this.Location = new Point(form.X - maus.X, form.Y - maus.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            tutuluyor = false;
            firlatmax2= this.Location.X;
            firlatmay2 = this.Location.Y;
            Fırlat();

        }

        void Fırlat()
        {
            xdegeri = firlatmax2 - firlatmax1;
            ydegeri = firlatmay2 - firlatmay1;
            ort = (double)xdegeri / (double)ydegeri;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            firlatmahizix+=1;
            firlatmahiziy+=1;
            if (xdegeri == 0)
            {
                if (ydegeri == 0)
                {
                    timer2.Enabled = false;
                    timer1.Enabled = true;
                }
            }
            if (xdegeri < 0)
            {
                xdegeri = xdegeri + firlatmahizix;
                if (xdegeri > 0)
                {
                    xdegeri = 0;
                }
                this.Location = new Point(this.Location.X - firlatmahizix, this.Location.Y);
            }
            else if (xdegeri > 0)
            {
                xdegeri = xdegeri - firlatmahizix;
                if (xdegeri < 0)
                {
                    xdegeri = 0;
                }
                this.Location = new Point(this.Location.X + firlatmahizix, this.Location.Y);
            }
            if (ydegeri == 0)
            {
                if (xdegeri == 0)
                {
                    timer2.Enabled = false;
                    timer1.Enabled = true;
                }
            }
            if (ydegeri < 0)
            {
                ydegeri= ydegeri + firlatmahiziy;
                if (ydegeri > 0)
                {
                    ydegeri = 0;
                }
                this.Location = new Point(this.Location.X, this.Location.Y - firlatmahiziy);
            }
            else if (ydegeri > 0)
            {
                if (ydegeri < 0)
                {
                    ydegeri = 0;
                }
                ydegeri = ydegeri - firlatmahiziy;
                this.Location = new Point(this.Location.X, this.Location.Y + firlatmahiziy);
            }
            if (this.Location.X > width)
            {
                this.Location = new Point(width-21, this.Location.Y);
                yon = 3;
            }
            if (this.Location.X < 0)
            {
                this.Location = new Point(0, this.Location.Y);
                yon = 1;
            }
        }

        private void cms_yuru_CheckedChanged(object sender, EventArgs e)
        {
            if (cms_yuru.Checked)
            {
                if (secim == "cocuk")
                {
                    sayac = 0;
                    sayac2 = 7;
                }
                else if (secim == "robot")
                {
                    sayac = 0;
                    sayac2 = 14;
                }
                else
                {
                    sayac = 0;
                    sayac2 = 8;
                }
                timer3.Enabled = true;
            }
            else
            {
                timer3.Enabled = false;
                this.BackgroundImage = Image.FromFile(@"C:\Users\Medusa058\Desktop\man.png");
                cms_yuru.Checked = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Sağa duruş : 0 Sola Duruş : 7
            yondegistir++;
            konusmadelay++;
            if (yondegistir == 100)
            {

                Random r = new Random();
                yon = r.Next(0, 3);
                yondegistir = 0;
            }
            if (yon == 1)
            { 
                this.Location = new Point(this.Location.X + 1, this.Location.Y);
                dogrultu = "sag";
            }
            else if (yon == 2)
            {
                dogrultu = "dur";
            }
            else
            {
                
                this.Location = new Point(this.Location.X - 1, this.Location.Y);
                dogrultu = "sol";
            }
            if (this.Location.X > width)
            {
                this.Location = new Point(width - 21, this.Location.Y);
                yon = 3;
            }
            if (this.Location.X < 0)
            {
                this.Location = new Point(0, this.Location.Y);
                yon = 1;
            }
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //Sağ : 0 Sol : 7 Cocuk | Sağ :0 Sol : 14 Robot | Sağ : 0 Sol : 8 Kız
            if (secim == "cocuk")
            {
                var sondogrultu = dogrultu;
                if (sayac == 7)
                {
                    sayac = 0;
                }
                if (dogrultu == "sag")
                {
                    sayac2 = 7;
                    this.BackgroundImage = cocuk.Images[sayac];
                    sayac++;
                }
                if (sayac2 == 14)
                {
                    sayac2 = 7;
                }
                if (dogrultu == "sol")
                {
                    sayac = 0;
                    this.BackgroundImage = cocuk.Images[sayac2];
                    sayac2++;
                }
                if (dogrultu == "dur")
                {
                    if (sondogrultu == "sol")
                    {
                        this.BackgroundImage = cocuk.Images[7];
                    }
                    else
                    {
                        this.BackgroundImage = cocuk.Images[0];
                    }
                }
            }
            else if (secim == "robot")
            {
                var sondogrultu = dogrultu;
                if (sayac == 14)
                {
                    sayac = 0;
                }
                if (dogrultu == "sag")
                {
                    sayac2 = 14;
                    this.BackgroundImage = robot.Images[sayac];
                    sayac++;
                }
                if (sayac2 == 27)
                {
                    sayac2 = 14;
                }
                if (dogrultu == "sol")
                {
                    sayac = 0;
                    this.BackgroundImage = robot.Images[sayac2];
                    sayac2++;
                }
                if (dogrultu == "dur")
                {
                    if (sondogrultu == "sol")
                    {
                        this.BackgroundImage = robot.Images[7];
                    }
                    else
                    {
                        this.BackgroundImage = robot.Images[0];
                    }
                }
            }
            else
            {
                var sondogrultu = dogrultu;
                if (sayac == 8)
                {
                    sayac = 0;
                }
                if (dogrultu == "sag")
                {
                    sayac2 = 8;
                    this.BackgroundImage = kız.Images[sayac];
                    sayac++;
                }
                if (sayac2 == 16)
                {
                    sayac2 = 8;
                }
                if (dogrultu == "sol")
                {
                    sayac = 0;
                    this.BackgroundImage = kız.Images[sayac2];
                    sayac2++;
                }
                if (dogrultu == "dur")
                {
                    if (sondogrultu == "sol")
                    {
                        this.BackgroundImage = kız.Images[7];
                    }
                    else
                    {
                        this.BackgroundImage = kız.Images[0];
                    }
                }
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void soruSorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoru soru = new FormSoru();
            soru.Show();
        }

        private void robotToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (robotToolStripMenuItem.Checked)
            {
                secim = "robot";
                this.BackgroundImage = robot.Images[0];
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && secim == "robot")
            {
                mermi mrmi = new mermi();
                mrmi.x = this.Location.X;
                mrmi.y = this.Location.Y;
                mrmi.dogrultu = dogrultu;
                mrmi.Show();
            }
        }

        private void çocukToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (çocukToolStripMenuItem.Checked)
            {
                secim = "cocuk";
                this.BackgroundImage = cocuk.Images[0];
            }
        }

        private void kızToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (kızToolStripMenuItem.Checked)
            {
                secim = "kız";
                this.BackgroundImage = kız.Images[0];
            }
            
        }
    }
}