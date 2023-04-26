using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3112FinalProject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string user;
            string pw;
            user = userName.Text;
            pw = password.Text;
            label1.Text = user;
            checkLogin(user,pw);
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        private void checkLogin(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }
    }
}
