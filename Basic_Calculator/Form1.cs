using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {

        private char _islem;
        private bool _EkranTemizlenecekMi;
        int _ilkSayi = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") lbl_Ekran.Text = "";

            lbl_Ekran.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (_EkranTemizlenecekMi)
            {
                lbl_Ekran.Text = "";
                _EkranTemizlenecekMi = false;
            }

            if (lbl_Ekran.Text == "0") { }

            else { lbl_Ekran.Text += "0"; }
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {

            _islem = '+';

            _EkranTemizlenecekMi = true;

            _ilkSayi = Convert.ToInt32(lbl_Ekran.Text);
        }

        private void btn_Esittir_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(lbl_Ekran.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;

                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;

                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;

                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;

                    default:
                    sonuc = 0;  // Bu kısmı yapmazsan Sonucun değer atanmama olasılığından dolayı hata verebilir @@@@
                    break;
            }

            lbl_Ekran.Text = sonuc.ToString();

            if (sonuc>Int32.MaxValue)

            { lbl_Ekran.Text = "ERROR"; }
        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            _islem = '-';

            _EkranTemizlenecekMi = true;

            _ilkSayi = Convert.ToInt32(lbl_Ekran.Text);
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            _islem = '*';

            _EkranTemizlenecekMi = true;

            _ilkSayi = Convert.ToInt32(lbl_Ekran.Text);
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            _islem = '/';

            _EkranTemizlenecekMi = true;

            _ilkSayi = Convert.ToInt32(lbl_Ekran.Text);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            lbl_Ekran.Text = "0";
        }
    }
}
