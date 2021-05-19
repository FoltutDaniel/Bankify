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
    public partial class Form_Admin_BankAccount : Form
    {
        public Form_Admin_BankAccount()
        {
            InitializeComponent();
        }

        private void Form_Admin_BankAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_dbDataSet3.BankAccount' table. You can move, or remove it, as needed.
            this.bankAccountTableAdapter.Fill(this.bank_dbDataSet3.BankAccount);

        }

        private void addBA_BTN_Click(object sender, EventArgs e)
        {
            BankAccount bankAccount = new BankAccount();

            using (var db = new Bank_dbEntities())
            {
                try
                {
                    try
                    {
                        bankAccount.iban = iban_TB.Text;
                        bankAccount.currency = currency_CB.Text;
                        
                        if(char.IsDigit(ammount_TB.Text, 0))
                        {
                            if (int.Parse(ammount_TB.Text) > 0)
                            {
                                bankAccount.amount = int.Parse(ammount_TB.Text);
                            }
                            else
                            {
                                MessageBox.Show("Valoare gresita!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Valoare gresita!");
                        }

                        if(char.IsDigit(clientID_TB.Text, 0))
                        {
                            bankAccount.client_id = int.Parse(clientID_TB.Text);
                        }
                        else
                        {
                            MessageBox.Show("Client ID gresit");
                        }
                        try
                        {
                            db.BankAccount.Add(bankAccount);
                            db.SaveChanges();
                            MessageBox.Show("Adaugare reusita!");
                            iban_TB.Clear();
                            ammount_TB.Clear();
                            clientID_TB.Clear();
                            this.bankAccountTableAdapter.Fill(this.bank_dbDataSet3.BankAccount);

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

        private void deleteBA_BTN_Click(object sender, EventArgs e)
        {
            int bankaccount_id = int.Parse(dataGrid_BA.CurrentRow.Cells[0].Value.ToString());
            using (var db = new Bank_dbEntities())
            {

                try
                {
                    var bankAccount = (from c in db.BankAccount
                                        where c.account_id == bankaccount_id
                                        select c).First();
                    db.BankAccount.Remove(bankAccount);
                    db.SaveChanges();
                    dataGrid_BA.Rows.RemoveAt(this.dataGrid_BA.CurrentCell.RowIndex);
                    MessageBox.Show("Stergere reusita!");
                }
                catch
                {
                    MessageBox.Show("Stergerea a esuat!");
                }
            }
        }

        private void editBA_BTN_Click(object sender, EventArgs e)
        {
            int bankAccount_id = int.Parse(dataGrid_BA.CurrentRow.Cells[0].Value.ToString());
            using (var db = new Bank_dbEntities())
            {
                var bankAccount = (from c in db.BankAccount
                                     where c.account_id == bankAccount_id
                                     select c).First();
                try
                {
                    this.bankAccountTableAdapter.Update(iban_TB.Text, currency_CB.Text, int.Parse(ammount_TB.Text), int.Parse(clientID_TB.Text),
                        bankAccount.account_id, bankAccount.iban, bankAccount.currency, bankAccount.amount, bankAccount.client_id);
                    MessageBox.Show("Modificare reusita!");
                }
                catch
                {
                    MessageBox.Show("Modificare esuata!");
                }

            }
        }

        

        private void dataGrid_BA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                iban_TB.Text = dataGrid_BA.Rows[e.RowIndex].Cells[1].Value.ToString();
                currency_CB.Text = dataGrid_BA.Rows[e.RowIndex].Cells[2].Value.ToString();
                ammount_TB.Text = dataGrid_BA.Rows[e.RowIndex].Cells[3].Value.ToString();
                clientID_TB.Text = dataGrid_BA.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Click in afara ariei de informatie!");
            }
        }
    }
}
