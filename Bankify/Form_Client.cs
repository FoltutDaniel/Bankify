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
    public partial class Form_Client : Form
    {
        private int login_id;
        public Form_Client(int login_id)
        {
            InitializeComponent();
            this.login_id = login_id;
            prepopulate();
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

       
    }
}
