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
            if (userName.Text != string.Empty || password.Text != string.Empty) {

                cmd = new SqlCommand("select * from LoginTable where username='" + userName.Text + "' and password='" + password.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read()) {
                    dr.Close();
                    this.Hide();
                    landPage landpage1 = new landPage();
                    landpage1.ShowDialog();
                }
                else {
                    dr.Close();
                    MessageBox.Show("No Account found or incorrect Username or Password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
