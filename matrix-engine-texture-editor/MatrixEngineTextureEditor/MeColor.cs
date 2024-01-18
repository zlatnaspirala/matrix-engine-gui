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
    public partial class MeColor : UserControl {
        public MeColor() {
            InitializeComponent();
        }

        private void MeColor_Load(object sender, EventArgs e) {

        }

        public void SetTitleText(string caption) {
            TITLE.Text = caption;
        }

        public string GetR() {
            return valueR.Text;
        }

        public string GetG() {
            return valueG.Text;
        }

        public string GetB() {
            return valueB.Text;
        }

        public void SetR(float v) {
            valueR.Text = v.ToString();
        }

        public void SetG(float v) {
            valueG.Text = v.ToString();
        }

        public void SetB(float v) {
            valueB.Text = v.ToString();
        }

        private void positionX_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void positionY_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void positionZ_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }
    }
}
