using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_mantıksal_ortalama_devamsızlık_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
          float ortalama, devamsızlık;

            ortalama=Convert.ToSingle(txtOrtalama.Text);
            devamsızlık=Convert.ToSingle(txtDevamsizlik.Text);

             if (ortalama >= 50 && devamsızlık < 10)
            {
                lblSonuc.Text = "Sonuç: Geçti";
            }
            else
            {
                lblSonuc.Text = "Sonuç: Kaldı";
            }
        }
    }
}
