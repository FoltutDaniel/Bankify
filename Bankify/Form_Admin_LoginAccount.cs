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
    public partial class Form_Admin_LoginAccount : Form
    {
        public Form_Admin_LoginAccount()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Form_Admin_LoginAccount_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_dbDataSet2.LoginAccount' table. You can move, or remove it, as needed.
            this.loginAccountTableAdapter.Fill(this.bank_dbDataSet2.LoginAccount);
            accountype_CB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddLA_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username_TB.Text) || String.IsNullOrWhiteSpace(password_Tb.Text))
            {
                MessageBox.Show("Username sau Parola invalida");
            }
            else
            {
                LoginAccount loginAccount = new LoginAccount();
                using (var db = new Bank_dbEntities())
                {
                    try
                    {
                        try
                        {
                            loginAccount.login_username = username_TB.Text;
                            loginAccount.login_password = password_Tb.Text;
                            loginAccount.account_type = accountype_CB.Text;
                            try
                            {
                                db.LoginAccount.Add(loginAccount);
                                db.SaveChanges();
                                MessageBox.Show("Adaugare reusita!");

                                this.loginAccountTableAdapter.Fill(this.bank_dbDataSet2.LoginAccount);

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

        private void editLA_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username_TB.Text) || String.IsNullOrWhiteSpace(password_Tb.Text))
            {
                MessageBox.Show("Username sau Parola invalida");
            }
            else
            {
                try
                {
                    int login_account_id = int.Parse(dataGridView_LA.CurrentRow.Cells[0].Value.ToString());
                    using (var db = new Bank_dbEntities())
                    {
                        var login_account = (from c in db.LoginAccount
                                             where c.login_id == login_account_id
                                             select c).First();
                        this.loginAccountTableAdapter.Update(username_TB.Text, password_Tb.Text, accountype_CB.Text, login_account.login_id,
                            login_account.login_username, login_account.login_password, login_account.account_type);
                        db.SaveChanges();
                        MessageBox.Show("Modificare reusita!");
                        this.loginAccountTableAdapter.Fill(this.bank_dbDataSet2.LoginAccount);
                    }
                }
                catch (InvalidOperationException ex1)
                {
                    MessageBox.Show("Date introduse gresit!");
                }
            }
        }

        private void dataGridView_LA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                username_TB.Text = dataGridView_LA.Rows[e.RowIndex].Cells[1].Value.ToString();
                password_Tb.Text = dataGridView_LA.Rows[e.RowIndex].Cells[2].Value.ToString();
                accountype_CB.Text = dataGridView_LA.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Click in afara ariei de informatie!");
            }
        }

        private void deleteLA_Click(object sender, EventArgs e)
        {
            int loginaccount_id = int.Parse(dataGridView_LA.CurrentRow.Cells[0].Value.ToString());
            ConfirmForm confirmForm = new ConfirmForm("Doriti sa stergeti acest login account?");
            confirmForm.ShowDialog();
            if (ConfirmForm.option == 1)
            {
                using (var db = new Bank_dbEntities())
                {

                    try
                    {
                        var loginAccount = (from c in db.LoginAccount
                                            where c.login_id == loginaccount_id
                                            select c).First();
                        db.LoginAccount.Remove(loginAccount);
                        db.SaveChanges();
                        dataGridView_LA.Rows.RemoveAt(this.dataGridView_LA.CurrentCell.RowIndex);
                        MessageBox.Show("Stergere reusita!");
                        this.loginAccountTableAdapter.Fill(this.bank_dbDataSet2.LoginAccount);

                    }
                    catch
                    {
                        MessageBox.Show("Stergerea a esuat!");
                    }
                }
            }
        }
    }
}
