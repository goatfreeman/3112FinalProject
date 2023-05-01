using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3112FinalProject {
    public partial class newEntry : Form {
        public newEntry() {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e) {
            if(nameInput.Text != string.Empty || publisherInput.Text != string.Empty) {
                if(linkInput.Text == string.Empty) {
                    linkInput.Text = "null";
                }
                addEntry(nameInput.Text, publisherInput.Text, linkInput.Text);
                this.Close();
            }
            else {
                MessageBox.Show("Entry Cannot be empty!\nPlease check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void addEntry(string name,string publisher,string link) {
            string database = "noveldatabase.txt";
            DateTime currentDate = DateTime.Now;
            string entry = name +","+ publisher +","+ currentDate.ToString("yyyy-MM-dd") + "," + link;
            using (StreamWriter sw1 = new StreamWriter(database,true)) {
                sw1.WriteLine(entry);
            }
        }
    }
}
