namespace _3112FinalProject {
    partial class landPage {
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
            this.components = new System.ComponentModel.Container();
            this.userPlate = new System.Windows.Forms.Label();
            this.library = new System.Windows.Forms.ListBox();
            this.favList = new System.Windows.Forms.ListBox();
            this.favListItems = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.newFavList = new System.Windows.Forms.Button();
            this.removeList = new System.Windows.Forms.Button();
            this.listName = new System.Windows.Forms.TextBox();
            this.newEntry = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.refreshFav = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userPlate
            // 
            this.userPlate.AutoSize = true;
            this.userPlate.Location = new System.Drawing.Point(11, 9);
            this.userPlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userPlate.Name = "userPlate";
            this.userPlate.Size = new System.Drawing.Size(52, 13);
            this.userPlate.TabIndex = 0;
            this.userPlate.Text = "Welcome";
            this.userPlate.Click += new System.EventHandler(this.label1_Click);
            // 
            // library
            // 
            this.library.FormattingEnabled = true;
            this.library.Location = new System.Drawing.Point(14, 64);
            this.library.Name = "library";
            this.library.Size = new System.Drawing.Size(228, 290);
            this.library.TabIndex = 1;
            this.library.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // favList
            // 
            this.favList.FormattingEnabled = true;
            this.favList.Location = new System.Drawing.Point(404, 64);
            this.favList.Name = "favList";
            this.favList.Size = new System.Drawing.Size(187, 290);
            this.favList.TabIndex = 2;
            this.favList.SelectedIndexChanged += new System.EventHandler(this.favList_SelectedIndexChanged);
            // 
            // favListItems
            // 
            this.favListItems.FormattingEnabled = true;
            this.favListItems.Location = new System.Drawing.Point(749, 64);
            this.favListItems.Name = "favListItems";
            this.favListItems.Size = new System.Drawing.Size(239, 290);
            this.favListItems.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Library";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add to list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(994, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Remove from list";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // newFavList
            // 
            this.newFavList.Location = new System.Drawing.Point(596, 143);
            this.newFavList.Name = "newFavList";
            this.newFavList.Size = new System.Drawing.Size(131, 37);
            this.newFavList.TabIndex = 10;
            this.newFavList.Text = "Add new list";
            this.newFavList.UseVisualStyleBackColor = true;
            this.newFavList.Click += new System.EventHandler(this.newFavList_Click);
            // 
            // removeList
            // 
            this.removeList.Location = new System.Drawing.Point(596, 240);
            this.removeList.Name = "removeList";
            this.removeList.Size = new System.Drawing.Size(131, 37);
            this.removeList.TabIndex = 9;
            this.removeList.Text = "Remove list";
            this.removeList.UseVisualStyleBackColor = true;
            this.removeList.Click += new System.EventHandler(this.button5_Click);
            // 
            // listName
            // 
            this.listName.Location = new System.Drawing.Point(597, 117);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(130, 20);
            this.listName.TabIndex = 11;
            // 
            // newEntry
            // 
            this.newEntry.Location = new System.Drawing.Point(17, 360);
            this.newEntry.Name = "newEntry";
            this.newEntry.Size = new System.Drawing.Size(225, 23);
            this.newEntry.TabIndex = 12;
            this.newEntry.Text = "New Entry";
            this.newEntry.UseVisualStyleBackColor = true;
            this.newEntry.Click += new System.EventHandler(this.newEntry_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(248, 211);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 13;
            this.refresh.Text = "Refresh List";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // refreshFav
            // 
            this.refreshFav.Location = new System.Drawing.Point(597, 186);
            this.refreshFav.Name = "refreshFav";
            this.refreshFav.Size = new System.Drawing.Size(131, 48);
            this.refreshFav.TabIndex = 14;
            this.refreshFav.Text = "Refresh List";
            this.refreshFav.UseVisualStyleBackColor = true;
            this.refreshFav.Click += new System.EventHandler(this.refreshFav_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(994, 4);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 15;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // landPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 434);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.refreshFav);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.newEntry);
            this.Controls.Add(this.listName);
            this.Controls.Add(this.newFavList);
            this.Controls.Add(this.removeList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.favListItems);
            this.Controls.Add(this.favList);
            this.Controls.Add(this.library);
            this.Controls.Add(this.userPlate);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "landPage";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userPlate;
        private System.Windows.Forms.ListBox library;
        private System.Windows.Forms.ListBox favList;
        private System.Windows.Forms.ListBox favListItems;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button newFavList;
        private System.Windows.Forms.Button removeList;
        private System.Windows.Forms.TextBox listName;
        private System.Windows.Forms.Button newEntry;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button refreshFav;
        private System.Windows.Forms.Button logout;
    }
}