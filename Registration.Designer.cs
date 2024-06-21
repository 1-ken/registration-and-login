namespace registration_and_login
{
    partial class Registration
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
            this.regBtn = new System.Windows.Forms.Button();
            this.haveAccbtn = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassoword = new System.Windows.Forms.TextBox();
            this.textConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(348, 280);
            this.regBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(125, 32);
            this.regBtn.TabIndex = 3;
            this.regBtn.Text = "Register now";
            this.regBtn.UseVisualStyleBackColor = true;
            // 
            // haveAccbtn
            // 
            this.haveAccbtn.Location = new System.Drawing.Point(290, 367);
            this.haveAccbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.haveAccbtn.Name = "haveAccbtn";
            this.haveAccbtn.Size = new System.Drawing.Size(277, 51);
            this.haveAccbtn.TabIndex = 4;
            this.haveAccbtn.Text = "have an account? log in now";
            this.haveAccbtn.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(368, 58);
            this.textName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(164, 27);
            this.textName.TabIndex = 5;
            // 
            // textPassoword
            // 
            this.textPassoword.Location = new System.Drawing.Point(368, 134);
            this.textPassoword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textPassoword.Name = "textPassoword";
            this.textPassoword.Size = new System.Drawing.Size(164, 27);
            this.textPassoword.TabIndex = 6;
            // 
            // textConfirmPassword
            // 
            this.textConfirmPassword.Location = new System.Drawing.Point(368, 227);
            this.textConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textConfirmPassword.Name = "textConfirmPassword";
            this.textConfirmPassword.Size = new System.Drawing.Size(164, 27);
            this.textConfirmPassword.TabIndex = 7;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 623);
            this.Controls.Add(this.textConfirmPassword);
            this.Controls.Add(this.textPassoword);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.haveAccbtn);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Registration";
            this.Text = "Rgistration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button haveAccbtn;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassoword;
        private System.Windows.Forms.TextBox textConfirmPassword;
    }
}

