using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Rtr_Circuit : Form
    {
        public Rtr_Circuit()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Router r1 = new Router();
            r1.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Router r1 = new Router();
            r1.ShowDialog();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Rtr_Circuit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ChkBox_RtrType_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
    }
}
