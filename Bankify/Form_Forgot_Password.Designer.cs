namespace Bankify
{
    partial class Form_Forgot_Password
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
            this.textBox_forgot_pass_email = new System.Windows.Forms.TextBox();
            this.button_send_email = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your Email";
            // 
            // textBox_forgot_pass_email
            // 
            this.textBox_forgot_pass_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_forgot_pass_email.Location = new System.Drawing.Point(135, 31);
            this.textBox_forgot_pass_email.Name = "textBox_forgot_pass_email";
            this.textBox_forgot_pass_email.Size = new System.Drawing.Size(181, 24);
            this.textBox_forgot_pass_email.TabIndex = 1;
            // 
            // button_send_email
            // 
            this.button_send_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send_email.Location = new System.Drawing.Point(109, 88);
            this.button_send_email.Name = "button_send_email";
            this.button_send_email.Size = new System.Drawing.Size(120, 60);
            this.button_send_email.TabIndex = 2;
            this.button_send_email.Text = "Send new password";
            this.button_send_email.UseVisualStyleBackColor = true;
            this.button_send_email.Click += new System.EventHandler(this.button_send_email_Click);
            // 
            // Form_Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 178);
            this.Controls.Add(this.button_send_email);
            this.Controls.Add(this.textBox_forgot_pass_email);
            this.Controls.Add(this.label1);
            this.Name = "Form_Forgot_Password";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Form_Forgot_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_forgot_pass_email;
        private System.Windows.Forms.Button button_send_email;
    }
}