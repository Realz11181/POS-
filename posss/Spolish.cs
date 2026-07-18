using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Spolish : Form
    {
        public Spolish()
        {
            InitializeComponent();
        }

        private void Spolish_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 2;
            progressBar1.Value = startPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                LogInForm LogInForm = new LogInForm();
                this.Hide();
                LogInForm.Show();
            }

        }

        
    }
}
