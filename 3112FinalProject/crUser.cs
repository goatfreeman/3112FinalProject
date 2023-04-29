using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3112FinalProject {
    public partial class crUser : Form {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public crUser() {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e) {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            if (username.Text != string.Empty || password.Text != string.Empty || passwordConfirm.Text != string.Empty) {
                if(password.Text == passwordConfirm.Text) {
                    cmd = new SqlCommand("select * from LoginTable where username='" + username.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read()) {
                        dr.Close();
                        MessageBox.Show("Username Taken\nTry Login","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable (Id,username,password) values(NEWID(),@username,@password)", cn);
                        cmd.Parameters.AddWithValue("username", username.Text);
                        cmd.Parameters.AddWithValue("password", password.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account created.","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        this.Close();
                    }
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
    }
}
