using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowForm_Click(object sender, EventArgs e) 
        {
            FrmTwo two = new FrmTwo();
            two.lblShare.Text = txtShared.Text;
            two.Show();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
