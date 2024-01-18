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
    public partial class MatrixValuesControl : UserControl {
        public MatrixValuesControl() {
            InitializeComponent();
        }

        private void MatrixValuesControl_Load(object sender, EventArgs e) {

        }
        public void SetTitleText(string caption) {
            TITLE.Text = caption;
        }

        public string GetX() {
            return valueX.Text;
        }

        public string GetY() {
            return valueY.Text;
        }

        public string GetZ() {
            return valueZ.Text;
        }

        public void SetX(float v) {
            valueX.Text = v.ToString();
        }

        public void SetY(float v) {
            valueY.Text = v.ToString();
        }

        public void SetZ(float v) {
            valueZ.Text = v.ToString();
        }
        public bool isAllZero() {
            if (float.Parse(valueX.Text) == 0 && float.Parse(valueY.Text) == 0 && float.Parse(valueZ.Text) == 0) {
                return true;
            } else {
                return false;
            }
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
