
namespace Bankify
{
    partial class Form_Admin_BankAccount
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
            this.dataGrid_BA = new System.Windows.Forms.DataGridView();
            this.accountidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet3 = new Bankify.Bank_dbDataSet3();
            this.bankAccountTableAdapter = new Bankify.Bank_dbDataSet3TableAdapters.BankAccountTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iban_TB = new System.Windows.Forms.TextBox();
            this.ammount_TB = new System.Windows.Forms.TextBox();
            this.clientID_TB = new System.Windows.Forms.TextBox();
            this.addBA_BTN = new System.Windows.Forms.Button();
            this.editBA_BTN = new System.Windows.Forms.Button();
            this.deleteBA_BTN = new System.Windows.Forms.Button();
            this.currency_CB = new System.Windows.Forms.ComboBox();
            this.button_searchByName = new System.Windows.Forms.Button();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_BA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_BA
            // 
            this.dataGrid_BA.AutoGenerateColumns = false;
            this.dataGrid_BA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_BA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountidDataGridViewTextBoxColumn,
            this.ibanDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.clientidDataGridViewTextBoxColumn});
            this.dataGrid_BA.DataSource = this.bankAccountBindingSource;
            this.dataGrid_BA.Location = new System.Drawing.Point(241, 35);
            this.dataGrid_BA.Name = "dataGrid_BA";
            this.dataGrid_BA.Size = new System.Drawing.Size(547, 221);
            this.dataGrid_BA.TabIndex = 0;
            this.dataGrid_BA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_BA_CellClick);
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
            this.bankAccountBindingSource.DataSource = this.bank_dbDataSet3;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IBAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ClientId";
            // 
            // iban_TB
            // 
            this.iban_TB.Location = new System.Drawing.Point(71, 41);
            this.iban_TB.Name = "iban_TB";
            this.iban_TB.Size = new System.Drawing.Size(100, 20);
            this.iban_TB.TabIndex = 5;
            // 
            // ammount_TB
            // 
            this.ammount_TB.Location = new System.Drawing.Point(71, 108);
            this.ammount_TB.Name = "ammount_TB";
            this.ammount_TB.Size = new System.Drawing.Size(100, 20);
            this.ammount_TB.TabIndex = 7;
            // 
            // clientID_TB
            // 
            this.clientID_TB.Location = new System.Drawing.Point(71, 139);
            this.clientID_TB.Name = "clientID_TB";
            this.clientID_TB.Size = new System.Drawing.Size(100, 20);
            this.clientID_TB.TabIndex = 8;
            // 
            // addBA_BTN
            // 
            this.addBA_BTN.Location = new System.Drawing.Point(12, 311);
            this.addBA_BTN.Name = "addBA_BTN";
            this.addBA_BTN.Size = new System.Drawing.Size(95, 45);
            this.addBA_BTN.TabIndex = 9;
            this.addBA_BTN.Text = "Add Bank Account";
            this.addBA_BTN.UseVisualStyleBackColor = true;
            this.addBA_BTN.Click += new System.EventHandler(this.addBA_BTN_Click);
            // 
            // editBA_BTN
            // 
            this.editBA_BTN.Location = new System.Drawing.Point(152, 311);
            this.editBA_BTN.Name = "editBA_BTN";
            this.editBA_BTN.Size = new System.Drawing.Size(89, 45);
            this.editBA_BTN.TabIndex = 10;
            this.editBA_BTN.Text = "Edit Bank Account";
            this.editBA_BTN.UseVisualStyleBackColor = true;
            this.editBA_BTN.Click += new System.EventHandler(this.editBA_BTN_Click);
            // 
            // deleteBA_BTN
            // 
            this.deleteBA_BTN.Location = new System.Drawing.Point(288, 311);
            this.deleteBA_BTN.Name = "deleteBA_BTN";
            this.deleteBA_BTN.Size = new System.Drawing.Size(90, 45);
            this.deleteBA_BTN.TabIndex = 11;
            this.deleteBA_BTN.Text = "Delete Bank Account";
            this.deleteBA_BTN.UseVisualStyleBackColor = true;
            this.deleteBA_BTN.Click += new System.EventHandler(this.deleteBA_BTN_Click);
            // 
            // currency_CB
            // 
            this.currency_CB.FormattingEnabled = true;
            this.currency_CB.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "JPY",
            "GBP",
            "AUD",
            "CAD",
            "CHF",
            "CNY",
            "RON",
            "SEK",
            "HUF"});
            this.currency_CB.Location = new System.Drawing.Point(71, 72);
            this.currency_CB.Name = "currency_CB";
            this.currency_CB.Size = new System.Drawing.Size(121, 21);
            this.currency_CB.TabIndex = 12;
            // 
            // button_searchByName
            // 
            this.button_searchByName.Location = new System.Drawing.Point(414, 311);
            this.button_searchByName.Name = "button_searchByName";
            this.button_searchByName.Size = new System.Drawing.Size(90, 45);
            this.button_searchByName.TabIndex = 13;
            this.button_searchByName.Text = "Search By Name";
            this.button_searchByName.UseVisualStyleBackColor = true;
            this.button_searchByName.Click += new System.EventHandler(this.button_searchByName_Click);
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(608, 302);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 14;
            this.textBox_lastName.Visible = false;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(608, 336);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstName.TabIndex = 15;
            this.textBox_firstName.Visible = false;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(541, 305);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(61, 13);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Last Name:";
            this.label_name.Visible = false;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(541, 343);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 17;
            this.label_firstName.Text = "First Name";
            this.label_firstName.Visible = false;
            // 
            // Form_Admin_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.button_searchByName);
            this.Controls.Add(this.currency_CB);
            this.Controls.Add(this.deleteBA_BTN);
            this.Controls.Add(this.editBA_BTN);
            this.Controls.Add(this.addBA_BTN);
            this.Controls.Add(this.clientID_TB);
            this.Controls.Add(this.ammount_TB);
            this.Controls.Add(this.iban_TB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_BA);
            this.Name = "Form_Admin_BankAccount";
            this.Text = "Form_Admin_AddBankAccount";
            this.Load += new System.EventHandler(this.Form_Admin_BankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_BA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_BA;
        private Bank_dbDataSet3 bank_dbDataSet3;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private Bank_dbDataSet3TableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox iban_TB;
        private System.Windows.Forms.TextBox ammount_TB;
        private System.Windows.Forms.TextBox clientID_TB;
        private System.Windows.Forms.Button addBA_BTN;
        private System.Windows.Forms.Button editBA_BTN;
        private System.Windows.Forms.Button deleteBA_BTN;
        private System.Windows.Forms.ComboBox currency_CB;
        private System.Windows.Forms.Button button_searchByName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_firstName;
    }
}