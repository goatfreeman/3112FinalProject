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
using System.IO;

namespace _3112FinalProject {
    public partial class landPage : Form {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public landPage() {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e) {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            cn.Open();
            try {
                if (File.Exists("noveldatabase.txt")) {

                }
                else {
                    using (FileStream fs1 = File.Create("noveldatabase.txt"));
                    MessageBox.Show("Database not found!\nCreating new Database", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception Ex) {
                Console.WriteLine(Ex.ToString());
            }


        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
