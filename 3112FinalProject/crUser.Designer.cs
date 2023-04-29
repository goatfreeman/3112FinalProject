namespace _3112FinalProject {
    partial class crUser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.passwordConfirm = new System.Windows.Forms.TextBox();
            this.crUsername = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.createConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(335, 147);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(217, 20);
            this.username.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(335, 194);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(217, 20);
            this.password.TabIndex = 1;
            // 
            // passwordConfirm
            // 
            this.passwordConfirm.Location = new System.Drawing.Point(335, 248);
            this.passwordConfirm.Name = "passwordConfirm";
            this.passwordConfirm.Size = new System.Drawing.Size(217, 20);
            this.passwordConfirm.TabIndex = 2;
            // 
            // crUsername
            // 
            this.crUsername.AutoSize = true;
            this.crUsername.Location = new System.Drawing.Point(218, 147);
            this.crUsername.Name = "crUsername";
            this.crUsername.Size = new System.Drawing.Size(111, 13);
            this.crUsername.TabIndex = 3;
            this.crUsername.Text = "Enter Your Username:";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(273, 194);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(56, 13);
            this.pw.TabIndex = 4;
            this.pw.Text = "Password:";
            this.pw.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your password again:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(276, 317);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 6;
            this.back.Text = "Return";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // createConfirm
            // 
            this.createConfirm.Location = new System.Drawing.Point(402, 317);
            this.createConfirm.Name = "createConfirm";
            this.createConfirm.Size = new System.Drawing.Size(150, 23);
            this.createConfirm.TabIndex = 7;
            this.createConfirm.Text = "Confirm Create Account";
            this.createConfirm.UseVisualStyleBackColor = true;
            this.createConfirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // crUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createConfirm);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.crUsername);
            this.Controls.Add(this.passwordConfirm);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "crUser";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox passwordConfirm;
        private System.Windows.Forms.Label crUsername;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button createConfirm;
    }
}