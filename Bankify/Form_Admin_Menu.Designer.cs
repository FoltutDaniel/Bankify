
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
            this.button_add_funds = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_LoginClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Administrator";
            // 
            // LA_BTN
            // 
            this.LA_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LA_BTN.Location = new System.Drawing.Point(189, 112);
            this.LA_BTN.Name = "LA_BTN";
            this.LA_BTN.Size = new System.Drawing.Size(200, 60);
            this.LA_BTN.TabIndex = 1;
            this.LA_BTN.Text = "Login Accounts Administration";
            this.LA_BTN.UseVisualStyleBackColor = true;
            this.LA_BTN.Click += new System.EventHandler(this.LA_BTN_Click);
            // 
            // CD_BTN
            // 
            this.CD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CD_BTN.Location = new System.Drawing.Point(189, 179);
            this.CD_BTN.Name = "CD_BTN";
            this.CD_BTN.Size = new System.Drawing.Size(200, 60);
            this.CD_BTN.TabIndex = 2;
            this.CD_BTN.Text = "Client Data Administration";
            this.CD_BTN.UseVisualStyleBackColor = true;
            this.CD_BTN.Click += new System.EventHandler(this.CD_BTN_Click);
            // 
            // BA_BTN
            // 
            this.BA_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BA_BTN.Location = new System.Drawing.Point(189, 245);
            this.BA_BTN.Name = "BA_BTN";
            this.BA_BTN.Size = new System.Drawing.Size(200, 60);
            this.BA_BTN.TabIndex = 3;
            this.BA_BTN.Text = "Bank Accounts Administration";
            this.BA_BTN.UseVisualStyleBackColor = true;
            this.BA_BTN.Click += new System.EventHandler(this.BA_BTN_Click);
            // 
            // button_add_funds
            // 
            this.button_add_funds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_funds.Location = new System.Drawing.Point(395, 113);
            this.button_add_funds.Name = "button_add_funds";
            this.button_add_funds.Size = new System.Drawing.Size(200, 60);
            this.button_add_funds.TabIndex = 4;
            this.button_add_funds.Text = "Add Funds to Bank Account";
            this.button_add_funds.UseVisualStyleBackColor = true;
            this.button_add_funds.Click += new System.EventHandler(this.button_add_funds_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(395, 245);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(200, 60);
            this.button_Exit.TabIndex = 5;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_LoginClient
            // 
            this.button_LoginClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LoginClient.Location = new System.Drawing.Point(395, 179);
            this.button_LoginClient.Name = "button_LoginClient";
            this.button_LoginClient.Size = new System.Drawing.Size(200, 60);
            this.button_LoginClient.TabIndex = 6;
            this.button_LoginClient.Text = "Login as client";
            this.button_LoginClient.UseVisualStyleBackColor = true;
            this.button_LoginClient.Click += new System.EventHandler(this.button_LoginClient_Click);
            // 
            // Form_Admin_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 364);
            this.Controls.Add(this.button_LoginClient);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_add_funds);
            this.Controls.Add(this.BA_BTN);
            this.Controls.Add(this.CD_BTN);
            this.Controls.Add(this.LA_BTN);
            this.Controls.Add(this.label1);
            this.Name = "Form_Admin_Menu";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.Form_Admin_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LA_BTN;
        private System.Windows.Forms.Button CD_BTN;
        private System.Windows.Forms.Button BA_BTN;
        private System.Windows.Forms.Button button_add_funds;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_LoginClient;
    }
}