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
    public partial class landPage : Form {
        public landPage() {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e) {
            string novelDatabase = "noveldatabase.txt";
                readNovelDatabase(novelDatabase, library);
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }
        private void readNovelDatabase(string database, ListBox library) {
            if (!File.Exists(database)) {
                StreamWriter sw1 = File.CreateText(database);
                MessageBox.Show("Novel database not found\nPerforming First run Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                library.Items.Clear();
                String[] libArray1 = File.ReadAllLines(database);
                if (libArray1.Length == 0) {
                    library.Items.Add("No entry found");
                }
                else {
                    foreach (String line in libArray1) {
                        string[] novelEntry = line.Split(',');
                        String novelName = novelEntry[0].Trim();
                        library.Items.Add(novelName);
                    }
                }
            }
        }

        private void refresh_Click(object sender, EventArgs e) {
            string database = "noveldatabase.txt";
            library.Items.Clear();
            String[] libArray1 = File.ReadAllLines(database);
            if (libArray1.Length == 0) {
                library.Items.Add("No entry found");
            }
            else {
                foreach (String line in libArray1) {
                    string[] novelEntry = line.Split(',');
                    String novelName = novelEntry[0].Trim();
                    library.Items.Add(novelName);
                }
            }
        }

        private void newEntry_Click(object sender, EventArgs e) {
            newEntry newEntry1 = new newEntry();
            newEntry1.ShowDialog();
        }
    }
}
