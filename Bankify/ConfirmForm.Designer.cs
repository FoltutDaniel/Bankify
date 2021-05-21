
namespace Bankify
{
    partial class ConfirmForm
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
            this.message_LBL = new System.Windows.Forms.Label();
            this.deny_BTN = new System.Windows.Forms.Button();
            this.accept_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // message_LBL
            // 
            this.message_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message_LBL.AutoSize = true;
            this.message_LBL.Location = new System.Drawing.Point(85, 63);
            this.message_LBL.Name = "message_LBL";
            this.message_LBL.Size = new System.Drawing.Size(35, 13);
            this.message_LBL.TabIndex = 0;
            this.message_LBL.Text = "label1";
            this.message_LBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deny_BTN
            // 
            this.deny_BTN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.deny_BTN.Location = new System.Drawing.Point(27, 139);
            this.deny_BTN.Name = "deny_BTN";
            this.deny_BTN.Size = new System.Drawing.Size(53, 39);
            this.deny_BTN.TabIndex = 1;
            this.deny_BTN.Text = "NU";
            this.deny_BTN.UseVisualStyleBackColor = true;
            this.deny_BTN.Click += new System.EventHandler(this.deny_BTN_Click);
            // 
            // accept_BTN
            // 
            this.accept_BTN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.accept_BTN.Location = new System.Drawing.Point(121, 139);
            this.accept_BTN.Name = "accept_BTN";
            this.accept_BTN.Size = new System.Drawing.Size(58, 39);
            this.accept_BTN.TabIndex = 2;
            this.accept_BTN.Text = "DA";
            this.accept_BTN.UseVisualStyleBackColor = true;
            this.accept_BTN.Click += new System.EventHandler(this.accept_BTN_Click);
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(208, 213);
            this.Controls.Add(this.accept_BTN);
            this.Controls.Add(this.deny_BTN);
            this.Controls.Add(this.message_LBL);
            this.Name = "ConfirmForm";
            this.Text = "ConfirmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message_LBL;
        private System.Windows.Forms.Button deny_BTN;
        private System.Windows.Forms.Button accept_BTN;
    }
}