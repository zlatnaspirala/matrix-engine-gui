
namespace matrix_engine {
    partial class Examples {
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
            this.EXAMPLES_BROWSER = new CefSharp.WinForms.ChromiumWebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DEMOS = new CefSharp.WinForms.ChromiumWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EXAMPLES_BROWSER
            // 
            this.EXAMPLES_BROWSER.ActivateBrowserOnCreation = true;
            this.EXAMPLES_BROWSER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EXAMPLES_BROWSER.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.EXAMPLES_BROWSER.Location = new System.Drawing.Point(0, 0);
            this.EXAMPLES_BROWSER.Margin = new System.Windows.Forms.Padding(0);
            this.EXAMPLES_BROWSER.Name = "EXAMPLES_BROWSER";
            this.EXAMPLES_BROWSER.Size = new System.Drawing.Size(292, 525);
            this.EXAMPLES_BROWSER.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EXAMPLES_BROWSER);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DEMOS);
            this.splitContainer1.Size = new System.Drawing.Size(856, 525);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.SplitterIncrement = 2;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 2;
            // 
            // DEMOS
            // 
            this.DEMOS.ActivateBrowserOnCreation = true;
            this.DEMOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DEMOS.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.DEMOS.Location = new System.Drawing.Point(0, 0);
            this.DEMOS.Margin = new System.Windows.Forms.Padding(0);
            this.DEMOS.Name = "DEMOS";
            this.DEMOS.Size = new System.Drawing.Size(554, 525);
            this.DEMOS.TabIndex = 2;
            // 
            // Examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 525);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Examples";
            this.Text = "Examples";
            this.Load += new System.EventHandler(this.Examples_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public CefSharp.WinForms.ChromiumWebBrowser EXAMPLES_BROWSER;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public CefSharp.WinForms.ChromiumWebBrowser DEMOS;
    }
}