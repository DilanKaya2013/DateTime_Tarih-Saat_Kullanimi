using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_Tarihsaat_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime bugun = DateTime.Now;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "En Küçük: " + DateTime.MinValue;
            label2.Text = "En Büyük: " + DateTime.MaxValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Now  : " + DateTime.Now;
            label4.Text = "Today: " + DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime tarihSaat = new DateTime();
            tarihSaat = DateTime.Now;

            DateTime tarih = new DateTime();
            tarih = DateTime.Today;

            label5.Text = tarihSaat.ToString();
            label6.Text = tarih.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = new DateTime(2022, 8, 25);


           label7.Text = "Tarih: " + bugun.ToShortDateString();
           label8.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = dateTimePicker1.Value;


            label9.Text = "Tarih: " + bugun.ToShortDateString();
            label10.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }

        private void btnDate_Click_1(object sender, EventArgs e)
        {
            label11.Text = bugun.Date.ToString();
        }

        private void btnMonth_Click_1(object sender, EventArgs e)
        {
           label12.Text = bugun.Month.ToString();
        }

        private void btnDay_Click_1(object sender, EventArgs e)
        {
           label13.Text = bugun.Day.ToString();
        }

        private void btnYear_Click_1(object sender, EventArgs e)
        {
          label14.Text = bugun.Year.ToString();
        }

        private void btnDayOfWeek_Click_1(object sender, EventArgs e)
        {
           label15.Text = bugun.DayOfWeek.ToString();
        }

        private void btnDayOfYear_Click_1(object sender, EventArgs e)
        {
            label16.Text = bugun.DayOfYear.ToString();
        }

        private void btnTimeOfDay_Click_1(object sender, EventArgs e)
        {

           label17.Text = bugun.TimeOfDay.ToString();
        }

        private void btnHour_Click_1(object sender, EventArgs e)
        {
           label18.Text = bugun.Hour.ToString();
        }

        private void btnMinute_Click_1(object sender, EventArgs e)
        {
            label19.Text = bugun.Minute.ToString();
        }

        private void btnSecond_Click_1(object sender, EventArgs e)
        {
           label20.Text = bugun.Second.ToString();
        }

        private void btnMilliSecond_Click_1(object sender, EventArgs e)
        {
          label21.Text = bugun.Millisecond.ToString();
        }

        private void btnTicks_Click_1(object sender, EventArgs e)
        {
          label22.Text = bugun.Ticks.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            DateTime bugun = DateTime.Now;
            label23.Text = bugun.ToString();
            label24.Text = bugun.AddDays(5).ToString() + " 5 gün eklendi."; //Bugünün tarihine 5 gün ekle.
            label25.Text = bugun.AddMonths(2).ToString() + " 2 ay eklendi.";//Bugünün tarihine 2 ay ekle.
            label26.Text = bugun.AddYears(2).ToString() + " 2 yıl eklendi.";//Bugünün tarihine 2 yıl ekle.
            label27.Text = bugun.AddHours(3).ToString() + " 3 saat eklendi.";//Anlık saate 3 saat ekle
            label28.Text = bugun.AddMinutes(15).ToString() + " 15 dakika eklendi.";//Anlık saate 15 dakika ekle.
            label29.Text = bugun.AddSeconds(20).ToString() + " 20 saniye eklendi.";//Anlık saate 20 saniye ekle.
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Now;
            DateTime sonOdeme = new DateTime(2022, 3, 30, 14, 30, 50, 20);
            label30.Text = "Bugün: " + bugun.ToString();
            label31.Text = "Son Ödeme: " + sonOdeme.ToString();
            TimeSpan tarihFark = sonOdeme - bugun;
            label32.Text = "Gün Farkı: " + tarihFark.Days.ToString();
            label33.Text = "Saat Farkı: " + tarihFark.Hours.ToString();
            label34.Text = "Dakika Farkı: " + tarihFark.Minutes.ToString();
            label35.Text = "Saniye Farkı: " + tarihFark.Seconds.ToString();
            label36.Text = "MiliSaniye Farkı: " + tarihFark.Milliseconds.ToString();
        }
    }
}
