using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3112FinalProject {
    public partial class Login : Form {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Login() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (userName.Text == "admin" && password.Text == "admin") {
                new landPage().Show();
                this.Hide();
            }
            else {
                MessageBox.Show("User not found or Passowrd incorrect\nPlease Try again!");
                userName.Clear();
                password.Clear();
                userName.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e) {

            this.Hide();
            crUser form1 =new crUser();   
            form1.ShowDialog();
            form1 = null;
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        
        private void checkLogin(object sender, EventArgs e) {

        }

        
    }
}
