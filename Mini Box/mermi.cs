using System;
using System.Drawing;

namespace Mini_Box
{
    public partial class mermi : DevExpress.XtraEditors.XtraForm
    {
        // sag 0 sol 6
        public int x, y;
        public string dogrultu;
        int sag, sol = 6, sayac;
        public mermi()
        {
            InitializeComponent();
        }

        private void mermi_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac+=2;
            if (dogrultu == "sol")
            {
                this.BackgroundImage = mermiresim.Images[sol];
                if (sol != 11)
                {
                    sol++;
                }
                this.Location = new Point(x - sayac,y);
                if (this.Location.X <= 0)
                {
                    timer1.Enabled = false;
                    sayac = 0;
                    timer2.Enabled = true;
                }
            }
            else
            {
                this.BackgroundImage = mermiresim.Images[sag];
                if (sag != 7)
                {
                    sag++;
                }
                this.Location = new Point(x + sayac, y);
                if (this.Location.X >= 1346)
                {
                    timer1.Enabled = false;
                    sayac = 0;
                    timer2.Enabled = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            this.BackgroundImage = patlamaresim.Images[sayac];
            sayac++;
            if (sayac == 29)
            {
                this.Close();
            }
        }
    }
}