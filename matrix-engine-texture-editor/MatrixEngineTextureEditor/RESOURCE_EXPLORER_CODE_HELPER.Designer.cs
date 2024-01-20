
namespace matrix_engine {
    partial class RESOURCE_EXPLORER_CODE_HELPER {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ChooseTexturesLabel = new System.Windows.Forms.Label();
            this.justFolders = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // ChooseTexturesLabel
            // 
            this.ChooseTexturesLabel.AutoSize = true;
            this.ChooseTexturesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseTexturesLabel.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseTexturesLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ChooseTexturesLabel.Location = new System.Drawing.Point(2, -2);
            this.ChooseTexturesLabel.Name = "ChooseTexturesLabel";
            this.ChooseTexturesLabel.Size = new System.Drawing.Size(120, 15);
            this.ChooseTexturesLabel.TabIndex = 114;
            this.ChooseTexturesLabel.Text = "Choose textures:";
            // 
            // justFolders
            // 
            this.justFolders.BackColor = System.Drawing.Color.DimGray;
            this.justFolders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.justFolders.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justFolders.ForeColor = System.Drawing.Color.Gainsboro;
            this.justFolders.HideSelection = false;
            this.justFolders.Location = new System.Drawing.Point(5, 16);
            this.justFolders.Name = "justFolders";
            this.justFolders.Size = new System.Drawing.Size(293, 70);
            this.justFolders.TabIndex = 113;
            this.justFolders.UseCompatibleStateImageBehavior = false;
            this.justFolders.View = System.Windows.Forms.View.List;
            this.justFolders.SelectedIndexChanged += new System.EventHandler(this.justFolders_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(293, 129);
            this.listView1.TabIndex = 112;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // RESOURCE_EXPLORER_CODE_HELPER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ChooseTexturesLabel);
            this.Controls.Add(this.justFolders);
            this.Controls.Add(this.listView1);
            this.Name = "RESOURCE_EXPLORER_CODE_HELPER";
            this.Size = new System.Drawing.Size(309, 234);
            this.Load += new System.EventHandler(this.RESOURCE_EXPLORER_CODE_HELPER_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseTexturesLabel;
        private System.Windows.Forms.ListView justFolders;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
