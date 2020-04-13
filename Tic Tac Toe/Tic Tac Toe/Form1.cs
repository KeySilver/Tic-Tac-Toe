using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int oyuncu = 1, sayac = 0; bool bitis = false;
        char [,]matris = new char[3,3];
        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labeleYazdir(oyuncu);
            matrisiDoldur();
            temizle();
            sayac = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button1.Text = "X";
                button1.Enabled = false;
                oyuncu = 0;            
                matris[0,0] = 'X';
                anaFonksiyon();
            }
            else
            {
                button1.Text = "O";
                button1.Enabled = false;
                oyuncu = 1;
                matris[0, 0] = 'O';
                anaFonksiyon();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button2.Text = "X";
                button2.Enabled = false;
                oyuncu = 0;
                matris[0, 1] = 'X';
                anaFonksiyon();
            }
            else
            {
                button2.Text = "O";
                button2.Enabled = false;
                oyuncu = 1;
                matris[0, 1] = 'O';
                anaFonksiyon();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button3.Text = "X";
                button3.Enabled = false;
                oyuncu = 0;
                matris[0, 2] = 'X';
                anaFonksiyon();
            }
            else
            {
                button3.Text = "O";
                button3.Enabled = false;
                oyuncu = 1;
                matris[0, 2] = 'O';
                anaFonksiyon();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button4.Text = "X";
                button4.Enabled = false;
                oyuncu = 0;
                matris[1, 0] = 'X';
                anaFonksiyon();
            }
            else
            {
                button4.Text = "O";
                button4.Enabled = false;
                oyuncu = 1;
                matris[1, 0] = 'O';
                anaFonksiyon();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button5.Text = "X";
                button5.Enabled = false;
                oyuncu = 0;
                matris[1, 1] = 'X';
                anaFonksiyon();
            }
            else
            {
                button5.Text = "O";
                button5.Enabled = false;
                oyuncu = 1;
                matris[1, 1] = 'O';
                anaFonksiyon();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button6.Text = "X";
                button6.Enabled = false;
                oyuncu = 0;
                matris[1, 2] = 'X';
                anaFonksiyon();
            }
            else
            {
                button6.Text = "O";
                button6.Enabled = false;
                oyuncu = 1;
                matris[1, 2] = 'O';
                anaFonksiyon();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button7.Text = "X";
                button7.Enabled = false;
                oyuncu = 0;
                matris[2, 0] = 'X';
                anaFonksiyon();
            }
            else
            {
                button7.Text = "O";
                button7.Enabled = false;
                oyuncu = 1;
                matris[2, 0] = 'O';
                anaFonksiyon();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button8.Text = "X";
                button8.Enabled = false;
                oyuncu = 0;
                matris[2, 1] = 'X';
                anaFonksiyon();
            }
            else
            {
                button8.Text = "O";
                button8.Enabled = false;
                oyuncu = 1;
                matris[2, 1] = 'O';
                anaFonksiyon();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (oyuncu == 1)
            {
                button9.Text = "X";
                button9.Enabled = false;
                oyuncu = 0;
                matris[2, 2] = 'X';
                anaFonksiyon();
            }
            else
            {
                button9.Text = "O";
                button9.Enabled = false;
                oyuncu = 1;
                matris[2, 2] = 'O';
                anaFonksiyon();
            }
        }

        void labeleYazdir(int kisi)
        {
            if (kisi == 1)
            {
                label1.Text = "Sıradaki Oyuncu X";
            }
            else
            {
                label1.Text = "Sıradaki Oyuncu O";
            }
        }

        void temizle()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            matrisiDoldur();
        }

        void kontrol()
        {
            char gamer;
            if (oyuncu == 1)
            {
                gamer = 'O';
            }
            else
            {
                gamer = 'X';
            }
            for (int i = 0; i < 3; i++)
            {

                if ((matris[i,0] == matris[i,1]) && (matris[i,1] == matris[i,2]))
                {
                    MessageBox.Show("Oyunu Kazanan " + gamer + " ...");
                    bitis = true;
                    butonFalse();
                    break;
                }
                else if ((matris[0, i] == matris[1, i]) && (matris[1, i] == matris[2, i]))
                {
                    MessageBox.Show("Oyunu Kazanan " + gamer + " ...");
                    bitis = true;
                    butonFalse();
                    break;
                }
                else if ((matris[0, 0] == matris[1, 1]) && (matris[1, 1] == matris[2, 2]))
                {
                    MessageBox.Show("Oyunu Kazanan " + gamer + " ...");
                    bitis = true;
                    butonFalse();
                    break;
                }
                else if ((matris[2, 0] == matris[1, 1]) && (matris[1, 1] == matris[0, 2]))
                {
                    MessageBox.Show("Oyunu Kazanan " + gamer + " ...");
                    bitis = true;
                    butonFalse();
                    break;
                }
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyayaYaz();
            Application.Exit();
        }

        private void hakkkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Geliştirici : Ramazan Harmaner Bilgisayar Mühendisi" , "Credits By" , MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrisiDoldur();
            dosyadanOku();
            labeleYazdir(oyuncu);
        }

        void matrisiDoldur()
        {
            int d = 0; 
            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    matris[i, j] = Convert.ToChar(d);
                    d++;
                }
            }
        }
        void butonFalse()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void anaFonksiyon()
        {       
            sayac++;

            if (sayac == 9)
            {
                temizle();
                sayac = 0;
                labeleYazdir(oyuncu);
            }
            else
            {
                kontrol();
                if (bitis == false)
                {
                    labeleYazdir(oyuncu);
                }
                else
                {
                    bitis = false;
                }
                
                
            }
        }

        void dosyadanOku()
        {
            string dizin = "C:\\Windows\\Temp\\Siradaki_Kisi.txt";
            if (File.Exists(dizin) == true)
            {
                FileStream fs = new FileStream(dizin, FileMode.Open, FileAccess.Read);
                StreamReader sw = new StreamReader(fs);
                string satir = sw.ReadLine();
                while (satir != null)
                {

                oyuncu = Convert.ToInt32(satir);
                satir = sw.ReadLine();

                }
                sw.Close();
                fs.Close();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dosyayaYaz();
        }

        void dosyayaYaz()
        {
            string dizin = "C:\\Windows\\Temp\\Siradaki_Kisi.txt";
            System.IO.File.Delete(dizin);

            FileStream fs = new FileStream(dizin, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(oyuncu.ToString());

            sw.Flush();
            sw.Close();
            fs.Close();

        }

    }
}
