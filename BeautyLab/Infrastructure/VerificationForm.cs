using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyLab
{
    public partial class VerificationForm : Form
    {
        private readonly int _code;
        private bool result = false;
        public VerificationForm(int _securityCode)
        {
            InitializeComponent();
            _code = _securityCode;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var isValidCode = int.TryParse(txtCode.Text, out int localCode);

            if (!isValidCode)
            {
                labelError.Text = "Неверный формат кода";
                labelError.ForeColor = Color.Red;
                CenterLabel();
                return;
            }

            if (localCode != _code)
            {
                labelError.Text = "Неверный код";
                labelError.ForeColor = Color.Red;
                CenterLabel();
            }
            else
            {
                result = true;
                Close();
            }
        }

        public bool GetResult()
        {
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = false;
            Close();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Length < 6)
            {
                btnEnter.Enabled = false;
            }
            else
            {
                btnEnter.Enabled = true;
            }
        }
    }
}
