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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            if (Cbox_Rtr_Switch.Text.Equals("Router"))
            {
                this.Hide();
                Router Rtr_Frm = new Router();
                Rtr_Frm.ShowDialog();
            }
            else if (Cbox_Rtr_Switch.Text.Equals("Switch"))
            {
                this.Hide();
                Switch Sw1 = new Switch();
                Sw1.ShowDialog();
            }
        }

        private void Cbox_Rtr_Switch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
