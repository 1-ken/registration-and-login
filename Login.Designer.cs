namespace registration_and_login
{
    partial class Login
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.button1loginbtn = new System.Windows.Forms.Button();
            this.button2regbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(317, 164);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(164, 27);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(317, 80);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(164, 27);
            this.txtusername.TabIndex = 3;
            // 
            // button1loginbtn
            // 
            this.button1loginbtn.Location = new System.Drawing.Point(336, 256);
            this.button1loginbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1loginbtn.Name = "button1loginbtn";
            this.button1loginbtn.Size = new System.Drawing.Size(125, 32);
            this.button1loginbtn.TabIndex = 4;
            this.button1loginbtn.Text = "Login";
            this.button1loginbtn.UseVisualStyleBackColor = true;
            this.button1loginbtn.Click += new System.EventHandler(this.button1loginbtn_Click);
            // 
            // button2regbtn
            // 
            this.button2regbtn.Location = new System.Drawing.Point(294, 307);
            this.button2regbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2regbtn.Name = "button2regbtn";
            this.button2regbtn.Size = new System.Drawing.Size(206, 73);
            this.button2regbtn.TabIndex = 5;
            this.button2regbtn.Text = "Dont have an account? Register now";
            this.button2regbtn.UseVisualStyleBackColor = true;
            this.button2regbtn.Click += new System.EventHandler(this.button2regbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 623);
            this.Controls.Add(this.button2regbtn);
            this.Controls.Add(this.button1loginbtn);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button button1loginbtn;
        private System.Windows.Forms.Button button2regbtn;
    }
}