namespace Bankify
{
    partial class Form_ExtrasCont
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
            this.dataGridView_ExtrasCont = new System.Windows.Forms.DataGridView();
            this.button_fromIban = new System.Windows.Forms.Button();
            this.button_viewAll = new System.Windows.Forms.Button();
            this.button_toIban = new System.Windows.Forms.Button();
            this.button_ExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtrasCont)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ExtrasCont
            // 
            this.dataGridView_ExtrasCont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ExtrasCont.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_ExtrasCont.Name = "dataGridView_ExtrasCont";
            this.dataGridView_ExtrasCont.ReadOnly = true;
            this.dataGridView_ExtrasCont.Size = new System.Drawing.Size(564, 308);
            this.dataGridView_ExtrasCont.TabIndex = 0;
            // 
            // button_fromIban
            // 
            this.button_fromIban.Location = new System.Drawing.Point(12, 326);
            this.button_fromIban.Name = "button_fromIban";
            this.button_fromIban.Size = new System.Drawing.Size(78, 47);
            this.button_fromIban.TabIndex = 1;
            this.button_fromIban.Text = "Transactions from this iban";
            this.button_fromIban.UseVisualStyleBackColor = true;
            this.button_fromIban.Click += new System.EventHandler(this.button_fromIban_Click);
            // 
            // button_viewAll
            // 
            this.button_viewAll.Location = new System.Drawing.Point(180, 326);
            this.button_viewAll.Name = "button_viewAll";
            this.button_viewAll.Size = new System.Drawing.Size(78, 47);
            this.button_viewAll.TabIndex = 3;
            this.button_viewAll.Text = "All transactions";
            this.button_viewAll.UseVisualStyleBackColor = true;
            this.button_viewAll.Click += new System.EventHandler(this.button_viewAll_Click);
            // 
            // button_toIban
            // 
            this.button_toIban.Location = new System.Drawing.Point(96, 326);
            this.button_toIban.Name = "button_toIban";
            this.button_toIban.Size = new System.Drawing.Size(78, 47);
            this.button_toIban.TabIndex = 2;
            this.button_toIban.Text = "Transactions to this iban";
            this.button_toIban.UseVisualStyleBackColor = true;
            this.button_toIban.Click += new System.EventHandler(this.button_toIban_Click);
            // 
            // button_ExportExcel
            // 
            this.button_ExportExcel.Location = new System.Drawing.Point(264, 326);
            this.button_ExportExcel.Name = "button_ExportExcel";
            this.button_ExportExcel.Size = new System.Drawing.Size(78, 47);
            this.button_ExportExcel.TabIndex = 4;
            this.button_ExportExcel.Text = "Export To Excell";
            this.button_ExportExcel.UseVisualStyleBackColor = true;
            this.button_ExportExcel.Click += new System.EventHandler(this.button_ExportExcel_Click);
            // 
            // Form_ExtrasCont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 386);
            this.Controls.Add(this.button_ExportExcel);
            this.Controls.Add(this.button_viewAll);
            this.Controls.Add(this.button_toIban);
            this.Controls.Add(this.button_fromIban);
            this.Controls.Add(this.dataGridView_ExtrasCont);
            this.Name = "Form_ExtrasCont";
            this.Text = "Extras Cont";
            this.Load += new System.EventHandler(this.Form_ExtrasCont_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ExtrasCont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ExtrasCont;
        private System.Windows.Forms.Button button_fromIban;
        private System.Windows.Forms.Button button_viewAll;
        private System.Windows.Forms.Button button_toIban;
        private System.Windows.Forms.Button button_ExportExcel;
    }
}