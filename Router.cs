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
    public partial class Router : Form
    {
        public Router()
        {
            InitializeComponent();
        }

        private void Router_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main_form = new Main();
            main_form.Show();
            
        }

        private void Btn_Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rtr_Circuit f1 = new Rtr_Circuit();
            f1.ShowDialog();
        }

        private void Router_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
