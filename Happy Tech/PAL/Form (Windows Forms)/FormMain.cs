using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Tech.PAL.Form__Windows_Forms_
{
    public partial class FormMain : Form
    {
        public string Username;

        public FormMain()
        {
            InitializeComponent();
        }

        private void MoveSidePanel(Control button)
        {
            pnlSlide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 184);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to close this application?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picClose, "Close");
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picMinimize, "Minimize");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDashboard);
            userControlSetting1.Visible = false;
            userControlFeedback1.Visible = false;
            userControlCode1.Visible = false;
            userControlTemplate1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnTemplate);
            userControlSetting1.Visible = false;
            userControlFeedback1.Visible = false;
            userControlCode1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlTemplate1.EmptyBox();
            userControlTemplate1.Visible = true;
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnCode);
            userControlSetting1.Visible = false;
            userControlFeedback1.Visible = false;
            userControlTemplate1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlCode1.EmptyBox();
            userControlCode1.Visible = true;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnFeedback);
            userControlSetting1.Visible = false;
            userControlCode1.Visible = false;
            userControlTemplate1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlFeedback1.EmptyBox();
            userControlFeedback1.Visible = true;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnSetting);
            userControlFeedback1.Visible = false;
            userControlCode1.Visible = false;
            userControlTemplate1.Visible = false;
            userControlDashboard1.Visible = false;
            userControlSetting1.EmptyBox();
            userControlSetting1.Visible = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
        }
    }
}
