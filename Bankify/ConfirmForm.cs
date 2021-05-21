using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankify
{
    public partial class ConfirmForm : Form
    {
        public static int option = -1;
        public ConfirmForm(string message)
        {
            InitializeComponent();
            message_LBL.Text = message;
            option = -1;
        }

        private void deny_BTN_Click(object sender, EventArgs e)
        {
            option = 0;
            this.Close();
        }

        private void accept_BTN_Click(object sender, EventArgs e)
        {
            option = 1;
            this.Close();
        }
    }
}
