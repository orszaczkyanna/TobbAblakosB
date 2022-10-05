using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TobbAblakosB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void asztaliGepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.asztali.ShowDialog();
        }

        private void laptopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.laptop.Show();            
        }
    }
}
