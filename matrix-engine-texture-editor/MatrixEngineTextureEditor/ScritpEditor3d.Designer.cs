
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.codeHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpPanelAddNewObject = new System.Windows.Forms.Panel();
            this.resetToDefault = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpAddNewGameObjectBTN = new System.Windows.Forms.Button();
            this.addNewObjectFieldName = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.justFolders = new System.Windows.Forms.ListView();
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
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(517, 266);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 129);
            this.listView1.TabIndex = 109;
            this.toolTip1.SetToolTip(this.listView1, "Select textures");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeHelperToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(445, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(97, 31);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // codeHelperToolStripMenuItem
            // 
            this.codeHelperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCubeToolStripMenuItem});
            this.codeHelperToolStripMenuItem.Name = "codeHelperToolStripMenuItem";
            this.codeHelperToolStripMenuItem.Size = new System.Drawing.Size(84, 17);
            this.codeHelperToolStripMenuItem.Text = "Code helper";
            // 
            // addNewCubeToolStripMenuItem
            // 
            this.addNewCubeToolStripMenuItem.Name = "addNewCubeToolStripMenuItem";
            this.addNewCubeToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addNewCubeToolStripMenuItem.Text = "Add new game object";
            this.addNewCubeToolStripMenuItem.Click += new System.EventHandler(this.addNewCubeToolStripMenuItem_Click);
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
            this.helpPanelAddNewObject.Controls.Add(this.justFolders);
            this.helpPanelAddNewObject.Controls.Add(this.listView1);
            this.helpPanelAddNewObject.Controls.Add(this.ambientColor);
            this.helpPanelAddNewObject.Controls.Add(this.solidColor);
            this.helpPanelAddNewObject.Controls.Add(this.activeRotation);
            this.helpPanelAddNewObject.Controls.Add(this.initialRotation);
            this.helpPanelAddNewObject.Controls.Add(this.resetToDefault);
            this.helpPanelAddNewObject.Controls.Add(this.POSITION);
            this.helpPanelAddNewObject.Controls.Add(this.back);
            this.helpPanelAddNewObject.Controls.Add(this.button2);
            this.helpPanelAddNewObject.Controls.Add(this.initialScale);
            this.helpPanelAddNewObject.Controls.Add(this.label10);
            this.helpPanelAddNewObject.Controls.Add(this.label3);
            this.helpPanelAddNewObject.Controls.Add(this.typeList);
            this.helpPanelAddNewObject.Controls.Add(this.label5);
            this.helpPanelAddNewObject.Controls.Add(this.label2);
            this.helpPanelAddNewObject.Controls.Add(this.helpAddNewGameObjectBTN);
            this.helpPanelAddNewObject.Controls.Add(this.addNewObjectFieldName);
            this.helpPanelAddNewObject.Location = new System.Drawing.Point(59, 32);
            this.helpPanelAddNewObject.Name = "helpPanelAddNewObject";
            this.helpPanelAddNewObject.Size = new System.Drawing.Size(834, 558);
            this.helpPanelAddNewObject.TabIndex = 1;
            this.helpPanelAddNewObject.Visible = false;
            this.helpPanelAddNewObject.Paint += new System.Windows.Forms.PaintEventHandler(this.helpPanelAddNewObject_Paint);
            // 
            // resetToDefault
            // 
            this.resetToDefault.BackColor = System.Drawing.Color.OrangeRed;
            this.resetToDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetToDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetToDefault.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetToDefault.ForeColor = System.Drawing.Color.Black;
            this.resetToDefault.Location = new System.Drawing.Point(461, 514);
            this.resetToDefault.Name = "resetToDefault";
            this.resetToDefault.Size = new System.Drawing.Size(62, 25);
            this.resetToDefault.TabIndex = 104;
            this.resetToDefault.Text = "Reset";
            this.resetToDefault.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetToDefault.UseVisualStyleBackColor = false;
            this.resetToDefault.Click += new System.EventHandler(this.resetToDefault_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.OrangeRed;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(517, 119);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(62, 25);
            this.back.TabIndex = 102;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(529, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 25);
            this.button2.TabIndex = 100;
            this.button2.Text = "Hide";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.label5.Location = new System.Drawing.Point(314, 13);
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
            this.helpAddNewGameObjectBTN.Location = new System.Drawing.Point(274, 514);
            this.helpAddNewGameObjectBTN.Name = "helpAddNewGameObjectBTN";
            this.helpAddNewGameObjectBTN.Size = new System.Drawing.Size(181, 25);
            this.helpAddNewGameObjectBTN.TabIndex = 46;
            this.helpAddNewGameObjectBTN.Text = "Add new game object";
            this.helpAddNewGameObjectBTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // justFolders
            // 
            this.justFolders.BackColor = System.Drawing.Color.DimGray;
            this.justFolders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.justFolders.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justFolders.ForeColor = System.Drawing.Color.Gainsboro;
            this.justFolders.HideSelection = false;
            this.justFolders.LargeImageList = this.imageList1;
            this.justFolders.Location = new System.Drawing.Point(517, 150);
            this.justFolders.Name = "justFolders";
            this.justFolders.Size = new System.Drawing.Size(293, 110);
            this.justFolders.TabIndex = 110;
            this.toolTip1.SetToolTip(this.justFolders, "Select sub folders for textures");
            this.justFolders.UseCompatibleStateImageBehavior = false;
            this.justFolders.View = System.Windows.Forms.View.List;
            this.justFolders.SelectedIndexChanged += new System.EventHandler(this.justFolders_SelectedIndexChanged);
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
        public System.Windows.Forms.Button back;
        private MatrixValuesControl POSITION;
        public System.Windows.Forms.Button resetToDefault;
        private MatrixValuesControl initialRotation;
        private MatrixValuesControl activeRotation;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private MeColor solidColor;
        private MeColor ambientColor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView justFolders;
    }
}