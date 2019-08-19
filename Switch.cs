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
    public partial class Switch : Form
    {
        public Switch()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void Switch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
