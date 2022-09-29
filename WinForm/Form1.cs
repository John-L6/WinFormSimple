using System;
using System.Windows.Forms;


namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCopy_Click(object sender, EventArgs e)
        {
            txtDestination.Text = txtSource.Text;
        }
    }
}
