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
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
          
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            for(int i  = 0; i < 100; i++)
            {
                backgroundWorker1.ReportProgress(i,i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "123")
            {
                MessageBox.Show("đăng nhập thành công");
            }
        }
    }
}
