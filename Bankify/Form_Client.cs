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
    public partial class Form_Client : Form
    {
        private int login_id;
        public Form_Client(int login_id)
        {
            InitializeComponent();
            this.login_id = login_id;
            prepopulate();
        }

        private void Form_Client_Load(object sender, EventArgs e)
        {
            dataGridView_Client.DataSource = GetData().Tables[0];
        }

        public void prepopulate()
        {
            using (var db = new Bank_dbEntities())
            {
                try
                {
                    var query1 = (from b in db.ClientAccount
                                  where b.login_id == login_id
                                  select b).First();

                    this.greetingLabel.Text = "Hello " + query1.first_name + " " + query1.last_name;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("No account");
                }
            }
        }

        public DataSet GetData()
        {
            DataSet ds = new DataSet();
            using (var db = new Bank_dbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT iban,currency,amount FROM BankAccount " +
                                                              "WHERE client_id = (SELECT client_id FROM ClientAccount " +
                                                                                "WHERE login_id = @loginID)", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.SelectCommand.Parameters.AddWithValue("@loginID", login_id);
                    adapter.Fill(ds);
                    con.Close();
                }
            }
            return ds;
        }

        private void button_Transfer_Click(object sender, EventArgs e)
        {
            int index = dataGridView_Client.CurrentCell.RowIndex;
            dataGridView_Client.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Client.Rows[index].Selected = true;
            string iban = dataGridView_Client.SelectedRows[0].Cells[0].Value.ToString();
            string currency= dataGridView_Client.SelectedRows[0].Cells[1].Value.ToString();
            DataSet account_id=new DataSet();
            using (var db = new Bank_dbEntities())
            {
                using (SqlConnection con = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT account_id,client_id FROM BankAccount " +
                                                              "WHERE iban=@iban", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.SelectCommand.Parameters.AddWithValue("@iban", iban);
                    adapter.Fill(account_id);
                    con.Close();
                }
            }
            int acc = int.Parse(account_id.Tables[0].Rows[0].ItemArray[0].ToString());
            int client_id = int.Parse(account_id.Tables[0].Rows[0].ItemArray[1].ToString());
            Form_Transfer form_Transfer = new Form_Transfer(iban, currency, acc, client_id,this);
            form_Transfer.Show();
        }

        public DataGridView getDataGridView()
        {
            return dataGridView_Client;
        }

        private void button_ExtrasCont_Click(object sender, EventArgs e)
        {
            int index = dataGridView_Client.CurrentCell.RowIndex;
            dataGridView_Client.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Client.Rows[index].Selected = true;
            string iban = dataGridView_Client.SelectedRows[0].Cells[0].Value.ToString();
            Form_ExtrasCont form_ExtrasCont = new Form_ExtrasCont(iban);
            form_ExtrasCont.Show();
        }

        private void button_transferOut_Click(object sender, EventArgs e)
        {
            button_Transfer_Click(sender,e);
        }
    }
}
