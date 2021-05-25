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
    public partial class Form_Admin_Menu : Form
    {
        Form_login parentForm;
        public Form_Admin_Menu(Form_login form)
        {
            InitializeComponent();
            parentForm = form;
            parentForm.Hide();
            CenterToScreen();
        }

        private void CD_BTN_Click(object sender, EventArgs e)
        {
            Form_Admin_ClientData form_Admin_ClientData = new Form_Admin_ClientData();
            form_Admin_ClientData.Show();
        }

        private void LA_BTN_Click(object sender, EventArgs e)
        {
            Form_Admin_LoginAccount form_Admin_LoginAccount = new Form_Admin_LoginAccount();
            form_Admin_LoginAccount.Show();
        }

        private void BA_BTN_Click(object sender, EventArgs e)
        {
            Form_Admin_BankAccount form_Admin_BankAccount = new Form_Admin_BankAccount();
            form_Admin_BankAccount.Show();
        }

        private void Form_Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void button_add_funds_Click(object sender, EventArgs e)
        {
            Form_Admin_Add_Funds form_Admin_Add_Funds = new Form_Admin_Add_Funds();
            form_Admin_Add_Funds.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_LoginClient_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            Close();
        }
    }
}
