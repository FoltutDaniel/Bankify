using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankify
{
    public partial class Form_Admin_Add_Funds : Form
    {
       
        public Form_Admin_Add_Funds()
        {
            InitializeComponent();
            CenterToScreen();
            
        }
      
        private void Form_Admin_Add_Funds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bank_dbDataSet3.BankAccount' table. You can move, or remove it, as needed.
            this.bankAccountTableAdapter.Fill(this.bank_dbDataSet3.BankAccount);
        }



        private void groupBox_search_by_cnp_Enter(object sender, EventArgs e)
        {

        }

        private void button_search_by_name_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (var db = new Bank_dbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM BankAccount " +
                                                             "WHERE client_id IN (SELECT client_id FROM ClientAccount " +
                                                                               "WHERE last_name=@lastName AND first_name=@firstName)", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.SelectCommand.Parameters.AddWithValue("@lastName", textBox_second_name.Text);
                    adapter.SelectCommand.Parameters.AddWithValue("@firstName", textBox_first_name.Text);
                    adapter.Fill(ds);
                    con.Close();
                    textBox_first_name.Clear();
                    textBox_second_name.Clear();
                }
                dataGridView_Add_Funds.DataSource = ds.Tables[0];
            }
        }

        private void button_search_by_cnp_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (var db = new Bank_dbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM BankAccount " +
                                                             "WHERE client_id IN (SELECT client_id FROM ClientAccount " +
                                                                               "WHERE CNP=@cnp)", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.SelectCommand.Parameters.AddWithValue("@cnp", textBox_cnp.Text);
                    adapter.Fill(ds);
                    con.Close();
                    textBox_cnp.Clear();
                }
                dataGridView_Add_Funds.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView_Add_Funds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
        }

        private void dataGridView_Add_Funds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_old_balance.Text = dataGridView_Add_Funds.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Click in afara ariei de informatie!");
            }
        }

        private void button_add_funds_Click(object sender, EventArgs e)
        {
            int bankAccount_id = int.Parse(dataGridView_Add_Funds.CurrentRow.Cells[0].Value.ToString());
            using (var db = new Bank_dbEntities())
            {
                var bankAccount = (from c in db.BankAccount
                                     where c.account_id == bankAccount_id
                                     select c).First();
                try
                {
                    int current_balance = int.Parse(textBox_amount_to_add.Text) + int.Parse(dataGridView_Add_Funds.CurrentRow.Cells[3].Value.ToString());
                    this.bankAccountTableAdapter.Update(dataGridView_Add_Funds.CurrentRow.Cells[1].Value.ToString(),dataGridView_Add_Funds.CurrentRow.Cells[2].Value.ToString(), current_balance, int.Parse(dataGridView_Add_Funds.CurrentRow.Cells[4].Value.ToString()),
                        bankAccount.account_id, bankAccount.iban, bankAccount.currency, bankAccount.amount, bankAccount.client_id);
                    db.SaveChanges();
                    MessageBox.Show("Modificare reusita!");
                    this.bankAccountTableAdapter.Fill(this.bank_dbDataSet3.BankAccount);
                }
                catch
                {
                    MessageBox.Show("Modificare esuata!");
                }
                

            }
        }

        private void textBox_amount_to_add_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_amount_to_add.Text)) { 
                    int current_balance = int.Parse(textBox_amount_to_add.Text) + int.Parse(dataGridView_Add_Funds.CurrentRow.Cells[3].Value.ToString());
                    textBox_new_balance.Text = current_balance.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Introduceti doar numere!");
                textBox_amount_to_add.Clear();
                textBox_new_balance.Clear();
            }
        }
    }
}
