namespace Bankify
{
    partial class Form_Transfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FromIban = new System.Windows.Forms.TextBox();
            this.textBox_ToIban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_Currency = new System.Windows.Forms.TextBox();
            this.button_FinishTransf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Iban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "To Iban:";
            // 
            // textBox_FromIban
            // 
            this.textBox_FromIban.Location = new System.Drawing.Point(108, 77);
            this.textBox_FromIban.Name = "textBox_FromIban";
            this.textBox_FromIban.Size = new System.Drawing.Size(178, 20);
            this.textBox_FromIban.TabIndex = 2;
            // 
            // textBox_ToIban
            // 
            this.textBox_ToIban.Location = new System.Drawing.Point(108, 113);
            this.textBox_ToIban.Name = "textBox_ToIban";
            this.textBox_ToIban.Size = new System.Drawing.Size(178, 20);
            this.textBox_ToIban.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Currency:";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(108, 145);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(178, 20);
            this.textBox_Amount.TabIndex = 8;
            // 
            // textBox_Currency
            // 
            this.textBox_Currency.Location = new System.Drawing.Point(108, 180);
            this.textBox_Currency.Name = "textBox_Currency";
            this.textBox_Currency.Size = new System.Drawing.Size(178, 20);
            this.textBox_Currency.TabIndex = 9;
            // 
            // button_FinishTransf
            // 
            this.button_FinishTransf.Location = new System.Drawing.Point(108, 222);
            this.button_FinishTransf.Name = "button_FinishTransf";
            this.button_FinishTransf.Size = new System.Drawing.Size(90, 40);
            this.button_FinishTransf.TabIndex = 10;
            this.button_FinishTransf.Text = "Finalizeaza transferul";
            this.button_FinishTransf.UseVisualStyleBackColor = true;
            this.button_FinishTransf.Click += new System.EventHandler(this.button_FinishTransf_Click);
            // 
            // Form_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.button_FinishTransf);
            this.Controls.Add(this.textBox_Currency);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ToIban);
            this.Controls.Add(this.textBox_FromIban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Transfer";
            this.Text = "Form_Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FromIban;
        private System.Windows.Forms.TextBox textBox_ToIban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_Currency;
        private System.Windows.Forms.Button button_FinishTransf;
    }
}