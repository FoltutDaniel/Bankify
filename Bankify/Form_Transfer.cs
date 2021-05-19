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
    public partial class Form_Transfer : Form
    {
        int fromAccount_id;
        int client_id;
        Form_Client form_Client;
        public Form_Transfer(string iban, string currency, int acc, int cl_id, Form_Client form)
        {
            InitializeComponent();
            textBox_FromIban.Text = iban;
            textBox_Currency.Text = currency;
            fromAccount_id = acc;
            client_id = cl_id;
            form_Client = form;
        }

        private void button_FinishTransf_Click(object sender, EventArgs e)
        {
            Tranzaction tranzaction = new Tranzaction();
            tranzaction.from_iban = textBox_FromIban.Text;
            tranzaction.to_iban = textBox_ToIban.Text;
            tranzaction.amount = double.Parse(textBox_Amount.Text);
            tranzaction.currency = textBox_Currency.Text;
            tranzaction.transaction_date = DateTime.Now;
            tranzaction.bank_account_from_id = fromAccount_id;
            using(var db=new Bank_dbEntities())
            {
                var query = from b in db.BankAccount
                             where b.client_id == client_id
                             select b;
                var query1 = (from b in query
                              where b.iban == tranzaction.to_iban
                              select b).First();
                double toAmount = query1.amount;
                int toAccount_id = query1.account_id;
                var query2= (from b in query
                             where b.iban == tranzaction.from_iban
                             select b).First();
                double fromAmount = query2.amount;
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE BankAccount SET amount = @amount " +
                                                        "WHERE account_id=@account_id", con);
                    command.Parameters.AddWithValue("@amount", fromAmount - tranzaction.amount);
                    command.Parameters.AddWithValue("@account_id", fromAccount_id);
                    command.ExecuteNonQuery();
                    command.Parameters.RemoveAt(0);
                    command.Parameters.RemoveAt(0);
                    command.Parameters.AddWithValue("@amount", toAmount + tranzaction.amount);
                    command.Parameters.AddWithValue("@account_id",toAccount_id);
                    command.ExecuteNonQuery();
                    con.Close();

                }
                db.Tranzaction.Add(tranzaction);
                db.SaveChanges();
                form_Client.getDataGridView().DataSource=form_Client.GetData().Tables[0];
                this.Close();
                MessageBox.Show("Tranzactie reusita!");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tranzaction tranzaction = new Tranzaction();
            tranzaction.from_iban = textBox_FromIban.Text;
            tranzaction.to_iban = textBox_ToIban.Text;
            tranzaction.amount = double.Parse(textBox_Amount.Text);
            tranzaction.currency = textBox_Currency.Text;
            tranzaction.transaction_date = DateTime.Now;
            tranzaction.bank_account_from_id = fromAccount_id;
            using(var db=new Bank_dbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    var query = (from b in db.BankAccount
                                 where b.iban == tranzaction.to_iban
                                 select b).First();
                    var query1= (from b in db.BankAccount
                                 where b.iban == tranzaction.from_iban
                                 select b).First();
                    int toAccount_id = query.account_id;
                    double fromAmount = query1.amount;
                    double toAmount = query.amount;
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE BankAccount SET amount = @amount " +
                                                        "WHERE account_id=@account_id", con);
                    command.Parameters.AddWithValue("@amount", fromAmount - tranzaction.amount);
                    command.Parameters.AddWithValue("@account_id", fromAccount_id);
                    command.ExecuteNonQuery();
                    command.Parameters.RemoveAt(0);
                    command.Parameters.RemoveAt(0);
                    command.Parameters.AddWithValue("@amount", toAmount + tranzaction.amount);
                    command.Parameters.AddWithValue("@account_id", toAccount_id);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                db.Tranzaction.Add(tranzaction);
                db.SaveChanges();
                form_Client.getDataGridView().DataSource = form_Client.GetData().Tables[0];
                this.Close();
                MessageBox.Show("Tranzactie reusita!");
            }
        }
    }
}
