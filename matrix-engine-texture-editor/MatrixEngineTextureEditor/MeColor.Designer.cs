
namespace matrix_engine {
    partial class MeColor {
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
            this.label8 = new System.Windows.Forms.Label();
            this.valueB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.valueG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valueR = new System.Windows.Forms.TextBox();
            this.TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(307, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 15);
            this.label8.TabIndex = 110;
            this.label8.Text = "B:";
            // 
            // valueB
            // 
            this.valueB.BackColor = System.Drawing.Color.Black;
            this.valueB.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueB.ForeColor = System.Drawing.Color.DarkOrange;
            this.valueB.Location = new System.Drawing.Point(326, 12);
            this.valueB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.valueB.Multiline = true;
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(44, 21);
            this.valueB.TabIndex = 109;
            this.valueB.Text = "0";
            this.valueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionZ_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(240, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 108;
            this.label7.Text = "G:";
            // 
            // valueG
            // 
            this.valueG.BackColor = System.Drawing.Color.Black;
            this.valueG.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueG.ForeColor = System.Drawing.Color.DarkOrange;
            this.valueG.Location = new System.Drawing.Point(259, 12);
            this.valueG.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.valueG.Multiline = true;
            this.valueG.Name = "valueG";
            this.valueG.Size = new System.Drawing.Size(44, 21);
            this.valueG.TabIndex = 107;
            this.valueG.Text = "0";
            this.valueG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionY_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(174, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = "R:";
            // 
            // valueR
            // 
            this.valueR.BackColor = System.Drawing.Color.Black;
            this.valueR.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueR.ForeColor = System.Drawing.Color.DarkOrange;
            this.valueR.Location = new System.Drawing.Point(193, 12);
            this.valueR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.valueR.Multiline = true;
            this.valueR.Name = "valueR";
            this.valueR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.valueR.Size = new System.Drawing.Size(44, 21);
            this.valueR.TabIndex = 105;
            this.valueR.Text = "0";
            this.valueR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionX_KeyPress);
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.BackColor = System.Drawing.Color.Transparent;
            this.TITLE.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.Color.OrangeRed;
            this.TITLE.Location = new System.Drawing.Point(6, 14);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(51, 16);
            this.TITLE.TabIndex = 111;
            this.TITLE.Text = "TITLE";
            // 
            // MeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valueB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valueG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valueR);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.Name = "MeColor";
            this.Size = new System.Drawing.Size(383, 48);
            this.Load += new System.EventHandler(this.MeColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox valueB;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox valueG;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox valueR;
        private System.Windows.Forms.Label TITLE;
    }
}
