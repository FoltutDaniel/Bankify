namespace Bankify
{
    partial class Form_ChangePass
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_oldPass = new System.Windows.Forms.TextBox();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.textBox_confirmPass = new System.Windows.Forms.TextBox();
            this.button_ChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Old password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm new password:";
            // 
            // textBox_oldPass
            // 
            this.textBox_oldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_oldPass.Location = new System.Drawing.Point(198, 43);
            this.textBox_oldPass.Name = "textBox_oldPass";
            this.textBox_oldPass.Size = new System.Drawing.Size(149, 24);
            this.textBox_oldPass.TabIndex = 3;
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newPass.Location = new System.Drawing.Point(198, 85);
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.Size = new System.Drawing.Size(149, 24);
            this.textBox_newPass.TabIndex = 4;
            // 
            // textBox_confirmPass
            // 
            this.textBox_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_confirmPass.Location = new System.Drawing.Point(198, 122);
            this.textBox_confirmPass.Name = "textBox_confirmPass";
            this.textBox_confirmPass.Size = new System.Drawing.Size(149, 24);
            this.textBox_confirmPass.TabIndex = 5;
            // 
            // button_ChangePass
            // 
            this.button_ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangePass.Location = new System.Drawing.Point(129, 175);
            this.button_ChangePass.Name = "button_ChangePass";
            this.button_ChangePass.Size = new System.Drawing.Size(120, 60);
            this.button_ChangePass.TabIndex = 6;
            this.button_ChangePass.Text = "Change Password";
            this.button_ChangePass.UseVisualStyleBackColor = true;
            this.button_ChangePass.Click += new System.EventHandler(this.button_ChangePass_Click);
            // 
            // Form_ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 263);
            this.Controls.Add(this.button_ChangePass);
            this.Controls.Add(this.textBox_confirmPass);
            this.Controls.Add(this.textBox_newPass);
            this.Controls.Add(this.textBox_oldPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ChangePass";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_oldPass;
        private System.Windows.Forms.TextBox textBox_newPass;
        private System.Windows.Forms.TextBox textBox_confirmPass;
        private System.Windows.Forms.Button button_ChangePass;
    }
}