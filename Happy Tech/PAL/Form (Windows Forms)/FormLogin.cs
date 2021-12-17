using Happy_Tech.DAL;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
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

        private void picShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picShow, "Show Password");
        }

        private void picHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picHide, "Hide Password");
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            picShow.Visible = false;
            picHide.Visible = true;
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            picShow.Visible = true;
            picHide.Visible = false;
        }

        private void btnSecureLogIn_Click(object sender, EventArgs e)
        {
            bool Check = HappyTechDB.IsValidNamePass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (txtUsername.Text.Trim() != string.Empty && txtPassword.Text.Trim() != string.Empty)
            {
                if (Check)
                {
                    Hide();
                    FormMain formMain = new FormMain();
                    formMain.Username = txtUsername.Text;
                    txtUsername.Clear();
                    txtPassword.Clear();
                    picHide_Click(sender, e);
                    txtUsername.Focus();
                    picError.Hide();
                    lblError.Hide();
                    formMain.Show();
                }
                else
                {
                    picError.Show();
                    lblError.Show();
                }
            }
        }
    }
}
