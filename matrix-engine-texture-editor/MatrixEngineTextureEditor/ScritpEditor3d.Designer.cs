
namespace matrix_engine {
    partial class ScritpEditor3d {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.CODE_EDITOR = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SCRIPT_SRC = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.typeList = new System.Windows.Forms.ComboBox();
            this.initialScale = new System.Windows.Forms.TextBox();
            this.blendSrc = new System.Windows.Forms.ComboBox();
            this.blendDest = new System.Windows.Forms.ComboBox();
            this.STREAM_TEXTURES_CHECK_VIDEO = new System.Windows.Forms.CheckBox();
            this.STREAM_TEXTURES_CHECK_CANVAS = new System.Windows.Forms.CheckBox();
            this.STREAM_TEXTURES_CHECK_CAMERA = new System.Windows.Forms.CheckBox();
            this.CANVAS_TEXTURE_URL = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.codeHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSceneCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayhiteventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpPanelAddNewObject = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.OBJ_PATH = new System.Windows.Forms.TextBox();
            this.BROWSER_VIDEOS = new System.Windows.Forms.WebBrowser();
            this.RES_IMGS = new matrix_engine.RESOURCE_EXPLORER_CODE_HELPER();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BLEND = new System.Windows.Forms.CheckBox();
            this.ambientColor = new matrix_engine.MeColor();
            this.solidColor = new matrix_engine.MeColor();
            this.activeRotation = new matrix_engine.MatrixValuesControl();
            this.initialRotation = new matrix_engine.MatrixValuesControl();
            this.resetToDefault = new System.Windows.Forms.Button();
            this.POSITION = new matrix_engine.MatrixValuesControl();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpAddNewGameObjectBTN = new System.Windows.Forms.Button();
            this.addNewObjectFieldName = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGIT = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.helpPanelAddNewObject.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CODE_EDITOR
            // 
            this.CODE_EDITOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CODE_EDITOR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CODE_EDITOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CODE_EDITOR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CODE_EDITOR.ForeColor = System.Drawing.Color.Black;
            this.CODE_EDITOR.Location = new System.Drawing.Point(0, 0);
            this.CODE_EDITOR.Margin = new System.Windows.Forms.Padding(0);
            this.CODE_EDITOR.Name = "CODE_EDITOR";
            this.CODE_EDITOR.Size = new System.Drawing.Size(916, 635);
            this.CODE_EDITOR.TabIndex = 0;
            this.CODE_EDITOR.Text = "";
            this.CODE_EDITOR.TextChanged += new System.EventHandler(this.CODE_EDITOR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Matrix-Engine Code Editor";
            // 
            // SCRIPT_SRC
            // 
            this.SCRIPT_SRC.AutoSize = true;
            this.SCRIPT_SRC.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCRIPT_SRC.ForeColor = System.Drawing.Color.SeaShell;
            this.SCRIPT_SRC.Location = new System.Drawing.Point(3, 22);
            this.SCRIPT_SRC.Name = "SCRIPT_SRC";
            this.SCRIPT_SRC.Size = new System.Drawing.Size(72, 14);
            this.SCRIPT_SRC.TabIndex = 10;
            this.SCRIPT_SRC.Text = "FILE PATH";
            this.SCRIPT_SRC.Click += new System.EventHandler(this.SCRIPT_SRC_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Stormfaze", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.Location = new System.Drawing.Point(545, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(181, 25);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Stormfaze", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(732, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "HIDE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeList
            // 
            this.typeList.BackColor = System.Drawing.Color.Black;
            this.typeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeList.ForeColor = System.Drawing.Color.OrangeRed;
            this.typeList.FormattingEnabled = true;
            this.typeList.Items.AddRange(new object[] {
            "triangle",
            "square",
            "squareTex",
            "cube",
            "sphereLightTex",
            "pyramid",
            "obj",
            "cubeLightTex",
            "cubeMapTex",
            "generatorLightTex"});
            this.typeList.Location = new System.Drawing.Point(37, 141);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(218, 26);
            this.typeList.TabIndex = 89;
            this.toolTip1.SetToolTip(this.typeList, "Choose your matrix-engine game object type.");
            this.typeList.SelectedIndexChanged += new System.EventHandler(this.typeList_SelectedIndexChanged);
            // 
            // initialScale
            // 
            this.initialScale.BackColor = System.Drawing.Color.Black;
            this.initialScale.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialScale.ForeColor = System.Drawing.Color.DarkOrange;
            this.initialScale.Location = new System.Drawing.Point(119, 254);
            this.initialScale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.initialScale.Multiline = true;
            this.initialScale.Name = "initialScale";
            this.initialScale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.initialScale.Size = new System.Drawing.Size(44, 21);
            this.initialScale.TabIndex = 99;
            this.initialScale.Text = "1";
            this.initialScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.initialScale, "Set GL world position for new object.");
            this.initialScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.initialScale_KeyPress);
            // 
            // blendSrc
            // 
            this.blendSrc.BackColor = System.Drawing.Color.Black;
            this.blendSrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blendSrc.Enabled = false;
            this.blendSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blendSrc.ForeColor = System.Drawing.Color.OrangeRed;
            this.blendSrc.FormattingEnabled = true;
            this.blendSrc.Items.AddRange(new object[] {
            "ZERO",
            "ONE",
            "SRC_COLOR",
            "DST_COLOR",
            "ONE_MINUS_SRC_COLOR",
            "ONE_MINUS_DST_COLOR",
            "SRC_ALPHA",
            "DST_ALPHA",
            "ONE_MINUS_SRC_ALPHA",
            "ONE_MINUS_DST_ALPHA",
            "SRC_ALPHA_SATURATE"});
            this.blendSrc.Location = new System.Drawing.Point(84, 466);
            this.blendSrc.Name = "blendSrc";
            this.blendSrc.Size = new System.Drawing.Size(171, 26);
            this.blendSrc.TabIndex = 113;
            this.toolTip1.SetToolTip(this.blendSrc, "Choose your matrix-engine game object type.");
            // 
            // blendDest
            // 
            this.blendDest.BackColor = System.Drawing.Color.Black;
            this.blendDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blendDest.Enabled = false;
            this.blendDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blendDest.ForeColor = System.Drawing.Color.OrangeRed;
            this.blendDest.FormattingEnabled = true;
            this.blendDest.Items.AddRange(new object[] {
            "ZERO",
            "ONE",
            "SRC_COLOR",
            "DST_COLOR",
            "ONE_MINUS_SRC_COLOR",
            "ONE_MINUS_DST_COLOR",
            "SRC_ALPHA",
            "DST_ALPHA",
            "ONE_MINUS_SRC_ALPHA",
            "ONE_MINUS_DST_ALPHA",
            "SRC_ALPHA_SATURATE"});
            this.blendDest.Location = new System.Drawing.Point(84, 493);
            this.blendDest.Name = "blendDest";
            this.blendDest.Size = new System.Drawing.Size(171, 26);
            this.blendDest.TabIndex = 114;
            this.toolTip1.SetToolTip(this.blendDest, "Choose your matrix-engine game object type.");
            // 
            // STREAM_TEXTURES_CHECK_VIDEO
            // 
            this.STREAM_TEXTURES_CHECK_VIDEO.AutoSize = true;
            this.STREAM_TEXTURES_CHECK_VIDEO.BackColor = System.Drawing.Color.Transparent;
            this.STREAM_TEXTURES_CHECK_VIDEO.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STREAM_TEXTURES_CHECK_VIDEO.ForeColor = System.Drawing.Color.OrangeRed;
            this.STREAM_TEXTURES_CHECK_VIDEO.Location = new System.Drawing.Point(478, 319);
            this.STREAM_TEXTURES_CHECK_VIDEO.Name = "STREAM_TEXTURES_CHECK_VIDEO";
            this.STREAM_TEXTURES_CHECK_VIDEO.Size = new System.Drawing.Size(272, 19);
            this.STREAM_TEXTURES_CHECK_VIDEO.TabIndex = 118;
            this.STREAM_TEXTURES_CHECK_VIDEO.Text = "Video textures [recommended webm]";
            this.toolTip1.SetToolTip(this.STREAM_TEXTURES_CHECK_VIDEO, "If you wanna video textures.");
            this.STREAM_TEXTURES_CHECK_VIDEO.UseVisualStyleBackColor = false;
            this.STREAM_TEXTURES_CHECK_VIDEO.Visible = false;
            this.STREAM_TEXTURES_CHECK_VIDEO.CheckedChanged += new System.EventHandler(this.STREAM_TEXTURES_CHECK_CheckedChanged);
            // 
            // STREAM_TEXTURES_CHECK_CANVAS
            // 
            this.STREAM_TEXTURES_CHECK_CANVAS.AutoSize = true;
            this.STREAM_TEXTURES_CHECK_CANVAS.BackColor = System.Drawing.Color.Transparent;
            this.STREAM_TEXTURES_CHECK_CANVAS.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STREAM_TEXTURES_CHECK_CANVAS.ForeColor = System.Drawing.Color.OrangeRed;
            this.STREAM_TEXTURES_CHECK_CANVAS.Location = new System.Drawing.Point(478, 344);
            this.STREAM_TEXTURES_CHECK_CANVAS.Name = "STREAM_TEXTURES_CHECK_CANVAS";
            this.STREAM_TEXTURES_CHECK_CANVAS.Size = new System.Drawing.Size(137, 19);
            this.STREAM_TEXTURES_CHECK_CANVAS.TabIndex = 119;
            this.STREAM_TEXTURES_CHECK_CANVAS.Text = "Canvas textures";
            this.toolTip1.SetToolTip(this.STREAM_TEXTURES_CHECK_CANVAS, "If you wanna canvas textures.");
            this.STREAM_TEXTURES_CHECK_CANVAS.UseVisualStyleBackColor = false;
            this.STREAM_TEXTURES_CHECK_CANVAS.Visible = false;
            this.STREAM_TEXTURES_CHECK_CANVAS.CheckedChanged += new System.EventHandler(this.STREAM_TEXTURES_CHECK_CANVAS_CheckedChanged);
            // 
            // STREAM_TEXTURES_CHECK_CAMERA
            // 
            this.STREAM_TEXTURES_CHECK_CAMERA.AutoSize = true;
            this.STREAM_TEXTURES_CHECK_CAMERA.BackColor = System.Drawing.Color.Transparent;
            this.STREAM_TEXTURES_CHECK_CAMERA.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STREAM_TEXTURES_CHECK_CAMERA.ForeColor = System.Drawing.Color.OrangeRed;
            this.STREAM_TEXTURES_CHECK_CAMERA.Location = new System.Drawing.Point(478, 369);
            this.STREAM_TEXTURES_CHECK_CAMERA.Name = "STREAM_TEXTURES_CHECK_CAMERA";
            this.STREAM_TEXTURES_CHECK_CAMERA.Size = new System.Drawing.Size(138, 19);
            this.STREAM_TEXTURES_CHECK_CAMERA.TabIndex = 120;
            this.STREAM_TEXTURES_CHECK_CAMERA.Text = "Camera textures";
            this.toolTip1.SetToolTip(this.STREAM_TEXTURES_CHECK_CAMERA, "If you wanna webcam surface textures.");
            this.STREAM_TEXTURES_CHECK_CAMERA.UseVisualStyleBackColor = false;
            this.STREAM_TEXTURES_CHECK_CAMERA.Visible = false;
            this.STREAM_TEXTURES_CHECK_CAMERA.CheckedChanged += new System.EventHandler(this.STREAM_TEXTURES_CHECK_CAMERA_CheckedChanged);
            // 
            // CANVAS_TEXTURE_URL
            // 
            this.CANVAS_TEXTURE_URL.BackColor = System.Drawing.Color.Black;
            this.CANVAS_TEXTURE_URL.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANVAS_TEXTURE_URL.ForeColor = System.Drawing.Color.DarkOrange;
            this.CANVAS_TEXTURE_URL.Location = new System.Drawing.Point(623, 343);
            this.CANVAS_TEXTURE_URL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CANVAS_TEXTURE_URL.Name = "CANVAS_TEXTURE_URL";
            this.CANVAS_TEXTURE_URL.Size = new System.Drawing.Size(160, 21);
            this.CANVAS_TEXTURE_URL.TabIndex = 122;
            this.CANVAS_TEXTURE_URL.Text = "https://localhost/2DTextureEditor/templates/slot/";
            this.toolTip1.SetToolTip(this.CANVAS_TEXTURE_URL, "${this.Text}");
            this.CANVAS_TEXTURE_URL.Visible = false;
            this.CANVAS_TEXTURE_URL.TextChanged += new System.EventHandler(this.CANVAS_TEXTURE_URL_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.saveBtn);
            this.flowLayoutPanel1.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 665);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(916, 36);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Font = new System.Drawing.Font("Stormfaze", 8.25F);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeHelperToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(448, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(94, 31);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // codeHelperToolStripMenuItem
            // 
            this.codeHelperToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.codeHelperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCubeToolStripMenuItem,
            this.aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem,
            this.addSceneCameraToolStripMenuItem,
            this.addEventToolStripMenuItem});
            this.codeHelperToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.codeHelperToolStripMenuItem.Name = "codeHelperToolStripMenuItem";
            this.codeHelperToolStripMenuItem.Size = new System.Drawing.Size(91, 17);
            this.codeHelperToolStripMenuItem.Text = "Code helper";
            this.codeHelperToolStripMenuItem.Click += new System.EventHandler(this.codeHelperToolStripMenuItem_Click);
            // 
            // addNewCubeToolStripMenuItem
            // 
            this.addNewCubeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.addNewCubeToolStripMenuItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.addNewCubeToolStripMenuItem.Name = "addNewCubeToolStripMenuItem";
            this.addNewCubeToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.addNewCubeToolStripMenuItem.Text = "Add new game object";
            this.addNewCubeToolStripMenuItem.Click += new System.EventHandler(this.addNewCubeToolStripMenuItem_Click);
            // 
            // aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem
            // 
            this.aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem.Name = "aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem";
            this.aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem.Text = "Add first person camera";
            this.aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem.Click += new System.EventHandler(this.aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem_Click);
            // 
            // addSceneCameraToolStripMenuItem
            // 
            this.addSceneCameraToolStripMenuItem.Name = "addSceneCameraToolStripMenuItem";
            this.addSceneCameraToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.addSceneCameraToolStripMenuItem.Text = "Add Scene camera";
            this.addSceneCameraToolStripMenuItem.Click += new System.EventHandler(this.addSceneCameraToolStripMenuItem_Click);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rayhiteventToolStripMenuItem});
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.addEventToolStripMenuItem.Text = "Add event";
            // 
            // rayhiteventToolStripMenuItem
            // 
            this.rayhiteventToolStripMenuItem.Name = "rayhiteventToolStripMenuItem";
            this.rayhiteventToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rayhiteventToolStripMenuItem.Text = "ray.hit.event";
            this.rayhiteventToolStripMenuItem.Click += new System.EventHandler(this.rayhiteventToolStripMenuItem_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.SCRIPT_SRC);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(916, 40);
            this.flowLayoutPanel2.TabIndex = 17;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helpPanelAddNewObject);
            this.panel1.Controls.Add(this.CODE_EDITOR);
            this.panel1.Location = new System.Drawing.Point(18, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 635);
            this.panel1.TabIndex = 18;
            // 
            // helpPanelAddNewObject
            // 
            this.helpPanelAddNewObject.BackColor = System.Drawing.Color.Black;
            this.helpPanelAddNewObject.BackgroundImage = global::matrix_engine.Properties.Resources.midbg;
            this.helpPanelAddNewObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpPanelAddNewObject.Controls.Add(this.label7);
            this.helpPanelAddNewObject.Controls.Add(this.OBJ_PATH);
            this.helpPanelAddNewObject.Controls.Add(this.CANVAS_TEXTURE_URL);
            this.helpPanelAddNewObject.Controls.Add(this.BROWSER_VIDEOS);
            this.helpPanelAddNewObject.Controls.Add(this.STREAM_TEXTURES_CHECK_CAMERA);
            this.helpPanelAddNewObject.Controls.Add(this.STREAM_TEXTURES_CHECK_CANVAS);
            this.helpPanelAddNewObject.Controls.Add(this.STREAM_TEXTURES_CHECK_VIDEO);
            this.helpPanelAddNewObject.Controls.Add(this.RES_IMGS);
            this.helpPanelAddNewObject.Controls.Add(this.label6);
            this.helpPanelAddNewObject.Controls.Add(this.label4);
            this.helpPanelAddNewObject.Controls.Add(this.blendDest);
            this.helpPanelAddNewObject.Controls.Add(this.blendSrc);
            this.helpPanelAddNewObject.Controls.Add(this.BLEND);
            this.helpPanelAddNewObject.Controls.Add(this.ambientColor);
            this.helpPanelAddNewObject.Controls.Add(this.solidColor);
            this.helpPanelAddNewObject.Controls.Add(this.activeRotation);
            this.helpPanelAddNewObject.Controls.Add(this.initialRotation);
            this.helpPanelAddNewObject.Controls.Add(this.resetToDefault);
            this.helpPanelAddNewObject.Controls.Add(this.POSITION);
            this.helpPanelAddNewObject.Controls.Add(this.button2);
            this.helpPanelAddNewObject.Controls.Add(this.initialScale);
            this.helpPanelAddNewObject.Controls.Add(this.label10);
            this.helpPanelAddNewObject.Controls.Add(this.label3);
            this.helpPanelAddNewObject.Controls.Add(this.typeList);
            this.helpPanelAddNewObject.Controls.Add(this.label5);
            this.helpPanelAddNewObject.Controls.Add(this.label2);
            this.helpPanelAddNewObject.Controls.Add(this.helpAddNewGameObjectBTN);
            this.helpPanelAddNewObject.Controls.Add(this.addNewObjectFieldName);
            this.helpPanelAddNewObject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpPanelAddNewObject.Location = new System.Drawing.Point(0, 0);
            this.helpPanelAddNewObject.Name = "helpPanelAddNewObject";
            this.helpPanelAddNewObject.Size = new System.Drawing.Size(916, 635);
            this.helpPanelAddNewObject.TabIndex = 1;
            this.helpPanelAddNewObject.Visible = false;
            this.helpPanelAddNewObject.Paint += new System.Windows.Forms.PaintEventHandler(this.helpPanelAddNewObject_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(34, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 124;
            this.label7.Text = "Obj path:";
            // 
            // OBJ_PATH
            // 
            this.OBJ_PATH.BackColor = System.Drawing.Color.Black;
            this.OBJ_PATH.Enabled = false;
            this.OBJ_PATH.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OBJ_PATH.ForeColor = System.Drawing.Color.DarkOrange;
            this.OBJ_PATH.Location = new System.Drawing.Point(37, 181);
            this.OBJ_PATH.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.OBJ_PATH.Name = "OBJ_PATH";
            this.OBJ_PATH.Size = new System.Drawing.Size(367, 21);
            this.OBJ_PATH.TabIndex = 123;
            this.OBJ_PATH.Text = "res/3d-objects/";
            this.OBJ_PATH.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // BROWSER_VIDEOS
            // 
            this.BROWSER_VIDEOS.Location = new System.Drawing.Point(669, 29);
            this.BROWSER_VIDEOS.MinimumSize = new System.Drawing.Size(20, 20);
            this.BROWSER_VIDEOS.Name = "BROWSER_VIDEOS";
            this.BROWSER_VIDEOS.Size = new System.Drawing.Size(96, 20);
            this.BROWSER_VIDEOS.TabIndex = 121;
            this.BROWSER_VIDEOS.Visible = false;
            this.BROWSER_VIDEOS.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.BROWSER_VIDEOS_DocumentCompleted);
            this.BROWSER_VIDEOS.FileDownload += new System.EventHandler(this.BROWSER_VIDEOS_FileDownload);
            this.BROWSER_VIDEOS.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.BROWSER_VIDEOS_Navigating);
            this.BROWSER_VIDEOS.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.BROWSER_VIDEOS_PreviewKeyDown);
            // 
            // RES_IMGS
            // 
            this.RES_IMGS.BackColor = System.Drawing.Color.Transparent;
            this.RES_IMGS.Location = new System.Drawing.Point(478, 85);
            this.RES_IMGS.Name = "RES_IMGS";
            this.RES_IMGS.Size = new System.Drawing.Size(305, 221);
            this.RES_IMGS.TabIndex = 117;
            this.RES_IMGS.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(44, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 116;
            this.label6.Text = "Dest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(45, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 115;
            this.label4.Text = "Src";
            // 
            // BLEND
            // 
            this.BLEND.AutoSize = true;
            this.BLEND.BackColor = System.Drawing.Color.Transparent;
            this.BLEND.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLEND.ForeColor = System.Drawing.Color.OrangeRed;
            this.BLEND.Location = new System.Drawing.Point(33, 441);
            this.BLEND.Name = "BLEND";
            this.BLEND.Size = new System.Drawing.Size(64, 19);
            this.BLEND.TabIndex = 112;
            this.BLEND.Text = "Blend";
            this.BLEND.UseVisualStyleBackColor = false;
            this.BLEND.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ambientColor
            // 
            this.ambientColor.BackColor = System.Drawing.Color.Transparent;
            this.ambientColor.ForeColor = System.Drawing.Color.OrangeRed;
            this.ambientColor.Location = new System.Drawing.Point(21, 406);
            this.ambientColor.Name = "ambientColor";
            this.ambientColor.Size = new System.Drawing.Size(383, 30);
            this.ambientColor.TabIndex = 108;
            // 
            // solidColor
            // 
            this.solidColor.BackColor = System.Drawing.Color.Transparent;
            this.solidColor.ForeColor = System.Drawing.Color.OrangeRed;
            this.solidColor.Location = new System.Drawing.Point(21, 368);
            this.solidColor.Name = "solidColor";
            this.solidColor.Size = new System.Drawing.Size(383, 34);
            this.solidColor.TabIndex = 107;
            // 
            // activeRotation
            // 
            this.activeRotation.BackColor = System.Drawing.Color.Transparent;
            this.activeRotation.ForeColor = System.Drawing.Color.DarkOrange;
            this.activeRotation.Location = new System.Drawing.Point(21, 326);
            this.activeRotation.Name = "activeRotation";
            this.activeRotation.Size = new System.Drawing.Size(302, 38);
            this.activeRotation.TabIndex = 106;
            // 
            // initialRotation
            // 
            this.initialRotation.BackColor = System.Drawing.Color.Transparent;
            this.initialRotation.ForeColor = System.Drawing.Color.DarkOrange;
            this.initialRotation.Location = new System.Drawing.Point(21, 282);
            this.initialRotation.Name = "initialRotation";
            this.initialRotation.Size = new System.Drawing.Size(302, 38);
            this.initialRotation.TabIndex = 105;
            // 
            // resetToDefault
            // 
            this.resetToDefault.BackColor = System.Drawing.Color.OrangeRed;
            this.resetToDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetToDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetToDefault.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetToDefault.ForeColor = System.Drawing.Color.Black;
            this.resetToDefault.Location = new System.Drawing.Point(453, 540);
            this.resetToDefault.Name = "resetToDefault";
            this.resetToDefault.Size = new System.Drawing.Size(62, 37);
            this.resetToDefault.TabIndex = 104;
            this.resetToDefault.Text = "Reset";
            this.resetToDefault.UseVisualStyleBackColor = false;
            this.resetToDefault.Click += new System.EventHandler(this.resetToDefault_Click);
            // 
            // POSITION
            // 
            this.POSITION.BackColor = System.Drawing.Color.Transparent;
            this.POSITION.ForeColor = System.Drawing.Color.DarkOrange;
            this.POSITION.Location = new System.Drawing.Point(21, 209);
            this.POSITION.Name = "POSITION";
            this.POSITION.Size = new System.Drawing.Size(302, 38);
            this.POSITION.TabIndex = 103;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(521, 540);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 37);
            this.button2.TabIndex = 100;
            this.button2.Text = "Hide";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(33, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 98;
            this.label10.Text = "Initial scale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 90;
            this.label3.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Orbitron", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(283, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Add new game object";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name:";
            // 
            // helpAddNewGameObjectBTN
            // 
            this.helpAddNewGameObjectBTN.BackColor = System.Drawing.Color.OrangeRed;
            this.helpAddNewGameObjectBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpAddNewGameObjectBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpAddNewGameObjectBTN.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpAddNewGameObjectBTN.ForeColor = System.Drawing.Color.Black;
            this.helpAddNewGameObjectBTN.Location = new System.Drawing.Point(266, 540);
            this.helpAddNewGameObjectBTN.Name = "helpAddNewGameObjectBTN";
            this.helpAddNewGameObjectBTN.Size = new System.Drawing.Size(181, 37);
            this.helpAddNewGameObjectBTN.TabIndex = 46;
            this.helpAddNewGameObjectBTN.Text = "Add new game object";
            this.helpAddNewGameObjectBTN.UseVisualStyleBackColor = false;
            this.helpAddNewGameObjectBTN.Click += new System.EventHandler(this.helpAddNewGameObjectBTN_Click);
            // 
            // addNewObjectFieldName
            // 
            this.addNewObjectFieldName.BackColor = System.Drawing.Color.Black;
            this.addNewObjectFieldName.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewObjectFieldName.ForeColor = System.Drawing.Color.DarkOrange;
            this.addNewObjectFieldName.Location = new System.Drawing.Point(37, 91);
            this.addNewObjectFieldName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.addNewObjectFieldName.Name = "addNewObjectFieldName";
            this.addNewObjectFieldName.Size = new System.Drawing.Size(218, 21);
            this.addNewObjectFieldName.TabIndex = 45;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Orbitron", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(916, 619);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Orbitron", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.OrangeRed;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(908, 590);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "App.js";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.btnGIT);
            this.tabPage2.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(908, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Examples";
            // 
            // btnGIT
            // 
            this.btnGIT.Location = new System.Drawing.Point(146, 107);
            this.btnGIT.Name = "btnGIT";
            this.btnGIT.Size = new System.Drawing.Size(140, 52);
            this.btnGIT.TabIndex = 0;
            this.btnGIT.Text = "button3";
            this.btnGIT.UseVisualStyleBackColor = true;
            this.btnGIT.Click += new System.EventHandler(this.btnGIT_Click);
            // 
            // ScritpEditor3d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(916, 701);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ScritpEditor3d";
            this.Text = "ScritpEditor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ScritpEditor_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.helpPanelAddNewObject.ResumeLayout(false);
            this.helpPanelAddNewObject.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CODE_EDITOR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label SCRIPT_SRC;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem codeHelperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCubeToolStripMenuItem;
        private System.Windows.Forms.Panel helpPanelAddNewObject;
        public System.Windows.Forms.Button helpAddNewGameObjectBTN;
        public System.Windows.Forms.TextBox addNewObjectFieldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeList;
        public System.Windows.Forms.TextBox initialScale;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button button2;
        private MatrixValuesControl POSITION;
        public System.Windows.Forms.Button resetToDefault;
        private MatrixValuesControl initialRotation;
        private MatrixValuesControl activeRotation;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MeColor solidColor;
        private MeColor ambientColor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem aDDFIRSTPERSONLOOKCAMERAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSceneCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rayhiteventToolStripMenuItem;
        private System.Windows.Forms.CheckBox BLEND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox blendDest;
        private System.Windows.Forms.ComboBox blendSrc;
        private RESOURCE_EXPLORER_CODE_HELPER RES_IMGS;
        private System.Windows.Forms.CheckBox STREAM_TEXTURES_CHECK_VIDEO;
        private System.Windows.Forms.CheckBox STREAM_TEXTURES_CHECK_CAMERA;
        private System.Windows.Forms.CheckBox STREAM_TEXTURES_CHECK_CANVAS;
        private System.Windows.Forms.WebBrowser BROWSER_VIDEOS;
        public System.Windows.Forms.TextBox CANVAS_TEXTURE_URL;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox OBJ_PATH;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGIT;
    }
}