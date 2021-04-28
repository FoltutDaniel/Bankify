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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.bank_dbDataSet = new Bankify.Bank_dbDataSet();
            this.bankdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bank_dbDataSet1 = new Bankify.Bank_dbDataSet();
            this.bank_dbDataSet2 = new Bankify.Bank_dbDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Location = new System.Drawing.Point(53, 41);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(35, 13);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "label1";
            // 
            // bank_dbDataSet
            // 
            this.bank_dbDataSet.DataSetName = "Bank_dbDataSet";
            this.bank_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankdbDataSetBindingSource
            // 
            this.bankdbDataSetBindingSource.DataSource = this.bank_dbDataSet;
            this.bankdbDataSetBindingSource.Position = 0;
            // 
            // bank_dbDataSet1
            // 
            this.bank_dbDataSet1.DataSetName = "Bank_dbDataSet";
            this.bank_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bank_dbDataSet2
            // 
            this.bank_dbDataSet2.DataSetName = "Bank_dbDataSet";
            this.bank_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 480);
            this.Controls.Add(this.greetingLabel);
            this.Name = "Form_Client";
            this.Text = "Form_Client";
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_dbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private Bank_dbDataSet bank_dbDataSet;
        private System.Windows.Forms.BindingSource bankdbDataSetBindingSource;
        private Bank_dbDataSet bank_dbDataSet1;
        private Bank_dbDataSet bank_dbDataSet2;
    }
}