
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.blendSrc = new System.Windows.Forms.ComboBox();
            this.blendDest = new System.Windows.Forms.ComboBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BLEND = new System.Windows.Forms.CheckBox();
            this.resetToDefault = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpAddNewGameObjectBTN = new System.Windows.Forms.Button();
            this.addNewObjectFieldName = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.RES_IMGS = new matrix_engine.RESOURCE_EXPLORER_CODE_HELPER();
            this.ambientColor = new matrix_engine.MeColor();
            this.solidColor = new matrix_engine.MeColor();
            this.activeRotation = new matrix_engine.MatrixValuesControl();
            this.initialRotation = new matrix_engine.MatrixValuesControl();
            this.POSITION = new matrix_engine.MatrixValuesControl();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.helpPanelAddNewObject.SuspendLayout();
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
            this.SCRIPT_SRC.Location = new System.Drawing.Point(296, 0);
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
            this.typeList.Size = new System.Drawing.Size(218, 21);
            this.typeList.TabIndex = 89;
            this.toolTip1.SetToolTip(this.typeList, "Choose your matrix-engine game object type.");
            this.typeList.SelectedIndexChanged += new System.EventHandler(this.typeList_SelectedIndexChanged);
            // 
            // initialScale
            // 
            this.initialScale.BackColor = System.Drawing.Color.Black;
            this.initialScale.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialScale.ForeColor = System.Drawing.Color.DarkOrange;
            this.initialScale.Location = new System.Drawing.Point(119, 213);
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.blendSrc.Location = new System.Drawing.Point(84, 425);
            this.blendSrc.Name = "blendSrc";
            this.blendSrc.Size = new System.Drawing.Size(171, 21);
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
            this.blendDest.Location = new System.Drawing.Point(84, 452);
            this.blendDest.Name = "blendDest";
            this.blendDest.Size = new System.Drawing.Size(171, 21);
            this.blendDest.TabIndex = 114;
            this.toolTip1.SetToolTip(this.blendDest, "Choose your matrix-engine game object type.");
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
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Stormfaze", 8.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeHelperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(443, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(99, 24);
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
            this.codeHelperToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.codeHelperToolStripMenuItem.Text = "Code helper";
            // 
            // addNewCubeToolStripMenuItem
            // 
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
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(916, 30);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.helpPanelAddNewObject);
            this.panel1.Controls.Add(this.CODE_EDITOR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 635);
            this.panel1.TabIndex = 18;
            // 
            // helpPanelAddNewObject
            // 
            this.helpPanelAddNewObject.BackColor = System.Drawing.Color.Black;
            this.helpPanelAddNewObject.BackgroundImage = global::matrix_engine.Properties.Resources.midbg;
            this.helpPanelAddNewObject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.helpPanelAddNewObject.Location = new System.Drawing.Point(12, 18);
            this.helpPanelAddNewObject.Name = "helpPanelAddNewObject";
            this.helpPanelAddNewObject.Size = new System.Drawing.Size(798, 581);
            this.helpPanelAddNewObject.TabIndex = 1;
            this.helpPanelAddNewObject.Visible = false;
            this.helpPanelAddNewObject.Paint += new System.Windows.Forms.PaintEventHandler(this.helpPanelAddNewObject_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(44, 454);
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
            this.label4.Location = new System.Drawing.Point(45, 431);
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
            this.BLEND.Location = new System.Drawing.Point(33, 400);
            this.BLEND.Name = "BLEND";
            this.BLEND.Size = new System.Drawing.Size(64, 19);
            this.BLEND.TabIndex = 112;
            this.BLEND.Text = "Blend";
            this.BLEND.UseVisualStyleBackColor = false;
            this.BLEND.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // resetToDefault
            // 
            this.resetToDefault.BackColor = System.Drawing.Color.OrangeRed;
            this.resetToDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetToDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetToDefault.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetToDefault.ForeColor = System.Drawing.Color.Black;
            this.resetToDefault.Location = new System.Drawing.Point(443, 523);
            this.resetToDefault.Name = "resetToDefault";
            this.resetToDefault.Size = new System.Drawing.Size(62, 37);
            this.resetToDefault.TabIndex = 104;
            this.resetToDefault.Text = "Reset";
            this.resetToDefault.UseVisualStyleBackColor = false;
            this.resetToDefault.Click += new System.EventHandler(this.resetToDefault_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(511, 523);
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
            this.label10.Location = new System.Drawing.Point(33, 215);
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
            this.helpAddNewGameObjectBTN.Location = new System.Drawing.Point(256, 523);
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
            // RES_IMGS
            // 
            this.RES_IMGS.BackColor = System.Drawing.Color.Transparent;
            this.RES_IMGS.Location = new System.Drawing.Point(465, 91);
            this.RES_IMGS.Name = "RES_IMGS";
            this.RES_IMGS.Size = new System.Drawing.Size(309, 234);
            this.RES_IMGS.TabIndex = 117;
            // 
            // ambientColor
            // 
            this.ambientColor.BackColor = System.Drawing.Color.Transparent;
            this.ambientColor.ForeColor = System.Drawing.Color.OrangeRed;
            this.ambientColor.Location = new System.Drawing.Point(21, 365);
            this.ambientColor.Name = "ambientColor";
            this.ambientColor.Size = new System.Drawing.Size(383, 30);
            this.ambientColor.TabIndex = 108;
            // 
            // solidColor
            // 
            this.solidColor.BackColor = System.Drawing.Color.Transparent;
            this.solidColor.ForeColor = System.Drawing.Color.OrangeRed;
            this.solidColor.Location = new System.Drawing.Point(21, 327);
            this.solidColor.Name = "solidColor";
            this.solidColor.Size = new System.Drawing.Size(383, 34);
            this.solidColor.TabIndex = 107;
            // 
            // activeRotation
            // 
            this.activeRotation.BackColor = System.Drawing.Color.Transparent;
            this.activeRotation.ForeColor = System.Drawing.Color.DarkOrange;
            this.activeRotation.Location = new System.Drawing.Point(21, 285);
            this.activeRotation.Name = "activeRotation";
            this.activeRotation.Size = new System.Drawing.Size(302, 38);
            this.activeRotation.TabIndex = 106;
            // 
            // initialRotation
            // 
            this.initialRotation.BackColor = System.Drawing.Color.Transparent;
            this.initialRotation.ForeColor = System.Drawing.Color.DarkOrange;
            this.initialRotation.Location = new System.Drawing.Point(21, 241);
            this.initialRotation.Name = "initialRotation";
            this.initialRotation.Size = new System.Drawing.Size(302, 38);
            this.initialRotation.TabIndex = 105;
            // 
            // POSITION
            // 
            this.POSITION.BackColor = System.Drawing.Color.Transparent;
            this.POSITION.ForeColor = System.Drawing.Color.DarkOrange;
            this.POSITION.Location = new System.Drawing.Point(21, 168);
            this.POSITION.Name = "POSITION";
            this.POSITION.Size = new System.Drawing.Size(302, 38);
            this.POSITION.TabIndex = 103;
            // 
            // ScritpEditor3d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(916, 701);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
    }
}