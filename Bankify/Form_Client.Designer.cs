﻿namespace Bankify
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
            this.button_transferOut = new System.Windows.Forms.Button();
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
            this.greetingLabel.Location = new System.Drawing.Point(12, 9);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(35, 13);
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
            this.dataGridView_Client.Location = new System.Drawing.Point(241, 12);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.ReadOnly = true;
            this.dataGridView_Client.Size = new System.Drawing.Size(348, 177);
            this.dataGridView_Client.TabIndex = 1;
            // 
            // button_Transfer
            // 
            this.button_Transfer.Location = new System.Drawing.Point(12, 202);
            this.button_Transfer.Name = "button_Transfer";
            this.button_Transfer.Size = new System.Drawing.Size(90, 43);
            this.button_Transfer.TabIndex = 2;
            this.button_Transfer.Text = "Transfer intre conturi";
            this.button_Transfer.UseVisualStyleBackColor = true;
            this.button_Transfer.Click += new System.EventHandler(this.button_Transfer_Click);
            // 
            // button_ExtrasCont
            // 
            this.button_ExtrasCont.Location = new System.Drawing.Point(122, 202);
            this.button_ExtrasCont.Name = "button_ExtrasCont";
            this.button_ExtrasCont.Size = new System.Drawing.Size(90, 43);
            this.button_ExtrasCont.TabIndex = 3;
            this.button_ExtrasCont.Text = "Genereaza Extras de Cont";
            this.button_ExtrasCont.UseVisualStyleBackColor = true;
            this.button_ExtrasCont.Click += new System.EventHandler(this.button_ExtrasCont_Click);
            // 
            // button_transferOut
            // 
            this.button_transferOut.Location = new System.Drawing.Point(241, 202);
            this.button_transferOut.Name = "button_transferOut";
            this.button_transferOut.Size = new System.Drawing.Size(90, 43);
            this.button_transferOut.TabIndex = 4;
            this.button_transferOut.Text = "Transfer in alt cont";
            this.button_transferOut.UseVisualStyleBackColor = true;
            this.button_transferOut.Click += new System.EventHandler(this.button_transferOut_Click);
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 480);
            this.Controls.Add(this.button_transferOut);
            this.Controls.Add(this.button_ExtrasCont);
            this.Controls.Add(this.button_Transfer);
            this.Controls.Add(this.dataGridView_Client);
            this.Controls.Add(this.greetingLabel);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
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
        private System.Windows.Forms.Button button_transferOut;
    }
}