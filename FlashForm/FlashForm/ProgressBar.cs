using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashForm
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        List<int> list = new List<int>();
        int count;
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            timer1.Start();
            n = (int)numericUpDown1.Value;
            Random r = new Random();
           
            for(int i = 0; i < n; i++)
            {
                int so = r.Next(0,100);
                list.Add(so);
            }
            timer1.Stop();
            MessageBox.Show("Phát sinh thành công trong khoảng "+count+"");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
        }
    }
}
