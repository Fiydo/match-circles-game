using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        int ct=0,v,v2,rec_x=300, rec_y=50, rec2_x=750, rec2_y=50,w=420,h=500;
        Random rr = new Random();
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black;
            this.KeyDown += Form1_KeyDown;
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawsence();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics g = CreateGraphics();
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    g.FillEllipse(Brushes.Yellow, rec2_x + 10, rec2_y + 10, 50, 50);
                    rec2_x += 70;
                    if (rec2_x > 750 + 400)
                    {
                        rec2_x = 750;
                        rec2_y += 70;
                    }
                    ct++;
                    break;
                case Keys.Space:
                    if((v2+ct)==v)
                    {
                        MessageBox.Show("good");

                    }
                    else
                    {
                        MessageBox.Show("NO !");
                    }
                    break;
            }
           
        }
        void drawsence()
        {
            Graphics g = CreateGraphics();
            g.DrawRectangle(Pens.Gold, rec_x, rec_y, w, h);
            g.DrawRectangle(Pens.Gold, rec2_x, rec2_y, w, h);
            for (; ; )
            {
                v = rr.Next(30);
                v2 = rr.Next(27);
                if (v2 < v)
                    break;
            }
            for (int i = 0; i < v; i++)
            {
                
                g.FillRectangle(Brushes.Red, rec_x+ 10, rec_y + 10, 50, 50);
                rec_x += 70;
                if (rec_x > 300+400)
                {
                    rec_x = 300;
                    rec_y += 70;
                }

            }
            for (int i = 0; i < v2; i++)
            {

                g.FillRectangle(Brushes.Red, rec2_x + 10, rec2_y + 10, 50, 50);
                rec2_x += 70;
                if (rec2_x > 750 + 400)
                {
                    rec2_x = 750;
                    rec2_y += 70;
                }

            }

        }
    }
}
