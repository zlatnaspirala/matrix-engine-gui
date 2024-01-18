
namespace matrix_engine {
    partial class MatrixValuesControl {
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
            this.valueZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.valueY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valueX = new System.Windows.Forms.TextBox();
            this.TITLE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(225, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 104;
            this.label8.Text = "z:";
            // 
            // valueZ
            // 
            this.valueZ.BackColor = System.Drawing.Color.Black;
            this.valueZ.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueZ.ForeColor = System.Drawing.Color.DarkOrange;
            this.valueZ.Location = new System.Drawing.Point(242, 8);
            this.valueZ.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.valueZ.Multiline = true;
            this.valueZ.Name = "valueZ";
            this.valueZ.Size = new System.Drawing.Size(44, 21);
            this.valueZ.TabIndex = 103;
            this.valueZ.Text = "0";
            this.valueZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionZ_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(151, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 15);
            this.label7.TabIndex = 102;
            this.label7.Text = "y:";
            // 
            // valueY
            // 
            this.valueY.BackColor = System.Drawing.Color.Black;
            this.valueY.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueY.ForeColor = System.Drawing.Color.DarkOrange;
            this.valueY.Location = new System.Drawing.Point(173, 8);
            this.valueY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.valueY.Multiline = true;
            this.valueY.Name = "valueY";
            this.valueY.Size = new System.Drawing.Size(44, 21);
            this.valueY.TabIndex = 101;
            this.valueY.Text = "0";
            this.valueY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionY_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Orbitron", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(80, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 100;
            this.label6.Text = "x:";
            // 
            // valueX
            // 
            this.valueX.BackColor = System.Drawing.Color.Black;
            this.valueX.Font = new System.Drawing.Font("Orbitron", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueX.ForeColor = System.Drawing.Color.DarkOrange;
            this.valueX.Location = new System.Drawing.Point(99, 8);
            this.valueX.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.valueX.Multiline = true;
            this.valueX.Name = "valueX";
            this.valueX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.valueX.Size = new System.Drawing.Size(44, 21);
            this.valueX.TabIndex = 99;
            this.valueX.Text = "0";
            this.valueX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.positionX_KeyPress);
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.BackColor = System.Drawing.Color.Transparent;
            this.TITLE.Font = new System.Drawing.Font("Orbitron", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.ForeColor = System.Drawing.Color.OrangeRed;
            this.TITLE.Location = new System.Drawing.Point(9, 10);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(51, 16);
            this.TITLE.TabIndex = 98;
            this.TITLE.Text = "TITLE";
            // 
            // MatrixValuesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valueZ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valueY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valueX);
            this.Controls.Add(this.TITLE);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "MatrixValuesControl";
            this.Size = new System.Drawing.Size(302, 38);
            this.Load += new System.EventHandler(this.MatrixValuesControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox valueZ;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox valueY;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox valueX;
        private System.Windows.Forms.Label TITLE;
    }
}
