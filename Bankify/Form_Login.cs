using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankify
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            int login_id=0;
            string account_type = "";
            using (var db=new Bank_dbEntities())
            {
                try
                {
                    var query = (from b in db.LoginAccount
                                 where b.login_username == username && b.login_password == password
                                 select b).First();

                    login_id = query.login_id;

                    var query1 = (from b in db.LoginAccount
                                  where b.login_id == login_id
                                  select b).First();

                    account_type = query1.account_type;

                    if (account_type == "client")
                    {
                        Form_Client form_Client = new Form_Client(login_id);
                        form_Client.Show();
                    }
                    else
                    {
                        if (account_type == "admin")
                        {
                            Form_Admin form_Admin = new Form_Admin();
                            form_Admin.Show();
                        }
                    }
                }
                catch (InvalidOperationException ex)
                {
                    try
                    {
                        var query= (from b in db.LoginAccount
                                    where b.login_username == username 
                                    select b).First();
                        try
                        {
                            var query1 = (from b in db.LoginAccount
                                         where b.login_password == password
                                         select b).First();
                        }
                        catch(InvalidOperationException ex1)
                        {
                            MessageBox.Show("Parola este gresita");
                        }
                    }
                    catch(InvalidOperationException ex2)
                    {
                        MessageBox.Show("Username-ul nu exista");
                    }
                }
                textBox_password.Clear();
                textBox_username.Clear();
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }
    }
}
