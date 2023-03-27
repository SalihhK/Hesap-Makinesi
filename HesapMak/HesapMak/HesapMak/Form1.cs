using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMak
{
    public partial class Form1 : Form
    {//kullanılacak olan değişkenleri tanımlıyoruz
        char _islem; 
        bool _ekrantemizle;
        int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {if (_ekrantemizle == true) ekranlabel.Text = "";// eğer ekranın temizlenmesi gerekiyorsa temizliyoruz
            if(ekranlabel.Text=="0") ekranlabel.Text="";// ekranda yazan değer 0 ise siliyoruz
            _ekrantemizle = false;// yazılan sayı her seferinde silinmesin diye ekranı silme işlemini durduruyoruz
            ekranlabel.Text += 1;// butona bastığımıza değeri ekrana yazmasını sağlıyoruz
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";// yukarıda yazılanları tüm butonlar için tanımlıyoruz
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;

            ekranlabel.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;
            ekranlabel.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;
            ekranlabel.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;
            ekranlabel.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;
            ekranlabel.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;
            ekranlabel.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;
            ekranlabel.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle == true) ekranlabel.Text = "";
            if (ekranlabel.Text == "0") ekranlabel.Text = "";
            _ekrantemizle = false;
            ekranlabel.Text += 9;
        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
            _islem = '+';//işlemin + olduğunu hafızasında tutmasını sağlıyoruz
            _ekrantemizle = true; // ekranı sildiriyoruz
            _ilksayi = Convert.ToInt32(ekranlabel.Text);//ekranda yazanı ilk sayı olarak alıyoruz
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranlabel.Text);// ekranda yazanı ikinci sayı olarak aldık
            int sonuc = 0;
            switch(_islem) {
                case '+':
                    sonuc=_ilksayi+ikincisayi; break;//eğer + tuşuna basılırsa yapılması gereken işlem tanımlandı
                case '-':
                    sonuc = _ilksayi - ikincisayi; break;//eğer - tuşuna basılırsa yapılması gereken işlem tanımlandı
                case '*':
                    sonuc = _ilksayi * ikincisayi; break;//eğer * tuşuna basılırsa yapılması gereken işlem tanımlandı
                case '/':
                    sonuc = _ilksayi / ikincisayi; break;//eğer / tuşuna basılırsa yapılması gereken işlem tanımlandı


            }
            ekranlabel.Text=Convert.ToString(sonuc);  //ekrana sonuçu yazdırdık
        }

        private void buttonEksi_Click(object sender, EventArgs e)
            //+ tuşunda olan kodları diğer işlem tuşlarına da ekliyoruz
        {
            _islem = '-';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void buttonCarpi_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void buttonBolu_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(ekranlabel.Text);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ekranlabel.Text = "0";// c tuşuna basıldığında ekranı sıfırlamasını sağlıyoruz
        }
    }
}
