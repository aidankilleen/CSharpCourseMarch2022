using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked the button");
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {

        }

        private void btnTest3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button 3 pressed");
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            btnActive.Enabled = chkActive.Checked;
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = (string)lstUsers.SelectedItem;

            txtName.Text = name;

            txtName2.Text = name;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            txtCoordinates.Text = $"{ e.Location }";

        }

        private void pnlColour_Click(object sender, EventArgs e)
        {
            if (dlgColour.ShowDialog() == DialogResult.OK)
            {
                pnlColour.BackColor = dlgColour.Color;
            }
        }

        private void pnlColour_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
