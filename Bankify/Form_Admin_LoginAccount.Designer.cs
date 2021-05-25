
namespace Bankify
{
    partial class Form_Admin_LoginAccount
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
            this.dataGridView_LA = new System.Windows.Forms.DataGridView();
            this.loginidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginusernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accounttypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet2 = new Bankify.Bank_dbDataSet2();
            this.loginAccountTableAdapter = new Bankify.Bank_dbDataSet2TableAdapters.LoginAccountTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_TB = new System.Windows.Forms.MaskedTextBox();
            this.password_Tb = new System.Windows.Forms.MaskedTextBox();
            this.accountype_CB = new System.Windows.Forms.ComboBox();
            this.AddLA = new System.Windows.Forms.Button();
            this.editLA = new System.Windows.Forms.Button();
            this.deleteLA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_LA
            // 
            this.dataGridView_LA.AllowUserToAddRows = false;
            this.dataGridView_LA.AllowUserToDeleteRows = false;
            this.dataGridView_LA.AllowUserToResizeColumns = false;
            this.dataGridView_LA.AllowUserToResizeRows = false;
            this.dataGridView_LA.AutoGenerateColumns = false;
            this.dataGridView_LA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginidDataGridViewTextBoxColumn,
            this.loginusernameDataGridViewTextBoxColumn,
            this.loginpasswordDataGridViewTextBoxColumn,
            this.accounttypeDataGridViewTextBoxColumn});
            this.dataGridView_LA.DataSource = this.loginAccountBindingSource;
            this.dataGridView_LA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_LA.Location = new System.Drawing.Point(266, 12);
            this.dataGridView_LA.Name = "dataGridView_LA";
            this.dataGridView_LA.Size = new System.Drawing.Size(444, 322);
            this.dataGridView_LA.TabIndex = 0;
            this.dataGridView_LA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LA_CellClick);
            // 
            // loginidDataGridViewTextBoxColumn
            // 
            this.loginidDataGridViewTextBoxColumn.DataPropertyName = "login_id";
            this.loginidDataGridViewTextBoxColumn.HeaderText = "login_id";
            this.loginidDataGridViewTextBoxColumn.Name = "loginidDataGridViewTextBoxColumn";
            this.loginidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginusernameDataGridViewTextBoxColumn
            // 
            this.loginusernameDataGridViewTextBoxColumn.DataPropertyName = "login_username";
            this.loginusernameDataGridViewTextBoxColumn.HeaderText = "login_username";
            this.loginusernameDataGridViewTextBoxColumn.Name = "loginusernameDataGridViewTextBoxColumn";
            // 
            // loginpasswordDataGridViewTextBoxColumn
            // 
            this.loginpasswordDataGridViewTextBoxColumn.DataPropertyName = "login_password";
            this.loginpasswordDataGridViewTextBoxColumn.HeaderText = "login_password";
            this.loginpasswordDataGridViewTextBoxColumn.Name = "loginpasswordDataGridViewTextBoxColumn";
            // 
            // accounttypeDataGridViewTextBoxColumn
            // 
            this.accounttypeDataGridViewTextBoxColumn.DataPropertyName = "account_type";
            this.accounttypeDataGridViewTextBoxColumn.HeaderText = "account_type";
            this.accounttypeDataGridViewTextBoxColumn.Name = "accounttypeDataGridViewTextBoxColumn";
            // 
            // loginAccountBindingSource
            // 
            this.loginAccountBindingSource.DataMember = "LoginAccount";
            this.loginAccountBindingSource.DataSource = this.bank_dbDataSet2;
            // 
            // bank_dbDataSet2
            // 
            this.bank_dbDataSet2.DataSetName = "Bank_dbDataSet2";
            this.bank_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginAccountTableAdapter
            // 
            this.loginAccountTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Account type:";
            // 
            // username_TB
            // 
            this.username_TB.Location = new System.Drawing.Point(113, 62);
            this.username_TB.Name = "username_TB";
            this.username_TB.Size = new System.Drawing.Size(100, 20);
            this.username_TB.TabIndex = 4;
            // 
            // password_Tb
            // 
            this.password_Tb.Location = new System.Drawing.Point(113, 104);
            this.password_Tb.Name = "password_Tb";
            this.password_Tb.Size = new System.Drawing.Size(100, 20);
            this.password_Tb.TabIndex = 5;
            // 
            // accountype_CB
            // 
            this.accountype_CB.FormattingEnabled = true;
            this.accountype_CB.Items.AddRange(new object[] {
            "admin",
            "client"});
            this.accountype_CB.Location = new System.Drawing.Point(111, 146);
            this.accountype_CB.Name = "accountype_CB";
            this.accountype_CB.Size = new System.Drawing.Size(121, 21);
            this.accountype_CB.TabIndex = 6;
            // 
            // AddLA
            // 
            this.AddLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLA.Location = new System.Drawing.Point(42, 187);
            this.AddLA.Name = "AddLA";
            this.AddLA.Size = new System.Drawing.Size(130, 45);
            this.AddLA.TabIndex = 7;
            this.AddLA.Text = "Add Login Account";
            this.AddLA.UseVisualStyleBackColor = true;
            this.AddLA.Click += new System.EventHandler(this.AddLA_Click);
            // 
            // editLA
            // 
            this.editLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLA.Location = new System.Drawing.Point(42, 238);
            this.editLA.Name = "editLA";
            this.editLA.Size = new System.Drawing.Size(130, 45);
            this.editLA.TabIndex = 8;
            this.editLA.Text = "Edit Login Account";
            this.editLA.UseVisualStyleBackColor = true;
            this.editLA.Click += new System.EventHandler(this.editLA_Click);
            // 
            // deleteLA
            // 
            this.deleteLA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLA.Location = new System.Drawing.Point(42, 289);
            this.deleteLA.Name = "deleteLA";
            this.deleteLA.Size = new System.Drawing.Size(130, 45);
            this.deleteLA.TabIndex = 9;
            this.deleteLA.Text = "Delete Login Account";
            this.deleteLA.UseVisualStyleBackColor = true;
            this.deleteLA.Click += new System.EventHandler(this.deleteLA_Click);
            // 
            // Form_Admin_LoginAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 350);
            this.Controls.Add(this.deleteLA);
            this.Controls.Add(this.editLA);
            this.Controls.Add(this.AddLA);
            this.Controls.Add(this.accountype_CB);
            this.Controls.Add(this.password_Tb);
            this.Controls.Add(this.username_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_LA);
            this.Name = "Form_Admin_LoginAccount";
            this.Text = "Admin Add Login Account";
            this.Load += new System.EventHandler(this.Form_Admin_LoginAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_LA;
        private Bank_dbDataSet2 bank_dbDataSet2;
        private System.Windows.Forms.BindingSource loginAccountBindingSource;
        private Bank_dbDataSet2TableAdapters.LoginAccountTableAdapter loginAccountTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginusernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accounttypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox username_TB;
        private System.Windows.Forms.MaskedTextBox password_Tb;
        private System.Windows.Forms.ComboBox accountype_CB;
        private System.Windows.Forms.Button AddLA;
        private System.Windows.Forms.Button editLA;
        private System.Windows.Forms.Button deleteLA;
    }
}