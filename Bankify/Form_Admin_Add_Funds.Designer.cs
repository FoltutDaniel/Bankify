namespace Bankify
{
    partial class Form_Admin_Add_Funds
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
            this.groupBox_search_by_name = new System.Windows.Forms.GroupBox();
            this.button_search_by_name = new System.Windows.Forms.Button();
            this.textBox_second_name = new System.Windows.Forms.TextBox();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_search_by_cnp = new System.Windows.Forms.GroupBox();
            this.button_search_by_cnp = new System.Windows.Forms.Button();
            this.textBox_cnp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Add_Funds = new System.Windows.Forms.DataGridView();
            this.accountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankdbDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet3 = new Bankify.Bank_dbDataSet3();
            this.bankAccountTableAdapter = new Bankify.Bank_dbDataSet3TableAdapters.BankAccountTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_old_balance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_add_funds = new System.Windows.Forms.Button();
            this.textBox_amount_to_add = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_new_balance = new System.Windows.Forms.TextBox();
            this.groupBox_search_by_name.SuspendLayout();
            this.groupBox_search_by_cnp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Add_Funds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_search_by_name
            // 
            this.groupBox_search_by_name.Controls.Add(this.button_search_by_name);
            this.groupBox_search_by_name.Controls.Add(this.textBox_second_name);
            this.groupBox_search_by_name.Controls.Add(this.textBox_first_name);
            this.groupBox_search_by_name.Controls.Add(this.label2);
            this.groupBox_search_by_name.Controls.Add(this.label1);
            this.groupBox_search_by_name.Location = new System.Drawing.Point(13, 13);
            this.groupBox_search_by_name.Name = "groupBox_search_by_name";
            this.groupBox_search_by_name.Size = new System.Drawing.Size(200, 109);
            this.groupBox_search_by_name.TabIndex = 0;
            this.groupBox_search_by_name.TabStop = false;
            this.groupBox_search_by_name.Text = "Search By Name";
            // 
            // button_search_by_name
            // 
            this.button_search_by_name.Location = new System.Drawing.Point(56, 69);
            this.button_search_by_name.Name = "button_search_by_name";
            this.button_search_by_name.Size = new System.Drawing.Size(83, 34);
            this.button_search_by_name.TabIndex = 4;
            this.button_search_by_name.Text = "Search By Name";
            this.button_search_by_name.UseVisualStyleBackColor = true;
            this.button_search_by_name.Click += new System.EventHandler(this.button_search_by_name_Click);
            // 
            // textBox_second_name
            // 
            this.textBox_second_name.Location = new System.Drawing.Point(94, 43);
            this.textBox_second_name.Name = "textBox_second_name";
            this.textBox_second_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_second_name.TabIndex = 3;
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(94, 17);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_first_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // groupBox_search_by_cnp
            // 
            this.groupBox_search_by_cnp.Controls.Add(this.button_search_by_cnp);
            this.groupBox_search_by_cnp.Controls.Add(this.textBox_cnp);
            this.groupBox_search_by_cnp.Controls.Add(this.label3);
            this.groupBox_search_by_cnp.Location = new System.Drawing.Point(12, 138);
            this.groupBox_search_by_cnp.Name = "groupBox_search_by_cnp";
            this.groupBox_search_by_cnp.Size = new System.Drawing.Size(200, 86);
            this.groupBox_search_by_cnp.TabIndex = 1;
            this.groupBox_search_by_cnp.TabStop = false;
            this.groupBox_search_by_cnp.Text = "Search By CNP";
            this.groupBox_search_by_cnp.Enter += new System.EventHandler(this.groupBox_search_by_cnp_Enter);
            // 
            // button_search_by_cnp
            // 
            this.button_search_by_cnp.Location = new System.Drawing.Point(57, 46);
            this.button_search_by_cnp.Name = "button_search_by_cnp";
            this.button_search_by_cnp.Size = new System.Drawing.Size(83, 34);
            this.button_search_by_cnp.TabIndex = 5;
            this.button_search_by_cnp.Text = "Search By CNP";
            this.button_search_by_cnp.UseVisualStyleBackColor = true;
            this.button_search_by_cnp.Click += new System.EventHandler(this.button_search_by_cnp_Click);
            // 
            // textBox_cnp
            // 
            this.textBox_cnp.Location = new System.Drawing.Point(94, 17);
            this.textBox_cnp.Name = "textBox_cnp";
            this.textBox_cnp.Size = new System.Drawing.Size(100, 20);
            this.textBox_cnp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CNP";
            // 
            // dataGridView_Add_Funds
            // 
            this.dataGridView_Add_Funds.AutoGenerateColumns = false;
            this.dataGridView_Add_Funds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Add_Funds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountidDataGridViewTextBoxColumn,
            this.ibanDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn});
            this.dataGridView_Add_Funds.DataSource = this.bankAccountBindingSource;
            this.dataGridView_Add_Funds.Location = new System.Drawing.Point(219, 13);
            this.dataGridView_Add_Funds.Name = "dataGridView_Add_Funds";
            this.dataGridView_Add_Funds.Size = new System.Drawing.Size(545, 212);
            this.dataGridView_Add_Funds.TabIndex = 2;
            this.dataGridView_Add_Funds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Add_Funds_CellClick);
            this.dataGridView_Add_Funds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Add_Funds_CellContentClick);
            // 
            // accountidDataGridViewTextBoxColumn
            // 
            this.accountidDataGridViewTextBoxColumn.DataPropertyName = "account_id";
            this.accountidDataGridViewTextBoxColumn.HeaderText = "account_id";
            this.accountidDataGridViewTextBoxColumn.Name = "accountidDataGridViewTextBoxColumn";
            this.accountidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ibanDataGridViewTextBoxColumn
            // 
            this.ibanDataGridViewTextBoxColumn.DataPropertyName = "iban";
            this.ibanDataGridViewTextBoxColumn.HeaderText = "iban";
            this.ibanDataGridViewTextBoxColumn.Name = "ibanDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            // 
            // bankAccountBindingSource
            // 
            this.bankAccountBindingSource.DataMember = "BankAccount";
            this.bankAccountBindingSource.DataSource = this.bankdbDataSet3BindingSource;
            // 
            // bankdbDataSet3BindingSource
            // 
            this.bankdbDataSet3BindingSource.DataSource = this.bank_dbDataSet3;
            this.bankdbDataSet3BindingSource.Position = 0;
            // 
            // bank_dbDataSet3
            // 
            this.bank_dbDataSet3.DataSetName = "Bank_dbDataSet3";
            this.bank_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankAccountTableAdapter
            // 
            this.bankAccountTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Balance";
            // 
            // textBox_old_balance
            // 
            this.textBox_old_balance.Location = new System.Drawing.Point(123, 273);
            this.textBox_old_balance.Name = "textBox_old_balance";
            this.textBox_old_balance.ReadOnly = true;
            this.textBox_old_balance.Size = new System.Drawing.Size(100, 20);
            this.textBox_old_balance.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount To Add";
            // 
            // button_add_funds
            // 
            this.button_add_funds.Location = new System.Drawing.Point(297, 284);
            this.button_add_funds.Name = "button_add_funds";
            this.button_add_funds.Size = new System.Drawing.Size(147, 75);
            this.button_add_funds.TabIndex = 6;
            this.button_add_funds.Text = "Add Money To Selected Account";
            this.button_add_funds.UseVisualStyleBackColor = true;
            this.button_add_funds.Click += new System.EventHandler(this.button_add_funds_Click);
            // 
            // textBox_amount_to_add
            // 
            this.textBox_amount_to_add.Location = new System.Drawing.Point(123, 312);
            this.textBox_amount_to_add.Name = "textBox_amount_to_add";
            this.textBox_amount_to_add.Size = new System.Drawing.Size(100, 20);
            this.textBox_amount_to_add.TabIndex = 7;
            this.textBox_amount_to_add.TextChanged += new System.EventHandler(this.textBox_amount_to_add_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "New Balance";
            // 
            // textBox_new_balance
            // 
            this.textBox_new_balance.Location = new System.Drawing.Point(123, 354);
            this.textBox_new_balance.Name = "textBox_new_balance";
            this.textBox_new_balance.ReadOnly = true;
            this.textBox_new_balance.Size = new System.Drawing.Size(100, 20);
            this.textBox_new_balance.TabIndex = 9;
            // 
            // Form_Admin_Add_Funds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.textBox_new_balance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_amount_to_add);
            this.Controls.Add(this.button_add_funds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_old_balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_Add_Funds);
            this.Controls.Add(this.groupBox_search_by_cnp);
            this.Controls.Add(this.groupBox_search_by_name);
            this.Name = "Form_Admin_Add_Funds";
            this.Text = "Admin Add Funds";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form_Admin_Add_Funds_Load);
            this.groupBox_search_by_name.ResumeLayout(false);
            this.groupBox_search_by_name.PerformLayout();
            this.groupBox_search_by_cnp.ResumeLayout(false);
            this.groupBox_search_by_cnp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Add_Funds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_search_by_name;
        private System.Windows.Forms.TextBox textBox_second_name;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_search_by_cnp;
        private System.Windows.Forms.TextBox textBox_cnp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Add_Funds;
        private System.Windows.Forms.BindingSource bankdbDataSet3BindingSource;
        private Bank_dbDataSet3 bank_dbDataSet3;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private Bank_dbDataSet3TableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_search_by_name;
        private System.Windows.Forms.Button button_search_by_cnp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_old_balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_add_funds;
        private System.Windows.Forms.TextBox textBox_amount_to_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_new_balance;
    }
}