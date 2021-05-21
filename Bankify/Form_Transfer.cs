using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankify
{
    public partial class Form_Transfer : Form
    {
        int fromAccount_id;
        int client_id;
        Form_Client form_Client;
        double toAmount = 0;

        public Form_Transfer(string iban, string currency, int acc, int cl_id, Form_Client form)
        {
            InitializeComponent();
            CenterToScreen();
            textBox_FromIban.Text = iban;
            textBox_Currency.Text = currency;
            fromAccount_id = acc;
            client_id = cl_id;
            form_Client = form;
        }

        private void button_FinishTransf_Click(object sender, EventArgs e)
        {
            bool enoughAmount = true;
            bool sameCurrency = true;
            string fromCurrency="";
            string toCurrency="";
            double fromAmount=0;
            Tranzaction tranzaction = new Tranzaction();
            tranzaction.from_iban = textBox_FromIban.Text;
            tranzaction.to_iban = textBox_ToIban.Text;
            int toAccount_id=0;
            try
            {
                tranzaction.amount = double.Parse(textBox_Amount.Text);
                tranzaction.currency = textBox_Currency.Text;
                tranzaction.transaction_date = DateTime.Now;
                tranzaction.bank_account_from_id = fromAccount_id;
                using (var db = new Bank_dbEntities())
                {
                    var query = from b in db.BankAccount
                                where b.client_id == client_id
                                select b;
                    var query1 = (from b in query
                                  where b.iban == tranzaction.to_iban
                                  select b).First();
                    toAmount = query1.amount;
                    toAccount_id = query1.account_id;
                    toCurrency = query1.currency;
                    var query2 = (from b in query
                                  where b.iban == tranzaction.from_iban
                                  select b).First();
                    fromAmount = query2.amount;
                    fromCurrency = query2.currency;
                    if (fromAmount < tranzaction.amount)
                    {
                        enoughAmount = false;
                        throw new InvalidOperationException();
                    }
                    if (fromCurrency != toCurrency)
                    {
                        sameCurrency = false;
                        throw new InvalidOperationException();
                    }
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
            } catch (FormatException ex)
            {
                MessageBox.Show("Amount value is NOT correct!");
            } catch (InvalidOperationException ex)
            {
                if (enoughAmount && sameCurrency)
                {
                    MessageBox.Show("To_iban value does NOT exists in database! (To_iban value is unregistered)");
                }
                else
                {
                    if (sameCurrency)
                    {
                        MessageBox.Show("Transfer amount is greater than your current amount! (You do NOT have enough resources!)");
                    }
                    else
                    {
                        Form_Convert form_Convert = new Form_Convert(fromCurrency,toCurrency,this,tranzaction,fromAmount,toAmount,fromAccount_id,toAccount_id,form_Client);
                        form_Convert.Show();
                    }
                }
            } 
        }

        private void button_finishTransferOut_Click(object sender, EventArgs e)
        {
            bool enoughAmount = true;
            Tranzaction tranzaction = new Tranzaction();
            tranzaction.from_iban = textBox_FromIban.Text;
            tranzaction.to_iban = textBox_ToIban.Text;
            try
            {
                tranzaction.amount = double.Parse(textBox_Amount.Text);
                tranzaction.currency = textBox_Currency.Text;
                tranzaction.transaction_date = DateTime.Now;
                tranzaction.bank_account_from_id = fromAccount_id;
                using (var db = new Bank_dbEntities())
                {
                    using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                    {
                        var query = (from b in db.BankAccount
                                     where b.iban == tranzaction.to_iban
                                     select b).First();
                        var query1 = (from b in db.BankAccount
                                      where b.iban == tranzaction.from_iban
                                      select b).First();
                        int toAccount_id = query.account_id;
                        double fromAmount = query1.amount;
                        if (fromAmount < tranzaction.amount)
                        {
                            enoughAmount = false;
                            throw new InvalidOperationException();
                        }
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
            catch (FormatException ex)
            {
                MessageBox.Show("Amount value is NOT correct!");
            }
            catch (InvalidOperationException ex)
            {
                if (enoughAmount)
                {
                    MessageBox.Show("To_iban value does NOT exists in database! (To_iban value is unregistered)");
                }
                else
                {
                    MessageBox.Show("Transfer amount is greater than your current amount! (You do NOT have enough resources!)");
                }
            }
        }
        public void setToAmount(double amount)
        {
            toAmount = amount;
        }

        public double getToAmount()
        {
            return toAmount;
        }

        private void Form_Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}
