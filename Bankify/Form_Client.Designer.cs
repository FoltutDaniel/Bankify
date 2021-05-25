namespace Bankify
{
    partial class Form_Client
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
            this.bank_dbDataSet = new Bankify.Bank_dbDataSet();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.bankAccountTableAdapter = new Bankify.Bank_dbDataSet1TableAdapters.BankAccountTableAdapter();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.button_Transfer = new System.Windows.Forms.Button();
            this.button_ExtrasCont = new System.Windows.Forms.Button();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_ChangePass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bank_dbDataSet
            // 
            this.bank_dbDataSet.DataSetName = "Bank_dbDataSet";
            this.bank_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.Location = new System.Drawing.Point(12, 9);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(46, 18);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "label1";
            // 
            // bankAccountTableAdapter
            // 
            this.bankAccountTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Client.Location = new System.Drawing.Point(214, 9);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.ReadOnly = true;
            this.dataGridView_Client.Size = new System.Drawing.Size(348, 279);
            this.dataGridView_Client.TabIndex = 1;
            // 
            // button_Transfer
            // 
            this.button_Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Transfer.Location = new System.Drawing.Point(12, 30);
            this.button_Transfer.Name = "button_Transfer";
            this.button_Transfer.Size = new System.Drawing.Size(140, 60);
            this.button_Transfer.TabIndex = 2;
            this.button_Transfer.Text = "Transfer";
            this.button_Transfer.UseVisualStyleBackColor = true;
            this.button_Transfer.Click += new System.EventHandler(this.button_Transfer_Click);
            // 
            // button_ExtrasCont
            // 
            this.button_ExtrasCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ExtrasCont.Location = new System.Drawing.Point(12, 96);
            this.button_ExtrasCont.Name = "button_ExtrasCont";
            this.button_ExtrasCont.Size = new System.Drawing.Size(140, 60);
            this.button_ExtrasCont.TabIndex = 3;
            this.button_ExtrasCont.Text = "Generate account statements";
            this.button_ExtrasCont.UseVisualStyleBackColor = true;
            this.button_ExtrasCont.Click += new System.EventHandler(this.button_ExtrasCont_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(12, 228);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(140, 60);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Close";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_ChangePass
            // 
            this.button_ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePass.Location = new System.Drawing.Point(12, 162);
            this.button_ChangePass.Name = "button_ChangePass";
            this.button_ChangePass.Size = new System.Drawing.Size(140, 60);
            this.button_ChangePass.TabIndex = 5;
            this.button_ChangePass.Text = "Change  password";
            this.button_ChangePass.UseVisualStyleBackColor = true;
            this.button_ChangePass.Click += new System.EventHandler(this.button_ChangePass_Click);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 298);
            this.Controls.Add(this.button_ChangePass);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ExtrasCont);
            this.Controls.Add(this.button_Transfer);
            this.Controls.Add(this.dataGridView_Client);
            this.Controls.Add(this.greetingLabel);
            this.Name = "Form_Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bank_dbDataSet bank_dbDataSet;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private Bank_dbDataSet1TableAdapters.BankAccountTableAdapter bankAccountTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Client;
        private System.Windows.Forms.Button button_Transfer;
        private System.Windows.Forms.Button button_ExtrasCont;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_ChangePass;
    }
}