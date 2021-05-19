
namespace Bankify
{
    partial class Form_Admin_Menu
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
            this.LA_BTN = new System.Windows.Forms.Button();
            this.CD_BTN = new System.Windows.Forms.Button();
            this.BA_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(240, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Administrator";
            // 
            // LA_BTN
            // 
            this.LA_BTN.Location = new System.Drawing.Point(291, 119);
            this.LA_BTN.Name = "LA_BTN";
            this.LA_BTN.Size = new System.Drawing.Size(201, 59);
            this.LA_BTN.TabIndex = 1;
            this.LA_BTN.Text = "Login Accounts Administration";
            this.LA_BTN.UseVisualStyleBackColor = true;
            this.LA_BTN.Click += new System.EventHandler(this.LA_BTN_Click);
            // 
            // CD_BTN
            // 
            this.CD_BTN.Location = new System.Drawing.Point(291, 195);
            this.CD_BTN.Name = "CD_BTN";
            this.CD_BTN.Size = new System.Drawing.Size(201, 59);
            this.CD_BTN.TabIndex = 2;
            this.CD_BTN.Text = "Client Data Administration";
            this.CD_BTN.UseVisualStyleBackColor = true;
            this.CD_BTN.Click += new System.EventHandler(this.CD_BTN_Click);
            // 
            // BA_BTN
            // 
            this.BA_BTN.Location = new System.Drawing.Point(291, 270);
            this.BA_BTN.Name = "BA_BTN";
            this.BA_BTN.Size = new System.Drawing.Size(201, 59);
            this.BA_BTN.TabIndex = 3;
            this.BA_BTN.Text = "Bank Accounts Administration";
            this.BA_BTN.UseVisualStyleBackColor = true;
            this.BA_BTN.Click += new System.EventHandler(this.BA_BTN_Click);
            // 
            // Form_Admin_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BA_BTN);
            this.Controls.Add(this.CD_BTN);
            this.Controls.Add(this.LA_BTN);
            this.Controls.Add(this.label1);
            this.Name = "Form_Admin_Menu";
            this.Text = "Form_Admin_Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LA_BTN;
        private System.Windows.Forms.Button CD_BTN;
        private System.Windows.Forms.Button BA_BTN;
    }
}