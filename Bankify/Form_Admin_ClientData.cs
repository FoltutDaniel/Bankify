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
    public partial class Form_Admin_ClientData : Form
    {
       
        public Form_Admin_ClientData()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            this.clientAccountTableAdapter.Fill(this.bank_dbDataSet.ClientAccount);

        }

        private void button_add_account_Click(object sender, EventArgs e)
        {
            ClientAccount clientAccount = new ClientAccount();

            using (var db = new Bank_dbEntities())
            {
                try
                {
                    try
                    {
                        clientAccount.first_name = textBox_first_name.Text;
                        clientAccount.last_name = textBox_last_name.Text;
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
                            this.clientAccountTableAdapter.Fill(this.bank_dbDataSet.ClientAccount);

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

        private void button_delete_account_Click(object sender, EventArgs e)
        {
            int client_id = int.Parse(dataGridView_accounts.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show(client_id + " ");
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
                }
                catch
                {
                    MessageBox.Show("Stergerea a esuat!");
                }
           }
        }

        private void button_update_account_Click(object sender, EventArgs e)
        {
            int client_id = int.Parse(dataGridView_accounts.CurrentRow.Cells[0].Value.ToString());
            using (var db = new Bank_dbEntities())
            {
                var client = (from c in db.ClientAccount
                              where c.client_id == client_id
                              select c).First();
                if (char.IsDigit(textBox_phone_number.Text, 0))
                {
                    if(char.IsDigit(textBox_age.Text, 0))
                    {
                        this.clientAccountTableAdapter.Update(textBox_first_name.Text, textBox_last_name.Text, int.Parse(textBox_age.Text)
                                    , textBox_country.Text, textBox_phone_number.Text, textBox_email.Text, dateTimePicker_birthday.Value
                                    , int.Parse(textBox_log_in_id.Text), client.client_id, client.first_name, client.last_name, client.age
                                    , client.country, client.phone_number, client.email, client.birthday, client.login_id
                                     );
                        this.clientAccountTableAdapter.Fill(this.bank_dbDataSet.ClientAccount);
                        MessageBox.Show("Modificare reusita!");
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

        private void dataGridView_accounts_CellClick(object sender, DataGridViewCellEventArgs e)
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
            }
            catch
            {
                MessageBox.Show("Click in afara ariei de informatie!");
            }
        }
    }
}
