using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhHapla_Click(object sender, EventArgs e)
        {
            int dogru, yanlıs;
            double netsayı;

            dogru = Convert.ToInt32(cmDogru.Text);
            yanlıs = Convert.ToInt32(cmYanlıs.Text);

            netsayı = dogru - yanlıs / 4.0;

            llblNet.Text = "Toplam Net Dogru:" + netsayı.ToString();
        }
    }
}
