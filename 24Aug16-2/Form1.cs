using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24Aug16_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbTurkey_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTurkey.Checked)
            {
                string recap = "Ordering Turkey";
                if (rbWhite.Checked)
                    lblRecap.Text = recap + " on White";
                if (rbWheat.Checked)
                    lblRecap.Text = recap + " on Wheat";
            }
        }

        private void rbHam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHam.Checked)
            {
                string recap = "Ordering Ham";
                if (rbWhite.Checked)
                    lblRecap.Text = recap + " on White";
                if (rbWheat.Checked)
                    lblRecap.Text = recap + " on Wheat";
            }

        }

        private void rbChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChicken.Checked)
            {
                string recap = "Ordering Chicken";
                if (rbWhite.Checked)
                    lblRecap.Text = recap + " on White";
                if (rbWheat.Checked)
                    lblRecap.Text = recap + " on Wheat";
            }
        }
    }
}
