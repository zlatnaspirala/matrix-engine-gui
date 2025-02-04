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
using System.Media;
using System.Collections.Specialized;

namespace matrix_engine {
    public partial class ScritpEditor3d : Form {
        MatrixEngineGUI MAINFORM;
        public string PATH = "";
        public CmdWindowControlTestApp.Android cmdVJS3WATCH;
        Boolean PREVENT_SAVE = false;
        public string RES3DFOLDER = "";
        public string RES3DFOLDER_IMGS = "";
        public string RES3DFOLDER_VIDEOS = "";
        public string texFilesLocation = "";

        public ScritpEditor3d(String P, String APP_NAME, MatrixEngineGUI MAINFORM_) {
            InitializeComponent();
            PATH = P + "\\gui\\app.js";
            RES3DFOLDER = P + @"public\res";
            RES3DFOLDER_IMGS = P + @"public\res\images";
            RES3DFOLDER_VIDEOS = P + @"public\res\video-texture";
            StreamReader sr = new StreamReader(PATH);
            CODE_EDITOR.Text = sr.ReadToEnd().ToString();
            sr.Close();
            MAINFORM = MAINFORM_;
            RES_IMGS.loadFolder(RES3DFOLDER_IMGS);
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

            string text_paths = RES_IMGS.getResourceSrc();
            text_paths = text_paths.Replace(@"\", "/");
            text_paths = text_paths.Replace("'", "");

 
        

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
                CODE_EDITOR.SelectedText = "  world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "'); \n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + "); \n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";\n";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";\n";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";\n";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";\n";
                }

                CODE_EDITOR.Paste();
            } else if (typeList.SelectedItem.ToString() == "square") {
                MessageBox.Show("Add color square", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // CLOR PROTOTYPE
                CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "'); \n";
                CODE_EDITOR.SelectedText = " App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");\n";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";\n";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";\n";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";\n";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";\n";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";\n";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";\n";
                }

                CODE_EDITOR.Paste();
            } else if (typeList.SelectedItem.ToString() == "cube") {
                MessageBox.Show("Add color cube", "3d Code editor - Add new object form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // CLOR PROTOTYPE
                CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "'); \n";
                CODE_EDITOR.SelectedText = " App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");\n";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";\n";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";\n";
                CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";\n";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";\n";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";\n";
                    CODE_EDITOR.SelectedText = "App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";\n";
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

                // streaming tex
                if (STREAM_TEXTURES_CHECK_CAMERA.Checked == true) {
                    // camera
                    // TEX POTOTYPE default
                    CODE_EDITOR.SelectedText = " var tex" + addNewObjectFieldName.Text + " = {" +
                        "  source: ['res/images/default/default-pink-64.png'],\n" +
                        "  mix_operation: 'multiply'\n" +
                        " }\n";
                    CODE_EDITOR.SelectedText = "  world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "', tex" + addNewObjectFieldName.Text + " ); \n";
                    CODE_EDITOR.SelectedText = "  let ACCESS_CAMERA = matrixEngine.Engine.ACCESS_CAMERA;\n";
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".streamTextures = new ACCESS_CAMERA('webcam_beta');\n";
                    // byId('webcam_beta').style.display = 'block';
                    // Example who to switch between simple camera tex and cameraMixCanvas2d (videoImage)
                    // App.scene.TV.streamTextures.video = App.scene.TV.streamTextures.videoImage;
                } else if (STREAM_TEXTURES_CHECK_VIDEO.Checked == true) {
                    // VIDEO
                    // TEX POTOTYPE default
                    CODE_EDITOR.SelectedText = " var tex" + addNewObjectFieldName.Text + " = {" +
                        "  source: ['res/images/default/default-pink-64.png'],\n" +
                        "  mix_operation: 'multiply'\n" +
                        " }\n";
                    CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "', tex" + addNewObjectFieldName.Text + " ); \n";
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".streamTextures = new matrixEngine.Engine.VT('./res/video-texture" + text_paths + "');\n";
                } else if (STREAM_TEXTURES_CHECK_CANVAS.Checked == true) {
                    // CANVAS 
                    // TEX POTOTYPE default
                    CODE_EDITOR.SelectedText = " var tex" + addNewObjectFieldName.Text + " = {" +
                        "  source: ['res/images/default/default-pink-64.png'],\n" +
                        "  mix_operation: 'multiply'\n" +
                        " }\n";
                    CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "', tex" + addNewObjectFieldName.Text + " ); \n";

                    // CANVAS_TEXTURE_URL
                    // App.scene.outsideBox.streamTextures = new anyCanvas("../2DTextureEditor/templates/slot/", "HELLO_WORLD")
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".streamTextures = new matrixEngine.Engine.anyCanvas('" + CANVAS_TEXTURE_URL.Text + "', 'HELLO_WORLD');\n";
                    CODE_EDITOR.SelectedText = "   App.scene." + addNewObjectFieldName.Text + ".streamTextures.showTextureEditor();";



                } else {

                    // normala tex
                    // TEX POTOTYPE
                    CODE_EDITOR.SelectedText = "var tex" + addNewObjectFieldName.Text + " = {" +
                        " source: ['res/images/" +
                        text_paths
                        + "'],\n" +
                        " mix_operation: 'multiply'" +
                        "} \n";
                    CODE_EDITOR.SelectedText = "world.Add('" + typeList.SelectedItem.ToString() + "', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "', tex" + addNewObjectFieldName.Text + " ); \n";

                }

                // position etc...
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";\n";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";\n";
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";\n";
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";\n";
                }

                CODE_EDITOR.Paste();

            } else if (typeList.SelectedItem.ToString() == "obj") { 

                OBJ_PATH.Enabled = true;
                MessageBox.Show("Add obj", "3d Code editor - Add new obj form", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // streaming tex
                // normala tex
                // TEX POTOTYPE
                CODE_EDITOR.SelectedText = "var tex" + addNewObjectFieldName.Text + " = {" +
                    " source: ['res/images/" +
                    text_paths
                    + "'],\n" +
                    " mix_operation: 'multiply'" +
                    "} \n";

                CODE_EDITOR.SelectedText = "" +
                    "function " + addNewObjectFieldName.Text + "OnLoadObj(meshes) {\n" +
                       "for(let key in meshes) { matrixEngine.objLoader.initMeshBuffers(world.GL.gl, meshes[key])}\n" +
                    "\n" +
                    "world.Add('obj', " + initialScale.Text + ", '" + addNewObjectFieldName.Text + "', " +
                    "tex" + addNewObjectFieldName.Text + " , meshes." + addNewObjectFieldName.Text + ");";

                // position etc...
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".position.setPosition(" + POSITION.GetX() + ", " + POSITION.GetY() + ", " + POSITION.GetZ() + ");\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotx = " + initialRotation.GetX() + ";\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.roty = " + initialRotation.GetY() + ";\n";
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotz = " + initialRotation.GetZ() + ";\n";
                if (activeRotation.isAllZero() == false) {
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.x = " + activeRotation.GetX() + ";\n";
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.y = " + activeRotation.GetY() + ";\n";
                    CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".rotation.rotationSpeed.z = " + activeRotation.GetZ() + ";\n";
                }
                CODE_EDITOR.SelectedText = "}\n";

                CODE_EDITOR.SelectedText = "matrixEngine.objLoader.downloadMeshes({" + addNewObjectFieldName.Text + ": '" + OBJ_PATH.Text.ToString() + "'}, " +
                    addNewObjectFieldName.Text + "OnLoadObj );\n";
            }

            // common
            if (BLEND.Checked) {
                Clipboard.Clear();
                CODE_EDITOR.SelectedText = "  App.scene." + addNewObjectFieldName.Text + ".glBlend.blendEnabled = true;\n" +
                                           "  App.scene." + addNewObjectFieldName.Text + ".glBlend.blendParamSrc = '" + blendSrc.SelectedItem.ToString() + "';\n" +
                                           "  App.scene." + addNewObjectFieldName.Text + ".glBlend.blendParamDest = '" + blendDest.SelectedItem.ToString() + "';\n";
                CODE_EDITOR.Paste();
            }

            helpPanelAddNewObject.Visible = false;

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
            //    
            if (typeList.SelectedItem.ToString() == "obj") {
                OBJ_PATH.Enabled = true;
            } else {
                OBJ_PATH.Enabled = false;
            }
            if (typeList.SelectedItem.ToString() == "cube" || typeList.SelectedItem.ToString() == "triangle" ||
                 typeList.SelectedItem.ToString() == "square" || typeList.SelectedItem.ToString() == "pyramid") {
                solidColor.Enabled = true;
                ambientColor.Enabled = false;
                // hide tex control
                RES_IMGS.Visible = false;
                STREAM_TEXTURES_CHECK_VIDEO.Visible = false;
                STREAM_TEXTURES_CHECK_CAMERA.Visible = false;
                STREAM_TEXTURES_CHECK_CANVAS.Visible = false;
                CANVAS_TEXTURE_URL.Visible = false;
            } else {
                solidColor.Enabled = false;
                ambientColor.Enabled = true;
                // show tex control
                RES_IMGS.Visible = true;
                STREAM_TEXTURES_CHECK_VIDEO.Visible = true;
                STREAM_TEXTURES_CHECK_CAMERA.Visible = true;
                STREAM_TEXTURES_CHECK_CANVAS.Visible = true;
                CANVAS_TEXTURE_URL.Visible = true;
                //...
            }
        }

        private void CODE_EDITOR_TextChanged(object sender, EventArgs e) {

        }

        private void aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.Clear();
            CODE_EDITOR.SelectedText = "  App.camera.FirstPersonController = true;\n";
            CODE_EDITOR.Paste();
        }

        private void addSceneCameraToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.Clear();
            CODE_EDITOR.SelectedText = "  App.camera.SceneController = true;\n";
            CODE_EDITOR.Paste();
        }

        private void rayhiteventToolStripMenuItem_Click(object sender, EventArgs e) {
            Clipboard.Clear();
            CODE_EDITOR.SelectedText = " window.addEventListener('ray.hit.event', (ev) => {\n" +
                "   console.log('You shoot the object. Nice!', ev)\n" +
            " });\n" +
            " \n " +
            " canvas.addEventListener('mousedown', (ev) => { \n" +
            "   matrixEngine.raycaster.checkingProcedure(ev); \n " +
            "  });     \n";
            CODE_EDITOR.Paste();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            CheckBox T = (CheckBox)sender;
            if (T.Checked == true) {
                blendDest.Enabled = true;
                blendSrc.Enabled = true;
            } else {
                blendDest.Enabled = false;
                blendSrc.Enabled = false;
            }
        }

        private void STREAM_TEXTURES_CHECK_CheckedChanged(object sender, EventArgs e) {
            // VIDEOS 
            CheckBox T = (CheckBox)sender;
            if (T.Checked == true) {
                RES_IMGS.loadFolder(RES3DFOLDER_VIDEOS);
                STREAM_TEXTURES_CHECK_CAMERA.Checked = false;
                STREAM_TEXTURES_CHECK_CANVAS.Checked = false;

                BROWSER_VIDEOS.Navigate(RES3DFOLDER_VIDEOS);
            } else {
                RES_IMGS.loadFolder(RES3DFOLDER_IMGS);
                STREAM_TEXTURES_CHECK_CAMERA.Checked = false;
                STREAM_TEXTURES_CHECK_CANVAS.Checked = false;
                STREAM_TEXTURES_CHECK_VIDEO.Checked = false;
            }
        }

        private void STREAM_TEXTURES_CHECK_CANVAS_CheckedChanged(object sender, EventArgs e) {
            CheckBox T = (CheckBox)sender;
            if (T.Checked == true) {
                RES_IMGS.loadFolder(RES3DFOLDER_VIDEOS);
                STREAM_TEXTURES_CHECK_CAMERA.Checked = false;
                STREAM_TEXTURES_CHECK_VIDEO.Checked = false;
            } else {
                RES_IMGS.loadFolder(RES3DFOLDER_IMGS);
                STREAM_TEXTURES_CHECK_CAMERA.Checked = false;
                STREAM_TEXTURES_CHECK_CANVAS.Checked = false;
                STREAM_TEXTURES_CHECK_VIDEO.Checked = false;
            }
        }

        private void STREAM_TEXTURES_CHECK_CAMERA_CheckedChanged(object sender, EventArgs e) {
            CheckBox T = (CheckBox)sender;
            if (T.Checked == true) {
                RES_IMGS.loadFolder(RES3DFOLDER_VIDEOS);
                STREAM_TEXTURES_CHECK_CANVAS.Checked = false;
                STREAM_TEXTURES_CHECK_VIDEO.Checked = false;
            } else {
                RES_IMGS.loadFolder(RES3DFOLDER_IMGS);
                STREAM_TEXTURES_CHECK_CAMERA.Checked = false;
                STREAM_TEXTURES_CHECK_CANVAS.Checked = false;
                STREAM_TEXTURES_CHECK_VIDEO.Checked = false;
            }
        }

        private void BROWSER_VIDEOS_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
            // NOT WORKING FOR NO 
            // VISUAL PORESENTATION OF VIDEOS AND SELETIONS

            // Clipboard.Clear();
            // SendKeys.Send("^C");
            StringCollection sc = Clipboard.GetFileDropList();
            foreach (string name in sc) {
                MessageBox.Show(name, "WHAT IS SC ");
            }
        }

        private void BROWSER_VIDEOS_FileDownload(object sender, EventArgs e) {
            //MessageBox.Show("DOWNLOAD ");
        }

        private bool bCancel = false;

        private void BROWSER_VIDEOS_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

        }

        private void BROWSER_VIDEOS_Navigating(object sender, WebBrowserNavigatingEventArgs e) {

        }

        private void codeHelperToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) {

        }

        private void CANVAS_TEXTURE_URL_TextChanged(object sender, EventArgs e) {

        }

        private void btnGIT_Click(object sender, EventArgs e) {
            var exampleForm = new Examples();
            exampleForm.Show();
        }
    }
}