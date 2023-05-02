using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _3112FinalProject {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        public string user { get; set; }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            if (userName.Text != string.Empty || password.Text != string.Empty) {
                if (userLogin(userName.Text,password.Text)) {
                    this.Hide();
                    landPage landpage1 = new landPage();
                    landpage1.user = userName.Text;
                    landpage1.ShowDialog();
                    landpage1 = null;
                    userName.Text = string.Empty;
                    password.Text = string.Empty;
                    this.Show();    
                }
                else {
                    MessageBox.Show("Username Incorrect or not found\nPlease Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Please enter a username and password to login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e) {

            this.Hide();
            crUser crUser1 =new crUser();   
            crUser1.ShowDialog();
            crUser1 = null;
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        
        private void checkLogin(object sender, EventArgs e) {

        }

        private void userName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {

        }

        private bool userLogin(string username, string password) {
            string passDatabase = "passDatabase.txt";
            string[] read1 = File.ReadAllLines(passDatabase); 
            foreach (string line in read1) {
                string[] array1 = line.Split(',');
                if (array1[0] == username && array1[1] == password) {
                    return true;
                }
            }
            return false;
        }
        
    }
}
