using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashForm
{
    public partial class DemThoiGian : Form
    {
        public DemThoiGian()
        {
            InitializeComponent();
        }
        int dem;
        private void btnDem_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int mi, se;
            dem++;
            mi = dem/60;
            se = dem % 60;
            label1.Text = (mi < 9 ? "0" + mi : mi + "" )+ ":"+ (se < 9 ? "0" + se : se + " ");
        }
    }
}
