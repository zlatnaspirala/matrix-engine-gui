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

        public ScritpEditor3d(String P, String APP_NAME, MatrixEngineGUI MAINFORM_) {
            InitializeComponent();
            PATH = P + "\\gui\\app.js";
            RES3DFOLDER = P + @"public\res";
            MessageBox.Show(RES3DFOLDER);
            FILEPREVIEW3D.Navigate(RES3DFOLDER);
            StreamReader sr = new StreamReader(PATH);
            CODE_EDITOR.Text = sr.ReadToEnd().ToString();
            sr.Close();
            MAINFORM = MAINFORM_;
        }

        private void ScritpEditor_Load(object sender, EventArgs e) {
            toolTip1.SetToolTip(this.SCRIPT_SRC, "Click to open in file explorer.");
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

            if (typeList.SelectedItem.ToString() == "pyramid") {
                MessageBox.Show("Add color pyramid", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Add color triangle", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Add color square", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Add color cube", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Add color sphereLightTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (typeList.SelectedItem.ToString() == "squareTex") {
                MessageBox.Show("Add color squareTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (typeList.SelectedItem.ToString() == "cubeMapTex") {
                MessageBox.Show("Add color cubeMapTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (typeList.SelectedItem.ToString() == "cubeLightTex") {
                MessageBox.Show("Add color cubeLightTex", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // TEX POTOTYPE
                CODE_EDITOR.SelectedText = "var tex" + addNewObjectFieldName.Text + " = {" +
                    " source: ['res/images/grass1.jpg'], " +
                    " mix_operation: 'multiply'," +
                    "} \n";
                CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "', tex ); \n";
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
            if (FILEPREVIEW3D.CanGoBack == true) {
                FILEPREVIEW3D.GoBack();
            }
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
            } else {
                solidColor.Enabled = false;
                ambientColor.Enabled = true;
            }
        }
    }
}