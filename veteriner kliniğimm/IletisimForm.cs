using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veteriner_kliniğimm
{
    public partial class IletisimForm : Form
    {
        public IletisimForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:info@patidostu.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void IletisimForm_Load(object sender, EventArgs e)
        {

        }
    }
}
