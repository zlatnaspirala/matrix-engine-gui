using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix_engine {
    public partial class ScritpEditor3d : Form {
        MatrixEngineGUI MAINFORM;
        public string PATH = "";
        public CmdWindowControlTestApp.Android cmdVJS3WATCH;
        Boolean PREVENT_SAVE = false;
        public string RES3DFOLDER = "";
        public string RES3DFOLDER_IMGS = "";
        public string texFilesLocation = "";

        public ScritpEditor3d(String P, String APP_NAME, MatrixEngineGUI MAINFORM_) {
            InitializeComponent();
            PATH = P + "\\gui\\app.js";
            RES3DFOLDER = P + @"public\res";
            RES3DFOLDER_IMGS = P + @"public\res\images";
            MessageBox.Show(RES3DFOLDER);
  
            StreamReader sr = new StreamReader(PATH);
            CODE_EDITOR.Text = sr.ReadToEnd().ToString();
            sr.Close();
            MAINFORM = MAINFORM_;

            string[] files = Directory.GetFiles(RES3DFOLDER_IMGS);
            string[] subsFolders = Directory.GetDirectories(RES3DFOLDER_IMGS);
            foreach (string item in subsFolders) {
                DirectoryInfo dir = new DirectoryInfo(item);
                justFolders.Items.Add(dir.Name);
            }

            foreach (string item in files) {
                FileInfo file = new FileInfo(item);
                imageList1.Images.Add("Key" + file.Name, Image.FromFile(file.ToString()));
                listView1.LargeImageList = imageList1;
                var listViewItem = listView1.Items.Add(file.Name);
                listViewItem.ImageKey = "Key" + file.Name;
            }
        }

        private void ScritpEditor_Load(object sender, EventArgs e) {
            toolTip1.SetToolTip(this.SCRIPT_SRC, "Click to open in file explorer.");

            this.SetAutoScrollMargin(100, 100);
            foreach (Control ctrl in CODE_EDITOR.Controls)
                if (ctrl.GetType() == typeof(VScrollBar))
                    ctrl.Width = 100;
        }

        public void test(object sender, EventArgs e) {
            // MessageBox.Show("Matrix-engine project js pack builded.", "Status good");
            PREVENT_SAVE = false;
            MAINFORM.button2.PerformClick();
        }
        private void saveBtn_Click(object sender, EventArgs e) {
            if (PREVENT_SAVE == false) {
                PREVENT_SAVE = true;
                try {
                    string TEXTURE_JS_FILE = PATH;
                    string PACKAGE_CONTENT = CODE_EDITOR.Text;
                    File.WriteAllText(TEXTURE_JS_FILE, PACKAGE_CONTENT);
                    Thread.Sleep(100);
                    if (MAINFORM.cmdWebglRun != null && MAINFORM.cmdWebglRun.IsDisposed == false) {
                        MAINFORM.cmdWebglRun.buildgui.Text = "";
                        MAINFORM.cmdWebglRun.buildgui.TextChanged += test;
                        MAINFORM.cmdWebglRun.btnSendStdinToProcess.PerformClick();
                    }
                } catch (Exception err) {
                    MessageBox.Show("Matrix-Engine GUI: " + err.ToString(), "ERROR IN SAVE PROCEDURE, TRY AGAIN!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PREVENT_SAVE = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void SCRIPT_SRC_Click(object sender, EventArgs e) {
            SCRIPT_SRC.Text = SCRIPT_SRC.Text.Replace("gui-texture-editor.js", "");
            if (Directory.Exists(SCRIPT_SRC.Text)) {
                ProcessStartInfo startInfo = new ProcessStartInfo {
                Arguments = SCRIPT_SRC.Text,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
            } else {
                MessageBox.Show(string.Format("{0} Directory does not exist!", SCRIPT_SRC.Text));
            }
        }

        private void addNewCubeToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.Clear();
            POSITION.SetTitleText("Position");
            initialRotation.SetTitleText("Rotation");
            activeRotation.SetTitleText("Active rotation");
            solidColor.SetTitleText("All object faces color");
            ambientColor.SetTitleText("Ambient Color");
            typeList.SelectedIndex = 0;
            helpPanelAddNewObject.Visible = true;
        }

        private void helpAddNewGameObjectBTN_Click(object sender, EventArgs e) {
            if (addNewObjectFieldName.Text == "") {
                MessageBox.Show("Please add name parameter.", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (typeList.SelectedItem.ToString() == "") {
                MessageBox.Show("Please select type of game object.", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // test tex
            string text_paths = "";
            var selectedTags = listView1.CheckedItems
                                 .Cast<ListViewItem>()
                                 .Select(x => x.Text);
            int CounterTex = 0;
            foreach (var tag in selectedTags) {
                // do some operation using tag
                if (justFolders.SelectedItems.Count > -1 && justFolders.SelectedItems.Count > 0 && justFolders.SelectedItems!= null) {
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


            if (typeList.SelectedItem.ToString() == "pyramid") {
                MessageBox.Show("Add color pyramid", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // CLOR PROTOTYPE
                 CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "'); \n";
                CODE_EDITOR.SelectedText = " App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";";
                }

                CODE_EDITOR.Paste();
            } else if (typeList.SelectedItem.ToString() == "triangle") {
                MessageBox.Show("Add color triangle", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // CLOR PROTOTYPE
                CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "'); \n";
                CODE_EDITOR.SelectedText = " App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";";
                }

                CODE_EDITOR.Paste();
            } else if (typeList.SelectedItem.ToString() == "square") {
                MessageBox.Show("Add color square", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // CLOR PROTOTYPE
                CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "'); \n";
                CODE_EDITOR.SelectedText = " App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";";
                }

                CODE_EDITOR.Paste();
            } else if (typeList.SelectedItem.ToString() == "cube") {
                MessageBox.Show("Add color cube", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // CLOR PROTOTYPE
                CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "'); \n";
                CODE_EDITOR.SelectedText = " App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";";
                }

                CODE_EDITOR.Paste();
            } else if (typeList.SelectedItem.ToString() == "sphereLightTex") {
                MessageBox.Show("Add color sphereLightTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (typeList.SelectedItem.ToString() == "squareTex") {
                MessageBox.Show("Add color squareTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (typeList.SelectedItem.ToString() == "cubeMapTex") {
                MessageBox.Show("Add color cubeMapTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (typeList.SelectedItem.ToString() == "cubeLightTex") {
                MessageBox.Show("Add color cubeLightTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TEX POTOTYPE
                CODE_EDITOR.SelectedText = "var tex" + addNewObjectFieldName.Text + " = {" +
                    " source: [" +
                    text_paths
                    + "], " +
                    " mix_operation: 'multiply'," +
                    "} \n";
                CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "', tex" + addNewObjectFieldName.Text + " ); \n";
                CODE_EDITOR.SelectedText = " App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";";
                }

                CODE_EDITOR.Paste();

            } else if (typeList.SelectedItem.ToString() == "obj") {
                MessageBox.Show("Add color obj", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            helpPanelAddNewObject.Visible = false;

            /*  triangle
                square
                squareTex
                cube
                sphereLightTex
                pyramid
                obj
                cubeLightTex
                cubeMapTex
                generatorLightTex */
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void initialScale_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void helpPanelAddNewObject_Paint(object sender, PaintEventArgs e) {

        }

        private void back_Click(object sender, EventArgs e) {
        
        }

        private void positionControl_Load(object sender, EventArgs e) {
            // positionControl
        }

        private void button2_Click(object sender, EventArgs e) {
            helpPanelAddNewObject.Hide();
        }

        private void resetToDefault_Click(object sender, EventArgs e) {
            addNewObjectFieldName.Text = "";
            POSITION.SetX(0);
            POSITION.SetY(0);
            POSITION.SetZ(0);
            initialScale.Text = "1";
        }

        private void typeList_SelectedIndexChanged(object sender, EventArgs e) {
            // MessageBox.Show("SELCT TYPE CHANGE" + typeList.SelectedItem.ToString() , "Matrix-Engine Add new object procedure");
            if (typeList.SelectedItem.ToString() == "cube" || typeList.SelectedItem.ToString() == "triangle" ||
                 typeList.SelectedItem.ToString() == "square" || typeList.SelectedItem.ToString() == "pyramid") {
                solidColor.Enabled = true;
                ambientColor.Enabled = false;

                ChooseTexturesLabel.Visible = false;
                listView1.Visible = false;
                justFolders.Visible = false;

            } else {
                solidColor.Enabled = false;
                ambientColor.Enabled = true;

                ChooseTexturesLabel.Visible = true;
                listView1.Visible = true;
                justFolders.Visible = true;


            }
        }

        private void CODE_EDITOR_TextChanged(object sender, EventArgs e) {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {
            if (justFolders.SelectedItems.Count > 0 && justFolders.SelectedItems[0] != null) {
                MessageBox.Show(justFolders.SelectedItems[0].Text);
            }
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

        private void listView1_ItemActivate(object sender, EventArgs e) {
            MessageBox.Show("ITEM ACTIVATE");
        }
    }
}