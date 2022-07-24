using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarisması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = -1, dogru = 0, yanlis = 0;
        int puan = 0;
        private void btnSonra_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            btnSonra.Enabled = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            lblSoruNo.Text = soruno.ToString();
            lblPuan.Text = puan.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "1)Cumhuriyet Kaç Yılında İlan Edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }

            if (soruno==2)
            {
                richTextBox1.Text = "2)Hangi İl Ege Bölgemizde Bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }

            if (soruno==3)
            {
                richTextBox1.Text = "3)Son Kuşlar Hangi Yazarımıza Aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atilla İlhan";
                btnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                
            }

            if (soruno==4)
            {
                richTextBox1.Text = "4)Beşiktaş`ın Kuruluş Yılı Kaçtır?";
                btnA.Text = "1905";
                btnB.Text = "1907";
                btnC.Text = "1903";
                btnD.Text = "1910";
                label4.Text = "1903";
                btnSonra.Text = "Sonuçlar";
            }

            if(soruno==5)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonra.Enabled = false;

                MessageBox.Show("Doğru Sayınız: " + dogru + "\n" + "Yanlış Sayınız: "+ yanlis + "\n" + "Puanınız: " + puan);

            }

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonra.Enabled = true;

            label5.Text = btnA.Text;
            if (label4.Text==label5.Text)
            {
                dogru++;
                puan += 25;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                puan -= 25;
                lblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
                    

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonra.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text==label5.Text)
            {
                dogru++;
                puan += 25;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                puan -= 25;
                lblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonra.Enabled = true;


            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                puan += 25;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                puan -= 25;
                lblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            btnSonra.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                puan += 25;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                puan -= 25;
                lblYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }


    }
}
