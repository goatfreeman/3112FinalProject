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
        public string user { get; set; }
        private void Form3_Load(object sender, EventArgs e) {

            userPlate.Text = "Welcome " + user;

            string novelDatabase = "noveldatabase.txt";
            string userFavList = user + "Favlist.txt";
            
            readNovelDatabase(novelDatabase, library);
            readUserFavlist(userFavList, favList);

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

        private void readUserFavlist(string userFavList, ListBox favList) {
            if (!File.Exists(userFavList)) {
                StreamWriter sw1 = File.CreateText(userFavList);
                MessageBox.Show("Favorite List database not found\nPerforming First run Operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                favList.Items.Clear();
                String[] userLibArray1 = File.ReadAllLines(userFavList);
                if (userLibArray1.Length == 0) {
                    favList.Items.Add("No entry found");
                }
                else {
                    foreach (String line in userLibArray1) {
                        string[] novelEntry = line.Split(',');
                        String favListItem = novelEntry[0].Trim();
                        favList.Items.Add(favListItem);
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

        private void refreshFav_Click(object sender, EventArgs e) {
            string userFavList = user + "Favlist.txt";
            favList.Items.Clear();
            String[] libArray1 = File.ReadAllLines(userFavList);
            if (libArray1.Length == 0) {
                favList.Items.Add("No entry found");
            }
            else {
                foreach (String line in libArray1) {
                    string[] favListEntry = line.Split(',');
                    String favListItem = favListEntry[0].Trim();
                    favList.Items.Add(favListItem);
                }
            }

        }

        private void newFavList_Click(object sender, EventArgs e) {
            newUserFavList(listName.Text);
            listName.Text = string.Empty;
        }

        private void newEntry_Click(object sender, EventArgs e) {
            string database = "noveldatabase.txt";
            newEntry newEntry1 = new newEntry();
            newEntry1.ShowDialog();
            newEntry1 = null;
            readNovelDatabase(database, library);
        }

        private void newUserFavList(string listName) {
            string userFavList = user + "Favlist.txt";
            if (listName != string.Empty) {
                //string 
                using (StreamWriter sw1 = new StreamWriter(userFavList, true)) {
                    sw1.WriteLine(listName);
                }               
                readUserFavlist(userFavList, favList);
            }
            else {
                MessageBox.Show("Favorite List Name cannot be empty!\nPlease check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void logout_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            string userFavList = user + "Favlist.txt";
            string option = favList.SelectedItem.ToString();
            string[] read1= File.ReadAllLines(userFavList);
            List<string> updateList = new List<string>();
            foreach (string line in read1) {
                if(line != option) {
                    updateList.Add(line);
                }
            }

            File.WriteAllLines(userFavList, updateList);
            readUserFavlist(userFavList, favList);
        }
    }
}
