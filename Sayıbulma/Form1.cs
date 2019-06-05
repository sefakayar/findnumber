using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayıbulma
{
    public partial class Form1 : Form
    {
        //global değişkenler burada tanımlanır
        int sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbtut_Click(object sender, EventArgs e)
        {

        }

        private void btesit_Click(object sender, EventArgs e)
        {
            char islem;
            int s1, s2, sonuc;

            islem = Convert.ToChar(lbislem.SelectedItem);
            s1 = Convert.ToInt32(tbsayi1.Text);
            s2 = Convert.ToInt32(tbsayi2.Text);

            switch (islem)
            {
                case '+':sonuc = s1 + s2; break; //karakterler '' şeklinde gösterilir.
                case '-': sonuc = s1 - s2; break;
                case 'x': sonuc = s1 * s2; break;
                case '/': sonuc = s1 / s2; break;
                default: sonuc = 0; break;
            }
            lbsayilar.Items.Add(sonuc);
            tbsayi1.Text = "";
            tbsayi2.Text = "";
            if (sonuc == sayi)
                MessageBox.Show("Tebrikler");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbsayilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbislem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbsayi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbsayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            sayi = r.Next(100, 999);
            lbtut.Text = sayi.ToString();
        }

        private void lbsayilar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string rakam;
            int index;
            index = lbsayilar.SelectedIndex; //kaçıncı eleman seçildi
            rakam = lbsayilar.SelectedItem.ToString(); //eleman

            if (tbsayi1.Text == "") // "" boşsa demektir.
                tbsayi1.Text = rakam;
            else
                tbsayi2.Text = rakam;

            lbsayilar.Items.RemoveAt(index); //seçilen rakamı sil

        }
    }
}
