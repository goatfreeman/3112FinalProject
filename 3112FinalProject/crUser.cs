using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _3112FinalProject {
    public partial class crUser : Form {

        public object Filestream { get; private set; }

        public crUser() {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            if (username.Text != string.Empty || password.Text != string.Empty || passwordConfirm.Text != string.Empty) {
                if(password.Text == passwordConfirm.Text) {
                    createUser(username.Text,password.Text);
                }
                else {
                    MessageBox.Show("Password and Password confirm mismatch\nPlease re-enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show("Please fill in all required information","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void back_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void createUser(string username, string password) {
            string passDatabase = "passDatabase.txt";
            bool userExists = false;
            if (File.Exists(passDatabase)) {
                string[] lines = File.ReadAllLines(passDatabase);
                foreach (string line in lines) {
                    string[] values = line.Split(',');
                    if (values[0] == username) {
                        userExists = true;
                        break;
                    }
                }
            }
            else {
                using (FileStream create = File.Create(passDatabase)) ;
                MessageBox.Show("Password database not found\nPerforming First run Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!userExists) { 
            using (StreamWriter sw1 = new StreamWriter(passDatabase,true)) {
                sw1.WriteLine($"{username},{password}");
                MessageBox.Show("Account has been created", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
            else {
                MessageBox.Show("Username Taken\nTry Login or use Another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
