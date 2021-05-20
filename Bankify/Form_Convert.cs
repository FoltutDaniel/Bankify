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
    public partial class Form_Convert : Form
    {
        string fromCurrency;
        string toCurrency;
        double exchangeRate;
        double fromAmount;
        double toAmount;
        Form_Transfer form_Transfer;
        Form_Client form_Client;
        Tranzaction tranzaction;
        int fromAccount_id;
        int toAccount_id;
        public Form_Convert(string fromC, string toC, Form_Transfer form, Tranzaction tran, double fromA, double toA, int fromAcc, int toAcc, Form_Client formC)
        {
            InitializeComponent();
            fromCurrency = fromC;
            toCurrency = toC;
            form_Transfer = form;
            tranzaction = tran;
            fromAmount = fromA;
            toAmount = toA;
            fromAccount_id = fromAcc;
            toAccount_id = toAcc;
            form_Client = formC;
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Yes_Click(object sender, EventArgs e)
        {
           if(fromCurrency.ToLower()!="eur" && toCurrency.ToLower() != "eur")
            {
                exchangeRate = CurrencyConverter.GetExchangeRate(fromCurrency, toCurrency);
                form_Transfer.setToAmount(tranzaction.amount * exchangeRate);
            }
            else
            {
                if (fromCurrency.ToLower() == "eur")
                {
                    exchangeRate = CurrencyConverter.GetCurrencyRateInEuro(toCurrency);
                    form_Transfer.setToAmount(tranzaction.amount * exchangeRate);
                }
                else
                {
                    if (toCurrency.ToLower() == "eur")
                    {
                        exchangeRate = CurrencyConverter.GetCurrencyRateInEuro(fromCurrency);
                        form_Transfer.setToAmount(tranzaction.amount / exchangeRate);
                    }
                }
            }
            using (var db = new Bank_dbEntities())
            {
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
                    command.Parameters.AddWithValue("@amount", toAmount + form_Transfer.getToAmount());
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

        public double getExchangeRate()
        {
            return exchangeRate;
        }
    }
}
