using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankify
{
    public partial class Form_Forgot_Password : Form
    {
        public Form_Forgot_Password()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_Forgot_Password_Load(object sender, EventArgs e)
        {

        }
        public string NewPassword()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        private void button_send_email_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!String.IsNullOrEmpty(textBox_forgot_pass_email.Text))
            {
                string email = textBox_forgot_pass_email.Text;
                using (var db = new Bank_dbEntities())
                {
                    using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                    {
                        con.Open();
                        SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM ClientAccount WHERE email LIKE @email", con);
                        SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                        adapter.SelectCommand.Parameters.AddWithValue("@email", email);
                        count = adapter.SelectCommand.ExecuteNonQuery();
                        if (count != 0)
                        {
                            SqlCommand sqlCommandupdate = new SqlCommand("UPDATE LoginAccount SET login_password = @password  WHERE login_id IN (SELECT login_id FROM ClientAccount WHERE email=@email_from_db)", con);
                            SqlDataAdapter adapterupdate = new SqlDataAdapter(sqlCommandupdate);
                            adapterupdate.SelectCommand.Parameters.AddWithValue("@email_from_db", email);
                            adapterupdate.SelectCommand.Parameters.AddWithValue("@password", NewPassword());
                            adapterupdate.SelectCommand.ExecuteNonQuery();
                            con.Close();
                            try
                            {
                                MailMessage message = new MailMessage();
                                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25);
                                message.From = new MailAddress("bankify.reset.pass@gmail.com");
                                message.To.Add(new MailAddress(email));
                                message.Subject = "New Password Bankify";
                                message.Body = "Your new password is: " + NewPassword()+"\n \n \n \n \n From Bankify.com \n Your money closer that you can imagine!";
                                smtp.UseDefaultCredentials = false;
                                smtp.EnableSsl = true;
                                smtp.Credentials = new System.Net.NetworkCredential("bankify.reset.pass@gmail.com", "proiectii");
                                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                                smtp.Send(message);
                                MessageBox.Show("Mail Sent");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong Email!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Email!");
            }
        }
    }
}
