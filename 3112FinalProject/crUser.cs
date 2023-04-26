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

        }

        private void back_Click(object sender, EventArgs e) {
            this.Close();
            //Form1.show();
        } 
    }
}
