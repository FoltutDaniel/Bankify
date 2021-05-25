namespace Bankify
{
    partial class Form_Admin_ClientData
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
            this.clientAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet = new Bankify.Bank_dbDataSet();
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
            this.clientAccountTableAdapter = new Bankify.Bank_dbDataSetTableAdapters.ClientAccountTableAdapter();
            this.CNP_TB = new System.Windows.Forms.TextBox();
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
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientAccountBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet1 = new Bankify.Bank_dbDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.bank_dbDataSet4 = new Bankify.Bank_dbDataSet4();
            this.clientAccountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientAccountTableAdapter1 = new Bankify.Bank_dbDataSet4TableAdapters.ClientAccountTableAdapter();
            this.CNP_LBL = new System.Windows.Forms.Label();
            this.SearchByCnp_BTN = new System.Windows.Forms.Button();
            this.SCNP_TB = new System.Windows.Forms.TextBox();
            this.showAll_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Birthday:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Login ID:";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_first_name.Location = new System.Drawing.Point(139, 19);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(100, 24);
            this.textBox_first_name.TabIndex = 9;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_last_name.Location = new System.Drawing.Point(139, 56);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(100, 24);
            this.textBox_last_name.TabIndex = 10;
            // 
            // textBox_age
            // 
            this.textBox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_age.Location = new System.Drawing.Point(139, 92);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(100, 24);
            this.textBox_age.TabIndex = 11;
            // 
            // textBox_country
            // 
            this.textBox_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_country.Location = new System.Drawing.Point(139, 131);
            this.textBox_country.Name = "textBox_country";
            this.textBox_country.Size = new System.Drawing.Size(100, 24);
            this.textBox_country.TabIndex = 12;
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone_number.Location = new System.Drawing.Point(139, 222);
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(100, 24);
            this.textBox_phone_number.TabIndex = 13;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(139, 262);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 24);
            this.textBox_email.TabIndex = 14;
            // 
            // textBox_log_in_id
            // 
            this.textBox_log_in_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_log_in_id.Location = new System.Drawing.Point(139, 340);
            this.textBox_log_in_id.Name = "textBox_log_in_id";
            this.textBox_log_in_id.Size = new System.Drawing.Size(100, 24);
            this.textBox_log_in_id.TabIndex = 16;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(139, 299);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker_birthday.TabIndex = 17;
            // 
            // button_add_account
            // 
            this.button_add_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_account.Location = new System.Drawing.Point(12, 428);
            this.button_add_account.Name = "button_add_account";
            this.button_add_account.Size = new System.Drawing.Size(130, 50);
            this.button_add_account.TabIndex = 18;
            this.button_add_account.Text = "Add Client Account";
            this.button_add_account.UseVisualStyleBackColor = true;
            this.button_add_account.Click += new System.EventHandler(this.button_add_account_Click);
            // 
            // button_update_account
            // 
            this.button_update_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update_account.Location = new System.Drawing.Point(148, 429);
            this.button_update_account.Name = "button_update_account";
            this.button_update_account.Size = new System.Drawing.Size(130, 50);
            this.button_update_account.TabIndex = 19;
            this.button_update_account.Text = "Update Client Account";
            this.button_update_account.UseVisualStyleBackColor = true;
            this.button_update_account.Click += new System.EventHandler(this.button_update_account_Click);
            // 
            // button_delete_account
            // 
            this.button_delete_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_account.Location = new System.Drawing.Point(284, 429);
            this.button_delete_account.Name = "button_delete_account";
            this.button_delete_account.Size = new System.Drawing.Size(130, 50);
            this.button_delete_account.TabIndex = 20;
            this.button_delete_account.Text = "Delete Client Account";
            this.button_delete_account.UseVisualStyleBackColor = true;
            this.button_delete_account.Click += new System.EventHandler(this.button_delete_account_Click);
            // 
            // clientAccountTableAdapter
            // 
            this.clientAccountTableAdapter.ClearBeforeFill = true;
            // 
            // CNP_TB
            // 
            this.CNP_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNP_TB.Location = new System.Drawing.Point(139, 177);
            this.CNP_TB.Name = "CNP_TB";
            this.CNP_TB.Size = new System.Drawing.Size(100, 24);
            this.CNP_TB.TabIndex = 21;
            // 
            // dataGridView_accounts
            // 
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
            this.loginidDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn});
            this.dataGridView_accounts.DataSource = this.clientAccountBindingSource2;
            this.dataGridView_accounts.Location = new System.Drawing.Point(351, 15);
            this.dataGridView_accounts.Name = "dataGridView_accounts";
            this.dataGridView_accounts.Size = new System.Drawing.Size(1044, 310);
            this.dataGridView_accounts.TabIndex = 22;
            this.dataGridView_accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_accounts_CellClick_1);
            this.dataGridView_accounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_accounts_CellContentClick);
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
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            // 
            // clientAccountBindingSource2
            // 
            this.clientAccountBindingSource2.DataMember = "ClientAccount";
            this.clientAccountBindingSource2.DataSource = this.bank_dbDataSet1;
            // 
            // bank_dbDataSet1
            // 
            this.bank_dbDataSet1.DataSetName = "Bank_dbDataSet";
            this.bank_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "CNP:";
            // 
            // bank_dbDataSet4
            // 
            this.bank_dbDataSet4.DataSetName = "Bank_dbDataSet4";
            this.bank_dbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientAccountBindingSource1
            // 
            this.clientAccountBindingSource1.DataMember = "ClientAccount";
            this.clientAccountBindingSource1.DataSource = this.bank_dbDataSet4;
            // 
            // clientAccountTableAdapter1
            // 
            this.clientAccountTableAdapter1.ClearBeforeFill = true;
            // 
            // CNP_LBL
            // 
            this.CNP_LBL.AutoSize = true;
            this.CNP_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNP_LBL.Location = new System.Drawing.Point(556, 445);
            this.CNP_LBL.Name = "CNP_LBL";
            this.CNP_LBL.Size = new System.Drawing.Size(40, 18);
            this.CNP_LBL.TabIndex = 24;
            this.CNP_LBL.Text = "CNP";
            // 
            // SearchByCnp_BTN
            // 
            this.SearchByCnp_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByCnp_BTN.Location = new System.Drawing.Point(420, 429);
            this.SearchByCnp_BTN.Name = "SearchByCnp_BTN";
            this.SearchByCnp_BTN.Size = new System.Drawing.Size(130, 50);
            this.SearchByCnp_BTN.TabIndex = 25;
            this.SearchByCnp_BTN.Text = "Search by CNP";
            this.SearchByCnp_BTN.UseVisualStyleBackColor = true;
            this.SearchByCnp_BTN.Click += new System.EventHandler(this.SearchByCnp_BTN_Click);
            // 
            // SCNP_TB
            // 
            this.SCNP_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCNP_TB.Location = new System.Drawing.Point(602, 441);
            this.SCNP_TB.Name = "SCNP_TB";
            this.SCNP_TB.Size = new System.Drawing.Size(100, 24);
            this.SCNP_TB.TabIndex = 26;
            // 
            // showAll_BTN
            // 
            this.showAll_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_BTN.Location = new System.Drawing.Point(708, 429);
            this.showAll_BTN.Name = "showAll_BTN";
            this.showAll_BTN.Size = new System.Drawing.Size(130, 50);
            this.showAll_BTN.TabIndex = 27;
            this.showAll_BTN.Text = "Show All Entries";
            this.showAll_BTN.UseVisualStyleBackColor = true;
            this.showAll_BTN.Click += new System.EventHandler(this.showAll_BTN_Click);
            // 
            // Form_Admin_ClientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 516);
            this.Controls.Add(this.showAll_BTN);
            this.Controls.Add(this.SCNP_TB);
            this.Controls.Add(this.SearchByCnp_BTN);
            this.Controls.Add(this.CNP_LBL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView_accounts);
            this.Controls.Add(this.CNP_TB);
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
            this.Name = "Form_Admin_ClientData";
            this.Text = "Client Data";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_accounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientAccountBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bank_dbDataSet bank_dbDataSet;
        private System.Windows.Forms.BindingSource clientAccountBindingSource;
        private Bank_dbDataSetTableAdapters.ClientAccountTableAdapter clientAccountTableAdapter;
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
        private System.Windows.Forms.TextBox CNP_TB;
        private Bank_dbDataSet4 bank_dbDataSet4;
        private System.Windows.Forms.BindingSource clientAccountBindingSource1;
        private Bank_dbDataSet4TableAdapters.ClientAccountTableAdapter clientAccountTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView_accounts;
        private Bank_dbDataSet bank_dbDataSet1;
        private System.Windows.Forms.BindingSource clientAccountBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CNP_LBL;
        private System.Windows.Forms.Button SearchByCnp_BTN;
        private System.Windows.Forms.TextBox SCNP_TB;
        private System.Windows.Forms.Button showAll_BTN;
    }
}