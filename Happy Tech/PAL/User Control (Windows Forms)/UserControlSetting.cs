﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Happy_Tech.BAL;
using Happy_Tech.DAL;

namespace Happy_Tech.PAL.User_Control__Windows_Forms_
{
    public partial class UserControlSetting : UserControl
    {
        private string Id = "";

        public UserControlSetting()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcUser.SelectedTab = tpAddUser;
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void EmptyBox1()
        {
            txtUsername1.Clear();
            txtPassword1.Clear();
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            Id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter password.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User user = new User(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                HappyTechDB.AddUser(user);
                EmptyBox();
            }
        }

        private void tpAddUser_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageUser_Enter(object sender, EventArgs e)
        {
            txtSearchUsername.Clear();
            dgvUsers.Columns[0].Visible = false;
            HappyTechDB.DisplayAndSearch("SELECT * FROM Users;", dgvUsers);
            lblTotal.Text = dgvUsers.Rows.Count.ToString();
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            HappyTechDB.DisplayAndSearch("SELECT * FROM Users WHERE User_Name LIKE '%" + txtSearchUsername.Text + "%';", dgvUsers);
            lblTotal.Text = dgvUsers.Rows.Count.ToString();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtUsername1.Text = row.Cells[1].Value.ToString();
                txtPassword1.Text = row.Cells[2].Value.ToString();
                tcUser.SelectedTab = tpEditAndRemoveUser;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtUsername1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter user name.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtOldPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter old password.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword1.Text.Trim() != txtOldPassword.Text.Trim())
            {
                MessageBox.Show("Password did not match.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtNewPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter new password.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                User user = new User(txtUsername1.Text.Trim(), txtNewPassword.Text.Trim());
                HappyTechDB.UpdateUser(user, Id);
                EmptyBox1();
                tcUser.SelectedTab = tpManageUser;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtOldPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter old password.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtPassword1.Text.Trim() != txtOldPassword.Text.Trim())
            {
                MessageBox.Show("Password did not match.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this user?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    HappyTechDB.DeleteUser(Id);
                    EmptyBox1();
                    tcUser.SelectedTab = tpManageUser;
                }
            }
        }

        private void tpEditAndRemoveUser_Enter(object sender, EventArgs e)
        {
            if (Id == "")
                tcUser.SelectedTab = tpManageUser;
        }

        private void tpEditAndRemoveUser_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }

        private void dgvUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                dgvUsers.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
