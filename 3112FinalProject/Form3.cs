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
    public partial class Form3 : Form {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public Form3() {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e) {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Matthew\Documents\Visual Studio 2022\Code\3112FinalProject\3112FinalProject\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
