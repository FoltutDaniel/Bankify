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
    public partial class Form_Admin_ClientData : Form
    {
        int searchclick = 0;
        public Form_Admin_ClientData()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_dbDataSet1.ClientAccount' table. You can move, or remove it, as needed.
            this.clientAccountTableAdapter.Fill(this.bank_dbDataSet1.ClientAccount);
            // TODO: This line of code loads data into the 'bank_dbDataSet4.ClientAccount' table. You can move, or remove it, as needed.
            this.clientAccountTableAdapter1.Fill(this.bank_dbDataSet4.ClientAccount);
            this.clientAccountTableAdapter.Fill(this.bank_dbDataSet.ClientAccount);
            dataGridView_accounts.Columns[0].HeaderText = "Client ID";
            dataGridView_accounts.Columns[1].HeaderText = "First Name";
            dataGridView_accounts.Columns[2].HeaderText = "Last Name";
            dataGridView_accounts.Columns[3].HeaderText = "Age";
            dataGridView_accounts.Columns[4].HeaderText = "Country";
            dataGridView_accounts.Columns[5].HeaderText = "Phone Number";
            dataGridView_accounts.Columns[6].HeaderText = "Email";
            dataGridView_accounts.Columns[7].HeaderText = "Birthday";
            dataGridView_accounts.Columns[8].HeaderText = "Login ID";
            dataGridView_accounts.Columns[9].HeaderText = "CNP";
            SCNP_TB.Visible = false;
            CNP_LBL.Visible = false;
            showAll_BTN.Visible = false;

        }

        private void button_add_account_Click(object sender, EventArgs e)
        {
            ClientAccount clientAccount = new ClientAccount();
            if (isFieldEmpty())
            {
                MessageBox.Show(("Some field is empty!"));
            }
            else
            {
                using (var db = new Bank_dbEntities())
                {
                    try
                    {
                        try
                        {
                            if (validNames(textBox_first_name.Text, textBox_last_name.Text))
                            {
                                clientAccount.first_name = textBox_first_name.Text;
                                clientAccount.last_name = textBox_last_name.Text;
                            }
                            else
                            {
                                MessageBox.Show("Numele nu pot contine numere!");
                            }
                            if (char.IsDigit(textBox_age.Text, 0))
                            {
                                clientAccount.age = int.Parse(textBox_age.Text);
                            }
                            else
                            {
                                MessageBox.Show("Varsta gresita!");
                            }
                            clientAccount.country = textBox_country.Text;
                            if (char.IsDigit(textBox_phone_number.Text, 0))
                            {
                                clientAccount.phone_number = textBox_phone_number.Text;
                            }
                            else
                            {
                                MessageBox.Show("Numar de telefon gresit!");
                            }
                            clientAccount.email = textBox_email.Text;
                            clientAccount.birthday = dateTimePicker_birthday.Value;
                            if (char.IsDigit(textBox_log_in_id.Text, 0))
                            {
                                clientAccount.login_id = int.Parse(textBox_log_in_id.Text);
                            }
                            else
                            {
                                MessageBox.Show("Log in ID gresit!");
                            }
                            if (isCnpValid(CNP_TB.Text))
                            {
                                clientAccount.CNP = CNP_TB.Text;
                            }
                            else
                            {
                                MessageBox.Show("CNP invalid!");
                            }

                            try
                            {
                                db.ClientAccount.Add(clientAccount);
                                db.SaveChanges();
                                MessageBox.Show("Adaugare reusita!");
                                textBox_first_name.Clear();
                                textBox_last_name.Clear();
                                textBox_age.Clear();
                                textBox_country.Clear();
                                textBox_email.Clear();
                                textBox_phone_number.Clear();
                                textBox_log_in_id.Clear();
                                CNP_TB.Clear();
                                this.clientAccountTableAdapter.Fill(this.bank_dbDataSet1.ClientAccount);

                            }
                            catch
                            {
                                MessageBox.Show("Adaugarea a esuat-------!");
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Adaugarea a esuat!");
                        }

                    }
                    catch
                    {

                    }
                }
            }
        }

        private void button_delete_account_Click(object sender, EventArgs e)
        {
            int client_id = int.Parse(dataGridView_accounts.CurrentRow.Cells[0].Value.ToString());
            ConfirmForm confirmForm = new ConfirmForm("Doriti sa stergeti detaliile acestui client?");
            confirmForm.ShowDialog();
            if (ConfirmForm.option == 1)
            {
                using (var db = new Bank_dbEntities())
                {

                    try
                    {
                        var client = (from c in db.ClientAccount
                                      where c.client_id == client_id
                                      select c).First();
                        db.ClientAccount.Remove(client);
                        db.SaveChanges();
                        dataGridView_accounts.Rows.RemoveAt(this.dataGridView_accounts.CurrentCell.RowIndex);
                        MessageBox.Show("Stergere reusita!");
                        this.clientAccountTableAdapter.Fill(this.bank_dbDataSet1.ClientAccount);

                    }
                    catch
                    {
                        MessageBox.Show("Stergerea a esuat!");
                    }
                }
            }
        }

        private void button_update_account_Click(object sender, EventArgs e)
        {
            int client_id = int.Parse(dataGridView_accounts.CurrentRow.Cells[0].Value.ToString());
            if (!isFieldEmpty())
            {
                if (isCnpValid(CNP_TB.Text))
                {
                    if (isEmailValid(textBox_email.Text))
                    {
                        if (validNames(textBox_first_name.Text, textBox_last_name.Text))
                        {
                            using (var db = new Bank_dbEntities())
                            {
                                var client = (from c in db.ClientAccount
                                              where c.client_id == client_id
                                              select c).First();
                                if (char.IsDigit(textBox_phone_number.Text, 0))
                                {
                                    if (char.IsDigit(textBox_age.Text, 0))
                                    {
                                        this.clientAccountTableAdapter.Update(textBox_first_name.Text, textBox_last_name.Text, int.Parse(textBox_age.Text)
                                                    , textBox_country.Text, textBox_phone_number.Text, textBox_email.Text, dateTimePicker_birthday.Value
                                                    , int.Parse(textBox_log_in_id.Text), CNP_TB.Text, client.client_id, client.first_name, client.last_name, client.age
                                                    , client.country, client.phone_number, client.email, client.birthday, client.login_id, client.CNP
                                                     );

                                        MessageBox.Show("Modificare reusita!");
                                        this.clientAccountTableAdapter.Fill(this.bank_dbDataSet1.ClientAccount);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Varsta invalida!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Numarul de telefon invalid!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Numele nu pot contine numere!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email invalid!");
                    }
                }
                else
                {
                    MessageBox.Show("CNP invalid!");
                }
            }
            else
            {
                MessageBox.Show("Some field is empty!");
            }
        }



        private void dataGridView_accounts_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_first_name.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_last_name.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_age.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBox_country.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBox_phone_number.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBox_email.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_log_in_id.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[8].Value.ToString();
                CNP_TB.Text = dataGridView_accounts.Rows[e.RowIndex].Cells[9].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Click in afara ariei de informatie!");
            }
        }

        private void SearchByCnp_BTN_Click(object sender, EventArgs e)
        {
            if (searchclick == 0)
            {
                SCNP_TB.Visible = true;
                CNP_LBL.Visible = true;
                showAll_BTN.Visible = true;
                searchclick++;
            }
            else
            {
                string CNP = SCNP_TB.Text;
                DataSet ds = new DataSet();
                using (var db = new Bank_dbEntities())
                {
                    using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                    {

                        SqlCommand command = new SqlCommand("SELECT * FROM ClientAccount " +
                                                             "WHERE CNP = @CNP", con);
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.SelectCommand.Parameters.AddWithValue("@CNP", CNP);
                        adapter.Fill(ds);
                        dataGridView_accounts.DataSource = ds.Tables[0];
                        SCNP_TB.Text = "";
                        con.Close();
                    }

                }
                SCNP_TB.Clear();
            }
        }

        private void showAll_BTN_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (var db = new Bank_dbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM ClientAccount ", con);
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    dataGridView_accounts.DataSource = ds.Tables[0];
                    con.Close();
                }

            }
        }

        private void dataGridView_accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Boolean isFieldEmpty()
        {
            if (String.IsNullOrEmpty(textBox_first_name.Text) || String.IsNullOrEmpty(textBox_last_name.Text) || String.IsNullOrEmpty(textBox_age.Text)
                || String.IsNullOrEmpty(textBox_country.Text) || String.IsNullOrEmpty(CNP_TB.Text) || String.IsNullOrEmpty(textBox_phone_number.Text)
                || String.IsNullOrEmpty(textBox_email.Text) || String.IsNullOrEmpty(textBox_log_in_id.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public Boolean isCnpValid(string CNP)
        {
            if(CNP.Length != 13)
            {
                return false;
            }
            for(int i = 0; i < CNP.Length; i++)
            {
                if (char.IsLetter(CNP[i]))
                {
                    return false;
                }
            }
            if (!"1256".Contains(CNP[0]))
            {
                return false;
            }
            return true;
        }

        public Boolean isEmailValid(string email)
        {
            if (email.Contains("@"))
                return true;
            else
                return false;
        }

        public Boolean validNames(string firstName, string lastName)
        {
            for(int i = 0; i < firstName.Length; i++)
            {
                if (char.IsDigit(firstName[i]))
                    return false;
            }
            for (int i = 0; i < lastName.Length; i++)
            {
                if (char.IsDigit(lastName[i])){
                    return false;
                }
            }
            return true;
        }
    }

}
