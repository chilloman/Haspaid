namespace Haspaid
{
    partial class Form1
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.lansw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(12, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(152, 20);
            this.tbUsername.TabIndex = 0;
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(12, 38);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(152, 27);
            this.btCheck.TabIndex = 1;
            this.btCheck.Text = "Hapaid?";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // lansw
            // 
            this.lansw.AutoSize = true;
            this.lansw.Location = new System.Drawing.Point(12, 68);
            this.lansw.Name = "lansw";
            this.lansw.Size = new System.Drawing.Size(0, 13);
            this.lansw.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 88);
            this.Controls.Add(this.lansw);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbUsername);
            this.Name = "Form1";
            this.Text = "Haspaid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Label lansw;
    }
}

