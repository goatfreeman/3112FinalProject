namespace _3112FinalProject {
    partial class newEntry {
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
            this.cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.publisherInput = new System.Windows.Forms.TextBox();
            this.linkInput = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(511, 291);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(615, 291);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 1;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(44, 106);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(66, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Novel Name";
            // 
            // publisher
            // 
            this.publisher.AutoSize = true;
            this.publisher.Location = new System.Drawing.Point(60, 151);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(50, 13);
            this.publisher.TabIndex = 3;
            this.publisher.Text = "Publisher";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(116, 106);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(556, 20);
            this.nameInput.TabIndex = 4;
            // 
            // publisherInput
            // 
            this.publisherInput.Location = new System.Drawing.Point(116, 148);
            this.publisherInput.Name = "publisherInput";
            this.publisherInput.Size = new System.Drawing.Size(556, 20);
            this.publisherInput.TabIndex = 5;
            // 
            // linkInput
            // 
            this.linkInput.Location = new System.Drawing.Point(116, 188);
            this.linkInput.Name = "linkInput";
            this.linkInput.Size = new System.Drawing.Size(556, 20);
            this.linkInput.TabIndex = 7;
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(44, 191);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(64, 13);
            this.link.TabIndex = 6;
            this.link.Text = "Link to MAL";
            // 
            // newEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 367);
            this.Controls.Add(this.linkInput);
            this.Controls.Add(this.link);
            this.Controls.Add(this.publisherInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.name);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.cancel);
            this.Name = "newEntry";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox publisherInput;
        private System.Windows.Forms.TextBox linkInput;
        private System.Windows.Forms.Label link;
    }
}