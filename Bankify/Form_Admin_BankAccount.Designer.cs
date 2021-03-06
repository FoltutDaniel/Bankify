
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
            this.button_searchByCNP = new System.Windows.Forms.Button();
            this.CNP_LBL = new System.Windows.Forms.Label();
            this.SCNP_TB = new System.Windows.Forms.TextBox();
            this.showAll_BTN = new System.Windows.Forms.Button();
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
            this.dataGrid_BA.Location = new System.Drawing.Point(311, 41);
            this.dataGrid_BA.Name = "dataGrid_BA";
            this.dataGrid_BA.Size = new System.Drawing.Size(547, 301);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "IBAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Currency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Client ID:";
            // 
            // iban_TB
            // 
            this.iban_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iban_TB.Location = new System.Drawing.Point(117, 41);
            this.iban_TB.Name = "iban_TB";
            this.iban_TB.Size = new System.Drawing.Size(100, 24);
            this.iban_TB.TabIndex = 5;
            // 
            // ammount_TB
            // 
            this.ammount_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ammount_TB.Location = new System.Drawing.Point(117, 109);
            this.ammount_TB.Name = "ammount_TB";
            this.ammount_TB.Size = new System.Drawing.Size(100, 24);
            this.ammount_TB.TabIndex = 7;
            // 
            // clientID_TB
            // 
            this.clientID_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientID_TB.Location = new System.Drawing.Point(117, 142);
            this.clientID_TB.Name = "clientID_TB";
            this.clientID_TB.Size = new System.Drawing.Size(100, 24);
            this.clientID_TB.TabIndex = 8;
            // 
            // addBA_BTN
            // 
            this.addBA_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBA_BTN.Location = new System.Drawing.Point(15, 180);
            this.addBA_BTN.Name = "addBA_BTN";
            this.addBA_BTN.Size = new System.Drawing.Size(120, 50);
            this.addBA_BTN.TabIndex = 9;
            this.addBA_BTN.Text = "Add Bank Account";
            this.addBA_BTN.UseVisualStyleBackColor = true;
            this.addBA_BTN.Click += new System.EventHandler(this.addBA_BTN_Click);
            // 
            // editBA_BTN
            // 
            this.editBA_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBA_BTN.Location = new System.Drawing.Point(15, 236);
            this.editBA_BTN.Name = "editBA_BTN";
            this.editBA_BTN.Size = new System.Drawing.Size(120, 50);
            this.editBA_BTN.TabIndex = 10;
            this.editBA_BTN.Text = "Edit Bank Account";
            this.editBA_BTN.UseVisualStyleBackColor = true;
            this.editBA_BTN.Click += new System.EventHandler(this.editBA_BTN_Click);
            // 
            // deleteBA_BTN
            // 
            this.deleteBA_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBA_BTN.Location = new System.Drawing.Point(15, 292);
            this.deleteBA_BTN.Name = "deleteBA_BTN";
            this.deleteBA_BTN.Size = new System.Drawing.Size(120, 50);
            this.deleteBA_BTN.TabIndex = 11;
            this.deleteBA_BTN.Text = "Delete Bank Account";
            this.deleteBA_BTN.UseVisualStyleBackColor = true;
            this.deleteBA_BTN.Click += new System.EventHandler(this.deleteBA_BTN_Click);
            // 
            // currency_CB
            // 
            this.currency_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.currency_CB.Location = new System.Drawing.Point(117, 75);
            this.currency_CB.Name = "currency_CB";
            this.currency_CB.Size = new System.Drawing.Size(121, 26);
            this.currency_CB.TabIndex = 12;
            // 
            // button_searchByCNP
            // 
            this.button_searchByCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchByCNP.Location = new System.Drawing.Point(141, 180);
            this.button_searchByCNP.Name = "button_searchByCNP";
            this.button_searchByCNP.Size = new System.Drawing.Size(120, 50);
            this.button_searchByCNP.TabIndex = 13;
            this.button_searchByCNP.Text = "Search By CNP";
            this.button_searchByCNP.UseVisualStyleBackColor = true;
            this.button_searchByCNP.Click += new System.EventHandler(this.button_searchByName_Click);
            // 
            // CNP_LBL
            // 
            this.CNP_LBL.AutoSize = true;
            this.CNP_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNP_LBL.Location = new System.Drawing.Point(141, 249);
            this.CNP_LBL.Name = "CNP_LBL";
            this.CNP_LBL.Size = new System.Drawing.Size(44, 18);
            this.CNP_LBL.TabIndex = 14;
            this.CNP_LBL.Text = "CNP:";
            // 
            // SCNP_TB
            // 
            this.SCNP_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCNP_TB.Location = new System.Drawing.Point(191, 246);
            this.SCNP_TB.Name = "SCNP_TB";
            this.SCNP_TB.Size = new System.Drawing.Size(100, 24);
            this.SCNP_TB.TabIndex = 15;
            // 
            // showAll_BTN
            // 
            this.showAll_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAll_BTN.Location = new System.Drawing.Point(141, 292);
            this.showAll_BTN.Name = "showAll_BTN";
            this.showAll_BTN.Size = new System.Drawing.Size(120, 50);
            this.showAll_BTN.TabIndex = 16;
            this.showAll_BTN.Text = "Show All Entries";
            this.showAll_BTN.UseVisualStyleBackColor = true;
            this.showAll_BTN.Click += new System.EventHandler(this.showAll_BTN_Click);
            // 
            // Form_Admin_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 362);
            this.Controls.Add(this.showAll_BTN);
            this.Controls.Add(this.SCNP_TB);
            this.Controls.Add(this.CNP_LBL);
            this.Controls.Add(this.button_searchByCNP);
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
            this.Text = "Admin Add Bank Account";
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
        private System.Windows.Forms.Button button_searchByCNP;
        private System.Windows.Forms.Label CNP_LBL;
        private System.Windows.Forms.TextBox SCNP_TB;
        private System.Windows.Forms.Button showAll_BTN;
    }
}