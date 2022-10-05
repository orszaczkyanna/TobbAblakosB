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
    public partial class Laptop : Form
    {
        public Laptop()
        {
            InitializeComponent();
        }

        private void Laptop_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bezárja?", "Ablak bezárása", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.mainForm.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
