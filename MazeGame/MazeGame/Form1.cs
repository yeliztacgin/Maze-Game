using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure = 15;
        DialogResult deger;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAYBETTİNİZ", "KENARA DEĞDİNİZ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        
        
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("KAZANDIN", "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Sure(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure==0)
            {
                timer1.Enabled = false;
                deger = MessageBox.Show("SÜRE BİTTİ", "TEKRAR OYNAMAK İSTERMİSİNİZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deger==DialogResult.Yes)
                {
                    sure = 15;
                    sure--;
                    timer1.Enabled = true;
                }
                else if (deger==DialogResult.No)
                {
                    this.Close();

                }      
            }
            else
            {
                sure--;
                label2.Text = Convert.ToString(sure);
                timer1.Enabled = true;
            }



        }
    }
}
