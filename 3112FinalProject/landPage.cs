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
using System.Windows.Markup;

namespace _3112FinalProject {
    public partial class landPage : Form {
        public landPage() {
            InitializeComponent();
        }
        public string user { get; set; }
        public string novelSelected { get; set; }
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
            if (library.SelectedItem == null) {
                MessageBox.Show("Please choose a novel before proceeding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (favList.SelectedItem == null) {
                MessageBox.Show("Please choose a list before proceeding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userFavList = user + "Favlist.txt";
            string selectedNovel = library.SelectedItem.ToString();
            string selectedListOption = favList.SelectedItem.ToString();
            string[] favEntry = File.ReadAllLines(userFavList);

            int index = -1;

            for(int i = 0; i < favEntry.Length; i++) {
                string[] values = favEntry[i].Split(':');
                if (values[0] == selectedListOption) {
                    index = i;
                    break;
                }
            }
            if(index == -1) {
                string newListContent = $"{selectedListOption}:{selectedNovel}";
                File.AppendAllText(userFavList,Environment.NewLine + newListContent);
                MessageBox.Show(selectedNovel + " has been added to " + selectedListOption + "list.");
            }
            else {
                string[] novels = favEntry[index].Split(':');
                string[] addedNoveles = novels[1].Split(',');
                
                if(addedNoveles.Length == 1 && addedNoveles[0] == "") {
                    addedNoveles = new string[] { selectedNovel };
                }
                else if (!addedNoveles.Contains(selectedNovel)) {
                    addedNoveles = addedNoveles.Append(selectedNovel).ToArray();
                }
                else {
                    MessageBox.Show(selectedNovel + " has previously been added to " + selectedListOption + "list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string updatedNovels = $"{novels[0]}:{string.Join(",",addedNoveles)}" ;
                favEntry[index] = updatedNovels;

                File.WriteAllLines(userFavList, favEntry);
                MessageBox.Show(selectedNovel + " has been added to " + selectedListOption + "list.", "complete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                readFavlist(userFavList, selectedListOption, favListItems);
            }
            
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
                        string[] novelEntry = line.Split(':');
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
                    string[] favListEntry = line.Split(':');
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
        private void logout_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            string userFavList = user + "Favlist.txt";
            string option = favList.SelectedItem.ToString();
            string[] read1 = File.ReadAllLines(userFavList);
            List<string> updateList = new List<string>();
            bool foundList = false;
            foreach (string line in read1) {
                string[] name = line.Split(':');
                if(name.Length == 2) {
                    string listName = name[0];
                    if (listName == option) {
                        foundList = true;
                        DialogResult result = MessageBox.Show("Are you sure you want to delete this list", "Confirm Delete", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes) {
                            continue;

                        }
                    }
                }
                updateList.Add(line);
            }

            File.WriteAllLines(userFavList, updateList);
            readUserFavlist(userFavList, favList);
            favListItems.Items.Clear();

        }

        private void favList_SelectedIndexChanged(object sender, EventArgs e) {
            string userFavList = user + "Favlist.txt";
            if(favList.SelectedItem != null) {
                string chooseList = favList.SelectedItem.ToString();
                readFavlist(userFavList, chooseList, favListItems);
            }
        }
        private void button3_Click(object sender, EventArgs e) {
            string userFavList = user + "Favlist.txt";
            if (favList.SelectedItem != null) {
                rmFavNovel(favList.SelectedItem.ToString(), favListItems.SelectedItem.ToString(), userFavList);
                string chooseList = favList.SelectedItem.ToString();
                readFavlist(userFavList, chooseList, favListItems);
            }
        }

        private void newUserFavList(string listName) {
            string userFavList = user + "Favlist.txt";
            bool listNameUsed = false;
            if (listName != string.Empty) {
                //string
                string[] favEntry = File.ReadAllLines(userFavList);
                foreach (string line in favEntry) {
                    string[] values = line.Split(':');
                    if (values[0] == listName) {
                        listNameUsed = true;
                        break;
                    }
                }
                if (!listNameUsed) {
                    using (StreamWriter sw1 = new StreamWriter(userFavList, true)) {
                        sw1.WriteLine($"{listName}:");
                    }
                    readUserFavlist(userFavList, favList);
                }
                else {
                    MessageBox.Show("Duplicate List name found!\nPlease use another list Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else {
                MessageBox.Show("Favorite List Name cannot be empty!\nPlease check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void readFavlist(string userFavList ,string userSelectedFavList, ListBox favListItems) {
            favListItems.Items.Clear();
            string[] favEntry = File.ReadAllLines(userFavList);
            if (favEntry.Length == 0) {
                favListItems.Items.Add("No Entries");
            }
            else {
                foreach (string line in favEntry) {
                    string[] name = line.Split(':');
                    if(name.Length == 2 && name[0] == userSelectedFavList) {
                        string[] novels = name[1].Split(',');
                        foreach (string novel in novels) {
                            favListItems.Items.Add(novel.Trim());
                        }
                        break;
                    }
                }
            }
        }

        private void rmFavNovel(string favList ,string selected ,string userFavList) {
            
            string[] lines = File.ReadAllLines(userFavList);
            List<string> updatedList = new List<string>();

            foreach(string line in lines) {
                string[] name = line.Split(':');
                if (name[0] == favList) {
                    string[] items = name[1].Split(',');
                    List<string> updateItems = new List<string>();
                    foreach(string item in items) {
                        if(item.Trim() != selected) {
                            updateItems.Add(item.Trim());
                        }
                    }
                    if(updateItems.Count > 0) {
                        updatedList.Add(name[0] + ":" + string.Join(",", updateItems));
                    }
                }
                else {
                    updatedList.Add(line);
                }
            }
            File.WriteAllLines(userFavList, updatedList);
        }               
    }
}
