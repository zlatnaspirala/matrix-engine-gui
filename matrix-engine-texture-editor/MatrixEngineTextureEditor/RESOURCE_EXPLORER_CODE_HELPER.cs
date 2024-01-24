using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix_engine {
    public partial class RESOURCE_EXPLORER_CODE_HELPER : UserControl {

        string RES3DFOLDER_IMGS = "";
        public string texFilesLocation = "";
        public RESOURCE_EXPLORER_CODE_HELPER() {
            InitializeComponent();
        }

        private void RESOURCE_EXPLORER_CODE_HELPER_Load(object sender, EventArgs e) {

        }

        public void loadFolder(string RES3DFOLDER) {
            justFolders.Items.Clear();
            imageList1.Images.Clear();
            listView1.Items.Clear();
            RES3DFOLDER_IMGS = RES3DFOLDER;
            string[] files = Directory.GetFiles(RES3DFOLDER);
            string[] subsFolders = Directory.GetDirectories(RES3DFOLDER);
            foreach (string item in subsFolders) {
                DirectoryInfo dir = new DirectoryInfo(item);
                justFolders.Items.Add(dir.Name);
            }
            foreach (string item in files) {
                FileInfo file = new FileInfo(item);
                //
                try {
                    imageList1.Images.Add("Key" + file.Name, Image.FromFile(file.ToString()));
                    listView1.LargeImageList = imageList1;
                    var listViewItem = listView1.Items.Add(file.Name);
                    listViewItem.ImageKey = "Key" + file.Name;
                } catch (Exception _) {
                    FileInfo file2 = new FileInfo(item);
                    listView1.Items.Add(file2.Name);
                }
            }
        }
        public string getResourceSrc() {
            string text_paths = "";
            var selectedTags = listView1.CheckedItems
                                 .Cast<ListViewItem>()
                                 .Select(x => x.Text);
            int CounterTex = 0;
            foreach (var tag in selectedTags) {
                // do some operation using tag
                if (justFolders.SelectedItems.Count > -1 && justFolders.SelectedItems.Count > 0 && justFolders.SelectedItems != null) {
                    Int32 INDEX = 0;
                    MessageBox.Show(justFolders.SelectedItems[INDEX].Text + @"\" + tag.ToString());
                    if (CounterTex == 0) {
                        text_paths += "'" + justFolders.SelectedItems[INDEX].Text + @"\" + tag.ToString() + "'";
                    } else {
                        text_paths += ", '" + justFolders.SelectedItems[INDEX].Text + @"\" + tag.ToString() + "'";
                    }
                } else {
                    MessageBox.Show("<root folder> " + tag.ToString());
                    if (CounterTex == 0) {
                        text_paths += "'" + @"\" + tag.ToString() + "'";
                    } else {
                        text_paths += ", '" + @"\" + tag.ToString() + "'";
                    }
                }
                CounterTex = CounterTex + 1;
            }
            return text_paths;
        }

        private void justFolders_SelectedIndexChanged(object sender, EventArgs e) {
            if (justFolders.SelectedItems.Count == -1 || justFolders.SelectedItems.Count == 0) { return; }
            texFilesLocation = RES3DFOLDER_IMGS + "\\" + justFolders.SelectedItems[0].Text;
            listView1.Items.Clear();
            imageList1.Images.Clear();
            string[] files = Directory.GetFiles(texFilesLocation);
            foreach (string item in files) {
                FileInfo file = new FileInfo(item);
                imageList1.Images.Add("Key" + file.Name, Image.FromFile(file.ToString()));
                listView1.LargeImageList = imageList1;
                var listViewItem = listView1.Items.Add(file.Name);
                listViewItem.ImageKey = "Key" + file.Name;
            }
        }
    }
}
