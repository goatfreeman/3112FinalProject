namespace _3112FinalProject {
    partial class Login {
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
            this.button1 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.userName = new System.Windows.Forms.MaskedTextBox();
            this.unLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.createAcc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(318, 206);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(207, 20);
            this.password.TabIndex = 2;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(318, 181);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(208, 20);
            this.userName.TabIndex = 1;
            this.userName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.userName_MaskInputRejected);
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(254, 184);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(58, 13);
            this.unLabel.TabIndex = 3;
            this.unLabel.Text = "Username:";
            this.unLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(254, 209);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(56, 13);
            this.pwLabel.TabIndex = 4;
            this.pwLabel.Text = "Password:";
            // 
            // createAcc
            // 
            this.createAcc.Location = new System.Drawing.Point(403, 262);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(123, 23);
            this.createAcc.TabIndex = 5;
            this.createAcc.Text = "Create account";
            this.createAcc.UseVisualStyleBackColor = true;
            this.createAcc.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.unLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.MaskedTextBox userName;
        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Button createAcc;
    }
}

