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
    public partial class Form1 : Form {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=~\3112FinalProject\3112FinalProject\Database1.mdf;Integrated Security=True");
            cn.Open();
        }
        private void button1_Click(object sender, EventArgs e) {
            if (userName.Text == "admin" && password.Text == "admin") {
                new Form3().Show();
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
            new Form2().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        
        private void checkLogin(object sender, EventArgs e) {

        }

        
    }
}
