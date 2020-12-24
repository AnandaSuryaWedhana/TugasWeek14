using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void konversi_Click(object sender, EventArgs e)
        {
            int i1 = (int)Convert.ToChar(digantidengan.Text);
            int i2 = (int)Convert.ToChar(hurufyangmaudiganti.Text);
            int pengubah = i1 - i2;
            int s = inputan.Text.Length;
            for (int i = 0; i < s; i++)
            {
                int i3 = (int)Convert.ToChar(inputan.Text[i]);
                int total = i3 + pengubah;
                // hai
                char c = (char)total;
                //string jadi = new string(c);
                hasil.Text += c.ToString();
            }
            
        }
    }
}
