using System;
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
    public partial class UserControlCode : UserControl
    {
        private string Id = "";

        public UserControlCode()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            tcCode.SelectedTab = tpAddCode;
            txtCodeTitle.Clear();
            txtCodeBody.Clear();
        }

        private void EmptyBox1()
        {
            txtCodeTitle1.Clear();
            txtCodeBody1.Clear();
            Id = "";
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCodeTitle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter code title.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCodeBody.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter code body.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Code code = new Code(txtCodeTitle.Text.Trim(), txtCodeBody.Text.Trim());
                HappyTechDB.AddCode(code);
                EmptyBox();
            }
        }

        private void tpAddCode_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageCode_Enter(object sender, EventArgs e)
        {
            txtSearchCodeTitle.Clear();
            dgvCodes.Columns[0].Visible = false;
            HappyTechDB.DisplayAndSearch("SELECT * FROM Codes;", dgvCodes);
            lblTotal.Text = dgvCodes.Rows.Count.ToString();
        }

        private void txtSearchCodeTitle_TextChanged(object sender, EventArgs e)
        {
            HappyTechDB.DisplayAndSearch("SELECT * FROM Codes WHERE Code_Title LIKE '%" + txtSearchCodeTitle.Text + "%';", dgvCodes);
            lblTotal.Text = dgvCodes.Rows.Count.ToString();
        }

        private void dgvCodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCodes.Rows[e.RowIndex];
                Id = row.Cells[0].Value.ToString();
                txtCodeTitle1.Text = row.Cells[1].Value.ToString();
                txtCodeBody1.Text = row.Cells[2].Value.ToString();
                tcCode.SelectedTab = tpEditAndRemoveCode;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCodeTitle1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter code title.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCodeBody1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter code body.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Code code = new Code(txtCodeTitle1.Text.Trim(), txtCodeBody1.Text.Trim());
                HappyTechDB.UpdateCode(code, Id);
                EmptyBox1();
                tcCode.SelectedTab = tpManageCode;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Id == "")
            {
                MessageBox.Show("Please select row from table.", "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you want to delete this code?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    HappyTechDB.DeleteCode(Id);
                    EmptyBox1();
                    tcCode.SelectedTab = tpManageCode;
                }
            }
        }

        private void tpEditAndRemoveCode_Enter(object sender, EventArgs e)
        {
            if (Id == "")
                tcCode.SelectedTab = tpManageCode;
        }

        private void tpEditAndRemoveCode_Leave(object sender, EventArgs e)
        {
            EmptyBox1();
        }
    }
}
