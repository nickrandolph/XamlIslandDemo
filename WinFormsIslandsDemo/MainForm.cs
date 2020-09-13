using System;
using System.Windows.Forms;

namespace WinFormsIslandsDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSimpleButton_Click(object sender, EventArgs e)
        {
            new SimpleButtonForm().ShowDialog();
        }
        private void btnCustomControl_Click(object sender, EventArgs e)
        {
            new CustomControlForm().ShowDialog();
        }
        private void btnThirdPartyControl_Click(object sender, EventArgs e)
        {
            new ThirdPartyControlForm().ShowDialog();
        }
        private void btnThirdPartyControlWithStyle_Click(object sender, EventArgs e)
        {
            new ThirdPartyControlWithStyleForm().ShowDialog();
        }
    }
}
