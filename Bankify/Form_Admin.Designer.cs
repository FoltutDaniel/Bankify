namespace Bankify
{
    partial class Form_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView_accounts = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet = new Bankify.Bank_dbDataSet();
            this.clientAccountTableAdapter = new Bankify.Bank_dbDataSetTableAdapters.ClientAccountTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_country = new System.Windows.Forms.TextBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_log_in_id = new System.Windows.Forms.TextBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.button_add_account = new System.Windows.Forms.Button();
            this.button_update_account = new System.Windows.Forms.Button();
            this.button_delete_account = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_accounts
            // 
            this.dataGridView_accounts.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView_accounts.AllowUserToAddRows = false;
            this.dataGridView_accounts.AllowUserToDeleteRows = false;
            this.dataGridView_accounts.AllowUserToResizeColumns = false;
            this.dataGridView_accounts.AllowUserToResizeRows = false;
            this.dataGridView_accounts.AutoGenerateColumns = false;
            this.dataGridView_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.loginidDataGridViewTextBoxColumn});
            this.dataGridView_accounts.DataSource = this.clientAccountBindingSource;
            this.dataGridView_accounts.Location = new System.Drawing.Point(372, 12);
            this.dataGridView_accounts.Name = "dataGridView_accounts";
            this.dataGridView_accounts.ReadOnly = true;
            this.dataGridView_accounts.Size = new System.Drawing.Size(944, 415);
            this.dataGridView_accounts.TabIndex = 0;
            this.dataGridView_accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_accounts_CellClick);
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number";
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // loginidDataGridViewTextBoxColumn
            // 
            this.loginidDataGridViewTextBoxColumn.DataPropertyName = "login_id";
            this.loginidDataGridViewTextBoxColumn.HeaderText = "login_id";
            this.loginidDataGridViewTextBoxColumn.Name = "loginidDataGridViewTextBoxColumn";
            // 
            // clientAccountBindingSource
            // 
            this.clientAccountBindingSource.DataMember = "ClientAccount";
            this.clientAccountBindingSource.DataSource = this.bank_dbDataSet;
            // 
            // bank_dbDataSet
            // 
            this.bank_dbDataSet.DataSetName = "Bank_dbDataSet";
            this.bank_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientAccountTableAdapter
            // 
            this.clientAccountTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Log in ID";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(145, 15);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_first_name.TabIndex = 9;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(145, 52);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_last_name.TabIndex = 10;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(145, 88);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(100, 20);
            this.textBox_age.TabIndex = 11;
            // 
            // textBox_country
            // 
            this.textBox_country.Location = new System.Drawing.Point(145, 131);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(100, 20);
            this.textBox_country.TabIndex = 12;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Location = new System.Drawing.Point(145, 174);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(100, 20);
            this.textBox_phone_number.TabIndex = 13;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(145, 211);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 14;
            // 
            // textBox_log_in_id
            // 
            this.textBox_log_in_id.Location = new System.Drawing.Point(145, 297);
            this.textBox_log_in_id.Name = "textBox_log_in_id";
            this.textBox_log_in_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_log_in_id.TabIndex = 16;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(145, 255);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_birthday.TabIndex = 17;
            // 
            // button_add_account
            // 
            this.button_add_account.Location = new System.Drawing.Point(12, 374);
            this.button_add_account.Name = "button_add_account";
            this.button_add_account.Size = new System.Drawing.Size(100, 30);
            this.button_add_account.TabIndex = 18;
            this.button_add_account.Text = "Add ";
            this.button_add_account.UseVisualStyleBackColor = true;
            this.button_add_account.Click += new System.EventHandler(this.button_add_account_Click);
            // 
            // button_update_account
            // 
            this.button_update_account.Location = new System.Drawing.Point(136, 374);
            this.button_update_account.Name = "button_update_account";
            this.button_update_account.Size = new System.Drawing.Size(100, 30);
            this.button_update_account.TabIndex = 19;
            this.button_update_account.Text = "Update";
            this.button_update_account.UseVisualStyleBackColor = true;
            this.button_update_account.Click += new System.EventHandler(this.button_update_account_Click);
            // 
            // button_delete_account
            // 
            this.button_delete_account.Location = new System.Drawing.Point(266, 374);
            this.button_delete_account.Name = "button_delete_account";
            this.button_delete_account.Size = new System.Drawing.Size(100, 30);
            this.button_delete_account.TabIndex = 20;
            this.button_delete_account.Text = "Delete";
            this.button_delete_account.UseVisualStyleBackColor = true;
            this.button_delete_account.Click += new System.EventHandler(this.button_delete_account_Click);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 439);
            this.Controls.Add(this.button_delete_account);
            this.Controls.Add(this.button_update_account);
            this.Controls.Add(this.button_add_account);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.textBox_log_in_id);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_phone_number);
            this.Controls.Add(this.textBox_country);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_accounts);
            this.Name = "Form_Admin";
            this.Text = "Date Client";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_accounts;
        private Bank_dbDataSet bank_dbDataSet;
        private System.Windows.Forms.BindingSource clientAccountBindingSource;
        private Bank_dbDataSetTableAdapters.ClientAccountTableAdapter clientAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_country;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_log_in_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.Button button_add_account;
        private System.Windows.Forms.Button button_update_account;
        private System.Windows.Forms.Button button_delete_account;
    }
}