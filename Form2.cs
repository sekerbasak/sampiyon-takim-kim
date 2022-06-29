using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders10__
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int gs_puan = 0, fb_puan = 0, bjk_puan = 0, ts_puan = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            
            
            int maxdeger;
            string sampiyon;
            int gs_puan=Convert.ToInt32( label20.Text);
            int fb_puan = Convert.ToInt32(label14.Text);
            int bjk_puan = Convert.ToInt32(label17.Text);
            int ts_puan = Convert.ToInt32(label13.Text);
            if (gs_puan>fb_puan)
            {
                maxdeger = gs_puan;
                sampiyon = "GALATASARAY";
                pictureBox1.ImageLocation = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\indir.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\gs.mp3";
            }
            else
            {
                maxdeger = fb_puan;
                sampiyon = "FENERBAHÇE";
                pictureBox1.ImageLocation = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\fb.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\fb.mp3";
            }
            if (bjk_puan > maxdeger)
            {
                maxdeger = bjk_puan;
                sampiyon = "BEŞİKTAŞ";
                pictureBox1.ImageLocation = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\bjk.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\bjk.mp3";
            }
            if(ts_puan>maxdeger)
            {
                maxdeger = ts_puan;
                sampiyon = "TRABZONSPOR";
                pictureBox1.ImageLocation = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\ts.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\ABC\\Desktop\\YAZ C# FORM ÇALIŞMAM\\images\\ts.mp3";
            }
            button4.Visible = false;
            label39.Text = "ŞAMPİYON " + sampiyon +"!!!";
            label39.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = true;
            int g = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int f = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);

            label38.Text = g.ToString();
            label35.Text = b.ToString();
            label32.Text = f.ToString();
            label31.Text = t.ToString();
            int G = Convert.ToInt32(g); int B = Convert.ToInt32(b); int F = Convert.ToInt32(f); int T = Convert.ToInt32(t);

            if (G > F)
            {
                gs_puan += 3;
                fb_puan += 0;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();

            }
            if (F > G)
            {
                gs_puan += 0;
                fb_puan += 3;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();
            }
            if (F == G)
            {
                gs_puan += 1;
                fb_puan += 1;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();
            }

            if (B > T)
            {
                bjk_puan += 3;
                ts_puan += 0;
                label17.Text = bjk_puan.ToString();
            }
            if (T > B)
            {
                bjk_puan += 0;
                ts_puan += 3;
                label13.Text = ts_puan.ToString();
            }

            if (T == B)
            {
                bjk_puan += 1;
                ts_puan += 1;
                label13.Text = ts_puan.ToString();
                label17.Text = bjk_puan.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            int g = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int f = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);

            label28.Text = g.ToString();
            label25.Text = b.ToString();
            label22.Text = f.ToString();
            label21.Text = t.ToString();
            int G = Convert.ToInt32(g); int B = Convert.ToInt32(b); int F = Convert.ToInt32(f); int T = Convert.ToInt32(t);

            if (G > F)
            {
                gs_puan += 3;
                fb_puan += 0;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();

            }
            if (F > G)
            {
                gs_puan += 0;
                fb_puan += 3;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();
            }
            if (F == G)
            {
                gs_puan += 1;
                fb_puan += 1;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();
            }

            if (B > T)
            {
                bjk_puan += 3;
                ts_puan += 0;
                label17.Text = bjk_puan.ToString();
            }
            if (T > B)
            {
                bjk_puan += 0;
                ts_puan += 3;
                label13.Text = ts_puan.ToString();
            }

            if (T == B)
            {
                bjk_puan += 1;
                ts_puan += 1;
                label13.Text = ts_puan.ToString();
                label17.Text = bjk_puan.ToString();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int g = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int f = rastgele.Next(0, 5);
            int t = rastgele.Next(0, 5);

            label3.Text = g.ToString();
            label4.Text = b.ToString();
            label7.Text = f.ToString();
            label8.Text = t.ToString();
            int G = Convert.ToInt32(g); int B = Convert.ToInt32(b); int F = Convert.ToInt32(f); int T = Convert.ToInt32(t);

               if (G>F)
            {
                gs_puan += 3;
                fb_puan += 0;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();

            }
             if (F>G)
            {
                gs_puan += 0;
                fb_puan += 3;
               label20.Text = gs_puan.ToString();
               label14.Text = fb_puan.ToString();
            }
            if(F==G)
            {
                gs_puan += 1;
                fb_puan += 1;
                label20.Text = gs_puan.ToString();
                label14.Text = fb_puan.ToString();
            }

              if (B > T)
            {
                bjk_puan += 3;
                ts_puan += 0;
                label17.Text = bjk_puan.ToString();
            }
             if (T > B)
            {
                bjk_puan += 0;
                ts_puan += 3;
                label13.Text = ts_puan.ToString();
            }
        
            if(T==B)
            {
                bjk_puan += 1;
                ts_puan += 1;
                label13.Text = ts_puan.ToString();
                label17.Text = bjk_puan.ToString();

            }

            button1.Enabled = false;
            
     }      
            
    }
}
