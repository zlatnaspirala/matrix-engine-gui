using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix_engine {
    public partial class Examples : Form {
        public Examples() {
            InitializeComponent();
        }

        private void Examples_Load(object sender, EventArgs e) {
            EXAMPLES_BROWSER.LoadUrl("https://github.com/zlatnaspirala/matrix-engine/tree/master/apps");
            DEMOS.LoadUrl("https://maximumroulette.com/apps/matrix-engine/examples-build.html");
        }
    }
}
