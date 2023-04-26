namespace _3112FinalProject {
    partial class Form2 {
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.crUsername = new System.Windows.Forms.Label();
            this.pw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.createConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 181);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 22);
            this.textBox1.TabIndex = 0;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(447, 239);
            this.t.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(288, 22);
            this.t.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(447, 305);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 22);
            this.textBox2.TabIndex = 2;
            // 
            // crUsername
            // 
            this.crUsername.AutoSize = true;
            this.crUsername.Location = new System.Drawing.Point(291, 181);
            this.crUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crUsername.Name = "crUsername";
            this.crUsername.Size = new System.Drawing.Size(138, 16);
            this.crUsername.TabIndex = 3;
            this.crUsername.Text = "Enter Your Username:";
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Location = new System.Drawing.Point(364, 239);
            this.pw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(70, 16);
            this.pw.TabIndex = 4;
            this.pw.Text = "Password:";
            this.pw.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your password again:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(368, 390);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 28);
            this.back.TabIndex = 6;
            this.back.Text = "Return";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // createConfirm
            // 
            this.createConfirm.Location = new System.Drawing.Point(536, 390);
            this.createConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createConfirm.Name = "createConfirm";
            this.createConfirm.Size = new System.Drawing.Size(200, 28);
            this.createConfirm.TabIndex = 7;
            this.createConfirm.Text = "Confirm Create Account";
            this.createConfirm.UseVisualStyleBackColor = true;
            this.createConfirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.createConfirm);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.crUsername);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.t);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label crUsername;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button createConfirm;
    }
}