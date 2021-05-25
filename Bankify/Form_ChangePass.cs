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
    public partial class Form_ChangePass : Form
    {
        private int login_id;

        public Form_ChangePass(int login_id)
        {
            InitializeComponent();
            CenterToScreen();
            this.login_id = login_id;
        }

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            bool wrongPass = false;
            bool newPassIsNull = false;
            bool wrongConfPass = false;
            try
            {
                string oldPass = textBox_oldPass.Text;
                string newPass = textBox_newPass.Text;
                string confirmPass = textBox_confirmPass.Text;
                if(newPass=="")
                {
                    newPassIsNull = true;
                }
                else
                {
                    if (newPass != confirmPass)
                    {
                        wrongConfPass = true;
                    }
                }
                using(var db=new Bank_dbEntities())
                {
                    var query = (from b in db.LoginAccount
                                 where b.login_id==login_id
                                 select b).First();
                    if (query.login_password != oldPass)
                    {
                        wrongPass = true;
                        throw new InvalidOperationException();
                    }
                    else
                    {
                        if(newPassIsNull || wrongConfPass)
                        {
                            throw new InvalidOperationException();
                        }
                        else
                        {
                            using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                            {
                                con.Open();
                                SqlCommand command = new SqlCommand("UPDATE LoginAccount SET login_password = @password " +
                                                                    "WHERE login_id=@id", con);
                                command.Parameters.AddWithValue("@password", newPass);
                                command.Parameters.AddWithValue("@id", login_id);
                                command.ExecuteNonQuery();
                                con.Close();
                            }
                            db.SaveChanges();
                            this.Close();
                            MessageBox.Show("Password changed!");
                        }
                    }
                }
            }
            catch (InvalidOperationException)
            {
                if (wrongPass)
                {
                    MessageBox.Show("Old password is incorrect!");
                }
                else
                {
                    if (newPassIsNull)
                    {
                        MessageBox.Show("New password can NOT be NULL!");
                    }
                    else
                    {
                        if (wrongConfPass)
                        {
                            MessageBox.Show("Confirm new password MUST be identical with new password!");
                        }
                    }
                }
            }
        }
    }
}
