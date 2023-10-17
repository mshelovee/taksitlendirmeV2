using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taksitlendirmeV2__96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            double tutar;
            tutar = Convert.ToDouble(txtTutar.Text);

            if (rbTaksit2.Checked == true || rbTaksit3.Checked == true)
            {
                tutar = tutar + (tutar * 0.05);
            }

            if (rbTaksit4.Checked == true || rbTaksit5.Checked == true);
            {
                tutar = tutar + (tutar * 0.10);
            }

            MessageBox.Show("Ödenecek toplam tutar :" + tutar.ToString() + "TL");
        }

    }
}
