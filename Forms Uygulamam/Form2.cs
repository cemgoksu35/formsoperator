using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Uygulamam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double sayi1, sayi2;
        double sonuc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);


            if (comboBox1.SelectedIndex==0)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                sonuc = sayi1 * sayi2;
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                sonuc = sayi1 / sayi2;
            }

            label1.Text = sonuc.ToString();

        }
    }
}
